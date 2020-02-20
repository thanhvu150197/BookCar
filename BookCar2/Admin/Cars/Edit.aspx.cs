using BookCar.SharedComponent;
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
    public partial class Edit : System.Web.UI.Page
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

        protected void btnUS_Click(object sender, EventArgs e)
        {
            try
            {
                int? id= UpdateItem();
                Response.Redirect("~/Admin/Cars/Edit.aspx?id="+id+"&Mess=" + Messenger.UpdateCompleted);
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
        private void SetUpForm()
        {
            lblMess.Text = Request.QueryString["Mess"];
        }
        protected void FillDropDown()
        {
            CarParam carParam = new CarParam(FunctionType.CarCategoryFunction.SearchCarCategoryNoPaging);
            List<CarCategory> ListCarCategory = new List<CarCategory>();
            CarCategory enCarCategory = new CarCategory();
            carParam.CarCategory = enCarCategory;
            MainController.Provider.Execute(carParam);
            ListCarCategory = carParam.ListCarCategories;
            ddlCategory.DataSource = ListCarCategory;
            ddlCategory.DataBind();
        }
        protected void LoadData()
        {
            CarParam carParam = new CarParam(FunctionType.CarFunction.SearchCar);
            List<Car> ListCar = new List<Car>();
            Car enCar = new Car();
            string CarID = Request.QueryString["id"];
            if(!string.IsNullOrEmpty(CarID))
                 enCar.CarID = int.Parse(CarID);
            carParam.Car = enCar;
            MainController.Provider.Execute(carParam);
            enCar = carParam.Car;
            BindObjectToForm(enCar);
            FillDropDown();

        }
        private void ClearTextBoxes()
        {
            txtColor.Text = "";
            txtDes.Text = "";
            txtPlateNumber.Text = "";
            txtPrice.Text = "";
        }
        private void BindObjectToForm(Car item)
        {
            txtColor.Text = item.Color;
            txtDes.Text = item.Description;
            txtPlateNumber.Text = item.PlateNumber;
            txtPrice.Text = item.Price.ToString();
            lblCrBy.Text = item.CreatedBy;
            lblCrDTG.Text = item.CreatedBy;
            lblUpBy.Text = item.UpdatedBy;
            lblUpDTG.Text = item.UpdatedDTG.ToString();
        }
        private Car GetObjectInForm()
        {
            Car enCar = new Car();
            string CarID = Request.QueryString["id"].ToString();
            enCar.CarID = int.Parse(CarID);
            enCar.CategoryID = int.Parse(ddlCategory.SelectedValue.Trim());
            enCar.Color = txtColor.Text;
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                enCar.Price = 0;
            }
            enCar.Price = decimal.Parse(txtPrice.Text);
            enCar.PlateNumber = txtPlateNumber.Text;
            enCar.Description = txtDes.Text;

            return enCar;
        }
        private int? UpdateItem()
        {
            CarParam param = new CarParam(FunctionType.CarFunction.UpdateCar);
            Car enCar = GetObjectInForm();
            param.Car = enCar;
            MainController.Provider.Execute(param);
            return enCar.CarID;
        }
        #endregion
    }
}
