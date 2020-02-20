using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookCar.SharedComponent.Param;
using BookCarBLL;
using BookCar.SharedComponent.Entities;
using BookCarBLL.Admin;
using BookCar.SharedComponent.Constant;
using BookCar.Utils;

namespace BookCar2.Views.BookCar
{
    public partial class BookCar : System.Web.UI.Page
    {
        #region Page Methods
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SetUpForm();
                LoadData();
            }
        }
        protected void grdData_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Car item = (Car)e.Item.DataItem;
                Literal ltrCarID = (Literal)e.Item.FindControl("ltrCarID");
                Literal ltrColor = (Literal)e.Item.FindControl("ltrColor");
                Literal ltrPrice = (Literal)e.Item.FindControl("ltrPrice");
                LinkButton ltrPlateNumber = (LinkButton)e.Item.FindControl("ltrPlateNumber");

                ltrCarID.Text = item.CarID.ToString();
                ltrColor.Text = item.Color.ToString();
                ltrPrice.Text = item.Price.ToString();
                ltrPlateNumber.Text = item.PlateNumber.ToString();
            }
        }
        protected void grdData_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            grdData.CurrentPageIndex = e.NewPageIndex;
            LoadData();
        }
        protected void grdData_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "ViewItems":
                    {
                        Literal ltrCarID = (Literal)e.Item.FindControl("ltrCarID");
                        int id = int.Parse(ltrCarID.Text);
                        Response.Redirect("Display.aspx?id=" + id);
                        break;
                    }
                case "EditItems":
                    {
                        Literal ltrCarID = (Literal)e.Item.FindControl("ltrCarID");
                        int id = int.Parse(ltrCarID.Text);
                        Response.Redirect("Edit.aspx?id=" + id);
                        break;
                    }
                default:
                    break;
            }
        }
        protected void ddlTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckTime();
        }
        protected void btnConfirm_Click(object sender, EventArgs e)
        {

            try
            {
                CarParam carParam = new CarParam(FunctionType.ServiceOrderFunction.AddNewServiceOrder);
                carParam.ServiceOrder = GetObjectInForm();
                MainController.Provider.Execute(carParam);
                Response.Redirect("~/Views/Default.aspx");
            }
            catch (Exception ex)
            {

            }

        }
        #endregion

        #region private methods
        private void CheckTime()
        {
            DateTime StartTime = Convert.ToDateTime(Request.QueryString["TimeS"]);
            DateTime EndTime = Convert.ToDateTime(Request.QueryString["TimeE"]);
            TimeSpan OrderDuration = EndTime - StartTime;
            if (ddlTime.SelectedValue == "1")
            {
                lblOD.Text = Utility.GetHoursDuration(StartTime, EndTime);
            }
            if (ddlTime.SelectedValue == "2")
            {
                lblOD.Text = Utility.GetDaysDuration(StartTime, EndTime);
            }
            lblPS.Text = Utility.DateTimeToString(StartTime);
            lblPE.Text = Utility.DateTimeToString(EndTime);
        }
        private void SetUpForm()
        {
            FillDropDown();
            CheckTime();
        }
        private void LoadData()
        {
            Car enCar = new Car();
            enCar.CarID = int.Parse(Request.QueryString["CarID"]);
            CarParam param = new CarParam(FunctionType.CarFunction.SearchCar);
            param.CurrentPageIndex = grdData.CurrentPageIndex;
            param.Pagesize = grdData.PageSize;
            param.Car = enCar;
            MainController.Provider.Execute(param);
            List<Car> lstItem = param.ListCar;
            grdData.VirtualItemCount = param.TotalItem.Value;
            grdData.DataSource = lstItem;
            grdData.DataBind();
        }
        private void FillDropDown()
        {
            TimeCategoryBiz biz = new TimeCategoryBiz();
            CarParam carParam = new CarParam("");
            TimeCategory timeCategory = new TimeCategory();
            carParam.TimeCategory = timeCategory;
            biz.SearchTimeCategory(carParam);
            List<TimeCategory> ListTimeCategory = carParam.ListTimeCategory;
            ddlTime.DataSource = ListTimeCategory;
            ddlTime.DataBind();
        }
        private ServiceOrder GetObjectInForm()
        {
            ServiceOrder serviceOrder = new ServiceOrder();
            DateTime StartTime = Convert.ToDateTime(Request.QueryString["TimeS"]);
            DateTime EndTime = Convert.ToDateTime(Request.QueryString["TimeE"]);
            foreach (DataGridItem item in grdData.Items)
            {
                Literal ltrCarID = (Literal)item.FindControl("ltrCarID");
                serviceOrder.CarID = int.Parse(ltrCarID.Text);
                serviceOrder.TimeCategory = int.Parse(ddlTime.SelectedValue);
                serviceOrder.OrderDuration = int.Parse(lblOD.Text);
                serviceOrder.PlanStartDTG = StartTime;
                serviceOrder.PlanEndDTG = EndTime;
                serviceOrder.CustomerName = txtName.Text;
                serviceOrder.Description = "";
                serviceOrder.Status = 0;
                serviceOrder.CreatedBy = txtName.Text;
                serviceOrder.CreatedDTG = DateTime.Now;
            }
            return serviceOrder;
        }
        #endregion
    }
}