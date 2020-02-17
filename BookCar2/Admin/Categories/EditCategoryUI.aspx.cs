using BookCar.SharedComponent;
using BookCar.SharedComponent.Entities;
using BookCar.SharedComponent.Param;
using BookCarBLL.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace BookCar2.Admin.Categories
{
    public partial class EditCategoryUI : System.Web.UI.Page
    {
        #region Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SetUpForm();
                GetObjectInForm();
            }
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            CategoryBiz _bizCategory = new CategoryBiz();
            CarCategory enCategory = new CarCategory();
            string CategoryID = Request.QueryString["id"].ToString();
            try
            {
                enCategory.CarCategoryID = int.Parse(CategoryID);
                enCategory.Name = txtName.Text;
                enCategory.Description = txtDes.Text;
                enCategory.UpdatedBy = "Thanh";
                enCategory.UpdatedDTG = DateTime.Now;
                enCategory.Deleted = 0;
                _bizCategory.UpdateCategory(enCategory);

                lblMess.Text = Messenger.UpdateCompleted;
                GetObjectInForm();
            }
            catch (Exception ex)
            {
                lblMess.Text = Messenger.UpdateFailed;
                throw;
            }
        }
        #endregion
        #region private method
        private void SetUpForm()
        {

        }
        protected void GetObjectInForm()
        {

            CategoryBiz categoryBiz = new CategoryBiz();
            CarParam carParam = new CarParam();

            CarCategory Category = new CarCategory();
            string CategoryID = Request.QueryString["id"].ToString();
            if (!string.IsNullOrEmpty(CategoryID))
                Category.CarCategoryID = int.Parse(CategoryID);

            carParam.CarCategory = Category;

            categoryBiz.SearchListCategory(carParam);

            Category = carParam.CarCategory;
            txtName.Text = Category.Name;
            txtDes.Text = Category.Description;
            lblCreatedBy.Text = Category.CreatedBy;
            lblCreatedDTG.Text = Category.CreatedDTG.ToString();
            lblUpdatedBy.Text = Category.UpdatedBy;
            lblUpdatedDTG.Text = Category.UpdatedDTG.ToString();
        }
        #endregion


        
    }
}