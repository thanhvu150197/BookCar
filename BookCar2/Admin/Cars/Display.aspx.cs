using BookCar.SharedComponent.Constant;
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
                SetupForm();
                LoadData();
            }
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            string Fr = Request.QueryString["Fr"];
            string Stt = Request.QueryString["Stt"];
            if (String.IsNullOrEmpty(Fr))
                Response.Redirect("~/Admin/Cars/Default.aspx");
            else Response.Redirect("~/Admin/ServiceOrders/ServiceOrder.aspx?Stt=" + Stt);
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

        }
       
        private void BindObjectToForm(Car item)
        {
            txtColor.Text = item.Color;
            txtDes.Text = item.Description;
            txtPlateNumber.Text = item.PlateNumber;
            txtPrice.Text = item.Price.ToString();
            txtCategoryName.Text = item.CategoryID.ToString();
            lblCrBy.Text = item.CreatedBy;
            lblCrDTG.Text = item.CreatedBy;
            lblUpBy.Text = item.UpdatedBy;
            lblUpDTG.Text = item.UpdatedDTG.ToString();
        }
        #endregion
    }
}