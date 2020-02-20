using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookCar.SharedComponent;
using BookCar.SharedComponent.Constant;
using BookCar.SharedComponent.Entities;
using BookCar.SharedComponent.Param;
using BookCarBLL;
using BookCarBLL.Admin;

namespace BookCar2.Admin.Categories
{
    public partial class AddNew : System.Web.UI.Page
    {
        #region Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SetUpForm();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewItem();
                ClearTextBoxes();
                lblMess.Text = Messenger.InsertCompleted;
            }
            catch (Exception ex)
            {
                lblMess.Text = Messenger.InsertFailed;
                throw;
            }

        }
        #endregion

        #region private methods
        private void SetUpForm()
        {

        }
        public void ClearTextBoxes()
        {
            txtName.Text = "";
            txtDes.Text = "";
        }
        private CarCategory GetObjectInForm()
        {
            CarCategory item = new CarCategory();
            item.Name = txtName.Text;
            item.Description = txtDes.Text;
            return item;
        }
        private void AddNewItem()
        {
            CarParam param = new CarParam(FunctionType.CarCategoryFunction.AddNewCarCategory);
            CarCategory carCategory = GetObjectInForm();
            param.CarCategory = carCategory;
            MainController.Provider.Execute(param);
        }
        #endregion
    }
}