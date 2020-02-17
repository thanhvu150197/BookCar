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

namespace BookCar2.Views
{
    public partial class Default : System.Web.UI.Page
    {
        CarParam _carParam = new CarParam();
        protected void Page_Load(object sender, EventArgs e)
        {          
            if (!Page.IsPostBack)
            {
                Car enCar = new Car();
                _carParam.Car = enCar;
                SetTimeStart();
                Fill();
                ddlCar.SelectedValue = "0";
                DisplayCurrentPage(0, _carParam);
            }
        }
        protected void SetTimeStart()
        {
            dpTimeStart.SelectedDate = DateTime.Now;
            dpTimeEnd.SelectedDate = DateTime.Now.AddDays(1);
            tpStar.SelectedHour = 0;
            tpStar.SelectedMinute = 0;
            tpStar.SelectedSecond = 0;
            tpEnd.SelectedHour = 0;
            tpEnd.SelectedMinute = 0;
            tpEnd.SelectedSecond = 0;
        }
      
        protected void ddlCar_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            search();
            DisplayCurrentPage(0, _carParam);
        }
        protected void Fill()
        {
            DefaultBLL defaultBLL = new DefaultBLL();
            CarParam carParam = new CarParam();
            //List loai xe
            List<CarCategory> ListCarCategory = new List<CarCategory>();
            defaultBLL.SearchAllCarCategory(carParam);
            ListCarCategory = carParam.ListCarCategories;
            ddlCar.DataSource = ListCarCategory;
            ddlCar.DataBind();

         
        }

        protected void dpTimeStart_SelectedDateChanged(object sender, EventArgs e)
        {
            
        }
        protected void DisplayCurrentPage(int PageIndex,CarParam carParam)
        {
            CarsBiz CarsBiz = new CarsBiz();     
            List<Car> ListCar = new List<Car>();
            carParam.Pagesize = 5;
            carParam.CurrentPageIndex = PageIndex;

            CarsBiz.SearchItems(carParam);
            ListCar = carParam.ListCar;

            grvCar.VirtualItemCount = carParam.TotalItem.Value;
            grvCar.DataSource = ListCar;
            grvCar.DataBind();

        }

        protected void grvCar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grvCar_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            search();
            grvCar.CurrentPageIndex = e.NewPageIndex;
            DisplayCurrentPage(grvCar.CurrentPageIndex, _carParam);
        }

        protected void grvCar_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            int i = e.Item.ItemIndex;
            int id = 0;
            CarsBiz CarsBiz = new CarsBiz();
            CarParam carParam = new CarParam();

            string TimeS = Convert.ToDateTime(dpTimeStart.SelectedDate).ToShortDateString() + " " + tpStar.SelectedTime.ToString();
            string TimeE = Convert.ToDateTime(dpTimeEnd.SelectedDate).ToShortDateString() + " " + tpEnd.SelectedTime.ToString();

            switch (((LinkButton)e.CommandSource).CommandName)
            {
                case "ViewCar":
                    id = Convert.ToInt32(grvCar.DataKeys[i].ToString());
                    Response.Redirect("~/Display.aspx?v=" + id);
                    break;

                case "Book":
                    id = Convert.ToInt32(grvCar.DataKeys[i].ToString());
                    Response.Redirect("NhanDatXe.aspx?CarID=" + id + "&TimeS=" + TimeS + "&TimeE=" + TimeE);
                    break;
                case "DeleteCar":
                    // DeleteItem(e);
                    break;
                default:
                    // Do nothing.
                    break;

            }
        }
        protected void search()
        {
            Car enCar = new Car();
            enCar.CategoryID = int.Parse(ddlCar.SelectedValue);
            _carParam.Car = enCar;
        }
    }
}