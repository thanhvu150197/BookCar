using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookCar.SharedComponent;
using BookCar.SharedComponent.Entities;
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
            CategoryBiz _bizCategory = new CategoryBiz();
            CarCategory enCategory = new CarCategory();
            try
            {
                enCategory.Name = txtName.Text;
                enCategory.Description = txtDes.Text;
                enCategory.CreatedBy = "Thanh";
                enCategory.CreatedDTG = DateTime.Now;
                _bizCategory.InsertCategory(enCategory);
                ClearText();
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
        public void ClearText()
        {
            txtName.Text = "";
            txtDes.Text = "";
        }
        #endregion
    }
}