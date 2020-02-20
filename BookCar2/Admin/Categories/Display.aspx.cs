using BookCar.SharedComponent.Entities;
using BookCar.SharedComponent.Param;
using BookCar.SharedComponent.Constant;
using BookCarBLL.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookCarBLL;

namespace BookCar2.Admin.Categories
{
    public partial class Display : System.Web.UI.Page
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
        #endregion

        #region Private Methods
        private void SetUpForm()
        {

        }
        private void LoadData()
        {
            CarParam carParam = new CarParam(FunctionType.CarCategoryFunction.SearchCarCategoryNoPaging);
            CarCategory carCategory = GetObjectInForm();
            carParam.CarCategory = carCategory;
            MainController.Provider.Execute(carParam);
            BindObjectToForm(carParam.CarCategory);
        }
        private CarCategory GetObjectInForm()
        {
            CarCategory item = new CarCategory();
            string CategoryID = Request.QueryString["id"].ToString();
            if (!string.IsNullOrEmpty(CategoryID))
                item.CarCategoryID = int.Parse(CategoryID);
            return item;
        }
        private void BindObjectToForm(CarCategory item)
        {
            txtName.Text = item.Name;
            txtDes.Text = item.Description;
            lblCreatedBy.Text = item.CreatedBy;
            lblCreatedDTG.Text = item.CreatedDTG.ToString();
            lblUpdatedBy.Text = item.UpdatedBy;
            lblUpdatedDTG.Text = item.UpdatedDTG.ToString();
        }
        #endregion
    }
}