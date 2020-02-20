using BookCar.SharedComponent;
using BookCar.SharedComponent.Entities;
using BookCar.SharedComponent.Constant;
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
    public partial class AddNew : System.Web.UI.Page
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
        protected void btnUS_Click1(object sender, EventArgs e)
        {
            try
            {
                AddNewItem();
                lblMess.Text = Messenger.InsertCompleted;
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                lblMess.Text = Messenger.InsertFailed;
                throw;

            }
        }
        #endregion

        #region Private Methods
        private void SetupForm()
        {

        }

        private void LoadData()
        {       
            CarParam carParam = new CarParam(FunctionType.CarCategoryFunction.SearchCarCategoryNoPaging);
            CarCategory enCarCategory = new CarCategory();
            List<CarCategory> ListCarCategory = new List<CarCategory>();
            carParam.CarCategory = enCarCategory;
            MainController.Provider.Execute(carParam);
            ListCarCategory = carParam.ListCarCategories;
            ddlCategory.DataSource = ListCarCategory;
            ddlCategory.DataBind();
        }
        private void ClearTextBoxes()
        {
            txtColor.Text = "";
            txtDes.Text = "";
            txtPlateNumber.Text = "";
            txtPrice.Text = "";
        }
        private Car GetObjectInForm()
        {
            Car item = new Car();
            item.CategoryID = int.Parse(ddlCategory.SelectedValue.Trim()); ;
            item.Price = decimal.Parse(txtPrice.Text);
            item.Color = txtColor.Text;
            item.PlateNumber = txtPlateNumber.Text;
            item.Description = txtDes.Text;
            item.CreatedBy = "Thanh";
            item.CreatedDTG = DateTime.Now;
            return item;
        }
        private void AddNewItem()
        {
            CarParam carParam = new CarParam(FunctionType.CarFunction.AddNewCar);
            Car item = GetObjectInForm();
            carParam.Car = item;
            MainController.Provider.Execute(carParam);
        }
        #endregion
    }
}