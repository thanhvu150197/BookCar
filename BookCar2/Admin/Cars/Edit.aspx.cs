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
    public partial class Edit : System.Web.UI.Page
    {

        #region Page Events
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                LoadData();
            }
        }

        protected void btnUS_Click(object sender, EventArgs e)
        {
            try
            {

                CarsBiz carsBiz = new CarsBiz();
                Car InsCar = new Car();
                string CarID = Request.QueryString["id"].ToString();
                InsCar.CarID = int.Parse(CarID);
                InsCar.CategoryID = int.Parse(ddlCategory.SelectedValue.Trim());
                InsCar.Color = txtColor.Text;

                if (String.IsNullOrEmpty(txtPrice.Text))
                {
                    InsCar.Price = 0;
                }
                InsCar.Price = decimal.Parse(txtPrice.Text);
                InsCar.PlateNumber = txtPlateNumber.Text;
                InsCar.Description = txtDes.Text;
                InsCar.UpdatedBy = "Thanh";
                InsCar.UpdatedDTG = DateTime.Now;


                carsBiz.UpdateCar(InsCar);
                lblMess.Text = Messenger.UpdateCompleted;

            }
            catch (Exception ex)
            {
                lblMess.Text = Messenger.UpdateFailed;
                throw;

            }

        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/Cars/Default.aspx");
        }
        #endregion

        #region Private Methods
        protected void FillDropDown()
        {
            DefaultBLL defaultBLL = new DefaultBLL();
            CarParam carParam = new CarParam();
            //List loai xe
            List<CarCategory> ListCarCategory = new List<CarCategory>();
            defaultBLL.SearchAllCarCategory(carParam);
            ListCarCategory = carParam.ListCarCategories;
            ddlCategory.DataSource = ListCarCategory;
            ddlCategory.DataBind();
        }
        protected void LoadData()
        {
            CarsBiz CarsBiz = new CarsBiz();
            CarParam carParam = new CarParam();
            List<Car> ListCar = new List<Car>();
            Car enCar = new Car();
            string CarID = Request.QueryString["id"].ToString();
            enCar.CarID = int.Parse(CarID);
            enCar.Color = "";
            carParam.Car = enCar;
            CarsBiz.SearchItems(carParam);
            enCar = carParam.Car;
            //Fill TextBox
            txtColor.Text = enCar.Color;
            txtDes.Text = enCar.Description;
            txtPlateNumber.Text = enCar.PlateNumber;
            txtPrice.Text = enCar.Price.ToString();
            lblCrBy.Text = enCar.CreatedBy;
            lblCrDTG.Text = enCar.CreatedBy;
            lblUpBy.Text = enCar.UpdatedBy;
            lblUpDTG.Text = enCar.UpdatedDTG.ToString();

            FillDropDown();

        }
        private void ClearTextBoxes()
        {
            txtColor.Text = "";
            txtDes.Text = "";
            txtPlateNumber.Text = "";
            txtPrice.Text = "";
        }
        #endregion




    }
}
