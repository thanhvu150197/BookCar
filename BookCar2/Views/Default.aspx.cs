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

namespace BookCar2.Views
{
    public partial class Default : System.Web.UI.Page
    {
        #region Page Events
        protected void Page_Load(object sender, EventArgs e)
        {          
            if (!Page.IsPostBack)
            {
                SetUpForm();
                LoadData();  
            }
        }
        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        protected void grvCar_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            grvCar.CurrentPageIndex = e.NewPageIndex;
            LoadData();
        }
        protected void grvCar_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            string TimeS = Convert.ToDateTime(dpTimeStart.SelectedDate).ToShortDateString() + " " + tpStar.SelectedTime.ToString();
            string TimeE = Convert.ToDateTime(dpTimeEnd.SelectedDate).ToShortDateString() + " " + tpEnd.SelectedTime.ToString();
  
            switch (e.CommandName)
            {
                case "ViewItems":
                    {
                        Literal ltrCarID = (Literal)e.Item.FindControl("ltrCarID");
                        int id = int.Parse(ltrCarID.Text);
                        Response.Redirect("~/Views/BookCar/DisplayCar.aspx?id=" + id);
                        break;
                    }
                case "Book":
                    {
                        Literal ltrCarID = (Literal)e.Item.FindControl("ltrCarID");
                        int id = int.Parse(ltrCarID.Text);
                        if (CheckTimeBooking(id))
                            Response.Redirect("~/Views/BookCar/Default.aspx?CarID=" + id + "&TimeS=" + TimeS + "&TimeE=" + TimeE);
                        else
                            lblMess.Text = "*Can't Book.Please check Time Order or list Orders of this Car before";
                        break;
                    }
                default:
                    // Do nothing.
                    break;

            }
        }
        protected void grvCar_ItemDataBound(object sender, DataGridItemEventArgs e)
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
        #endregion
        #region Private Methods
        private void SetUpForm()
        {
            dpTimeStart.SelectedDate = DateTime.Now;
            dpTimeEnd.SelectedDate = DateTime.Now.AddDays(1);
            tpStar.SelectedHour = 0;
            tpStar.SelectedMinute = 0;
            tpStar.SelectedSecond = 0;
            tpEnd.SelectedHour = 0;
            tpEnd.SelectedMinute = 0;
            tpEnd.SelectedSecond = 0;
            FillDropDown();
            ddlCar.SelectedValue = "0";
        }
        private void FillDropDown()
        {
            CarParam carParam = new CarParam(FunctionType.CarCategoryFunction.SearchCarCategoryNoPaging);
            List<CarCategory> ListCarCategory = new List<CarCategory>();
            CarCategory enCarCategory = new CarCategory();
            carParam.CarCategory = enCarCategory;
            MainController.Provider.Execute(carParam);
            ListCarCategory = carParam.ListCarCategories;
            ddlCar.DataSource = ListCarCategory;
            ddlCar.DataBind();
        }
        private void LoadData()
        {
            CarParam param = new CarParam(FunctionType.CarFunction.SearchCar);
            param.CurrentPageIndex = grvCar.CurrentPageIndex;
            param.Pagesize = grvCar.PageSize;
            param.Car = GetSearch();
            MainController.Provider.Execute(param);
            List<Car> lstItem = param.ListCar;
            grvCar.VirtualItemCount = param.TotalItem.Value;
            grvCar.DataSource = lstItem;
            grvCar.DataBind();
            lblMess.Text = "";
        }
        private Car GetSearch()
        {
            Car enCar = new Car();
            enCar.CategoryID = int.Parse(ddlCar.SelectedValue);
            return enCar;
        }
        private bool CheckTimeBooking(int id)
        {
            string TempStart = Convert.ToDateTime(dpTimeStart.SelectedDate).ToShortDateString() + " " + tpStar.SelectedTime.ToString();
            string TempEnd = Convert.ToDateTime(dpTimeEnd.SelectedDate).ToShortDateString() + " " + tpEnd.SelectedTime.ToString();
            if (Utility.CompateStringDate(TempEnd, TempStart) > 0)
            {
                return false;
            }
            CarParam param = new CarParam(FunctionType.ServiceOrderFunction.SearchServiceOrder);
            List<ServiceOrder> ListItems = new List<ServiceOrder>();
            ServiceOrder enServiceOrder = new ServiceOrder();
            enServiceOrder.CarID = id;
            enServiceOrder.Status = int.Parse(ServiceStatus.Booking);
            param.Pagesize = 100;
            param.ServiceOrder = enServiceOrder;
            MainController.Provider.Execute(param);
            ListItems = param.ListServiceOrder;
            foreach (ServiceOrder item in ListItems)
            {
                if(Utility.CompateStringDate(item.PlanStartDTG.ToString(),TempStart) >0 && Utility.CompateStringDate(TempStart, item.PlanEndDTG.ToString()) >0)
                {
                    return false;
                }
                if (Utility.CompateStringDate(item.PlanStartDTG.ToString(), TempEnd) > 0 && Utility.CompateStringDate(TempEnd, item.PlanEndDTG.ToString()) > 0)
                {
                    return false;
                }
                if(Utility.CompateStringDate(TempStart,item.PlanStartDTG.ToString()) > 0 && Utility.CompateStringDate(item.PlanEndDTG.ToString(),TempEnd) > 0)
                {
                    return false;
                }

            }
            return true;
        }
        #endregion

      
    }
}