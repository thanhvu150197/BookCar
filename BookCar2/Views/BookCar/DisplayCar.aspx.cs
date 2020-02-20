using BookCar.SharedComponent.Constant;
using BookCar.SharedComponent.Entities;
using BookCar.SharedComponent.Param;
using BookCarBLL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookCar2.Views.BookCar
{
    public partial class DisplayCar : System.Web.UI.Page
    {
        #region Page Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SetupForm();
                LoadData();
            }
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Default.aspx");
        }
        protected void grdData_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                ServiceOrder item = (ServiceOrder)e.Item.DataItem;

                Literal ltrCarID = (Literal)e.Item.FindControl("ltrCarID");
                Literal ltrPlanStart = (Literal)e.Item.FindControl("ltrPlanStart");
                Literal ltrPlanEnd = (Literal)e.Item.FindControl("ltrPlanEnd");

                ltrCarID.Text = item.CarID.ToString();
                ltrPlanStart.Text = item.PlanStartDTG.ToString();
                ltrPlanEnd.Text = item.PlanEndDTG.ToString();
            }
        }
        protected void grdData_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            grdData.CurrentPageIndex = e.NewPageIndex;
            LoadData();
        }
        #endregion
        #region Prive Methods
        private void SetupForm()
        {

        }
        private void LoadData()
        {
            CarParam carParam = new CarParam(FunctionType.CarFunction.SearchCar);
            List<Car> ListCar = new List<Car>();
            Car enCar = new Car();
            string CarID = Request.QueryString["id"];
            enCar.CarID = int.Parse(CarID);
            carParam.Car = enCar;
            MainController.Provider.Execute(carParam);
            enCar = carParam.Car;
            BindObjectToForm(enCar);
            LoadDataDisplayDataGrid(CarID);
        }

        private void BindObjectToForm(Car item)
        {
            txtColor.Text = item.Color;
            txtDes.Text = item.Description;
            txtPlateNumber.Text = item.PlateNumber;
            txtPrice.Text = item.Price.ToString();
            txtCategoryName.Text = item.CategoryID.ToString();

        }
        private void LoadDataDisplayDataGrid(string id)
        {
            CarParam carParam = new CarParam(FunctionType.ServiceOrderFunction.SearchServiceOrder);
            List<ServiceOrder> ListService = new List<ServiceOrder>();
            ServiceOrder enServiceOrder = new ServiceOrder();
            enServiceOrder.Status = int.Parse(ServiceStatus.Booking);
            enServiceOrder.CarID = int.Parse(id);
            carParam.Pagesize = 5;
            carParam.CurrentPageIndex = grdData.CurrentPageIndex;
            carParam.ServiceOrder = enServiceOrder;
            MainController.Provider.Execute(carParam);
            ListService = carParam.ListServiceOrder;

            grdData.VirtualItemCount = carParam.TotalItem.Value;
            grdData.DataSource = ListService;
            grdData.DataBind();
        }

        #endregion
    }
}