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
    public partial class AddNew : System.Web.UI.Page
    {
        #region Page Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillDropDown();
            }

        }
        private void btnUS_Click(object sender, EventArgs e)
        {
            try
            {

                AdminDefaultBLL AdBLL = new AdminDefaultBLL();
                Car InsCar = new Car();
                InsCar.CategoryID = int.Parse(ddlCategory.SelectedValue.Trim());
                InsCar.Color = txtColor.Text;

                if (String.IsNullOrEmpty(txtPrice.Text))
                {
                    InsCar.Price = 0;
                }
                InsCar.Price = decimal.Parse(txtPrice.Text);
                InsCar.PlateNumber = txtPlateNumber.Text;
                InsCar.Description = txtDes.Text;
                InsCar.CreatedBy = "Thanh";
                InsCar.CreatedDTG = DateTime.Now;
                InsCar.Version = 0;
                InsCar.Deleted = 0;
                AdBLL.ThemXe(InsCar);
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
        private void FillDropDown()
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