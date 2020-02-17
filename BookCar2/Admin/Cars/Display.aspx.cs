using BookCar.SharedComponent;
using BookCar.SharedComponent.Entities;
using BookCar.SharedComponent.Param;
using BookCarBLL;
using BookCarBLL.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookCar2.Admin.Cars
{
    
    public partial class Display : System.Web.UI.Page
    {
        #region Page Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadData();
            }
        }
        #endregion
        #region Prive Methods
 
        protected void LoadData()
        {
            CarsBiz CarsBiz = new CarsBiz();
            CarParam carParam = new CarParam();
            List<Car> ListCar = new List<Car>();
            Car enCar = new Car();
            string CarID = Request.QueryString["id"];
            enCar.CarID = int.Parse(CarID);
            enCar.Color = "";
            carParam.Car = enCar;
            CarsBiz.SearchItems(carParam);
            enCar = carParam.Car;

            txtColor.Text = enCar.Color;
            txtDes.Text = enCar.Description;
            txtPlateNumber.Text = enCar.PlateNumber;
            txtPrice.Text = enCar.Price.ToString();
            txtCategoryName.Text = enCar.CategoryID.ToString();
            lblCrBy.Text = enCar.CreatedBy;
            lblCrDTG.Text = enCar.CreatedBy;
            lblUpBy.Text = enCar.UpdatedBy;
            lblUpDTG.Text = enCar.UpdatedDTG.ToString();

        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            string Fr = Request.QueryString["Fr"];
            string Stt= Request.QueryString["Stt"];
            if (String.IsNullOrEmpty(Fr))
            Response.Redirect("~/Admin/Cars/Default.aspx");
            else Response.Redirect("~/Admin/ServiceOrders/ServiceOrder.aspx?Stt="+ Stt);
        }
        #endregion
    }
}