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
                LoadData();
            }
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int? id = UpdateItem();
                Response.Redirect("EditCategoryUI.aspx?id="+id+"&Mess="+Messenger.UpdateCompleted);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
        #region private method
        private void SetUpForm()
        {
            lblMess.Text = Request.QueryString["Mess"];
        }
        private void LoadData()
        {
            CarParam param = new CarParam(FunctionType.CarCategoryFunction.SearchCarCategory);
            CarCategory carCategory = new CarCategory();
            carCategory.CarCategoryID= int.Parse(Request.QueryString["id"].ToString());
            param.CarCategory = carCategory;
            MainController.Provider.Execute(param);
            BindObjectToForm(param.CarCategory);
        }
        private int? UpdateItem()
        {
            CarParam param = new CarParam(FunctionType.CarCategoryFunction.UpdateCarCategory);
            CarCategory item = GetObjectInForm();
            param.CarCategory = item;
            MainController.Provider.Execute(param);
            return item.CarCategoryID;
        }

        protected CarCategory GetObjectInForm()
        {            
            string CategoryID = Request.QueryString["id"];
            CarCategory item = new CarCategory();
            item.CarCategoryID = int.Parse(CategoryID);
            item.Name = txtName.Text;
            item.Description = txtDes.Text;
            item.UpdatedBy = "Thanh";
            item.UpdatedDTG = DateTime.Now;
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