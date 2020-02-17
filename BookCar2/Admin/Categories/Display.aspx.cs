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

        #region Private Methods
        private void LoadData()
        {

            CategoryBiz categoryBiz = new CategoryBiz();
            CarParam carParam = new CarParam();

            CarCategory Category = new CarCategory();
            string CategoryID = Request.QueryString["id"].ToString();
            if(!string.IsNullOrEmpty(CategoryID))
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