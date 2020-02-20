using BookCar.SharedComponent.Entities;
using BookCar.SharedComponent.Param;
using BookCar.SharedComponent.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookCarBLL.Admin;
using BookCarBLL;

namespace BookCar2.Admin.Categories
{
    public partial class Default : System.Web.UI.Page
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
        protected void grdData_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                CarCategory item = (CarCategory)e.Item.DataItem;

                Literal ltrCarCategoryID = (Literal)e.Item.FindControl("ltrCarCategoryID");
                LinkButton lbName = (LinkButton)e.Item.FindControl("lbName");
                Literal ltrCreatedBy = (Literal)e.Item.FindControl("ltrCreatedBy");
                Literal ltrPlateNumber = (Literal)e.Item.FindControl("ltrPlateNumber");

                ltrCarCategoryID.Text = item.CarCategoryID.ToString();
                lbName.Text = item.Name.ToString();
                ltrCreatedBy.Text = item.CreatedBy.ToString();
            }
        }
        protected void grvData_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "EditItems":
                    {
                        Literal ltrCarCategoryID = (Literal)e.Item.FindControl("ltrCarCategoryID");
                        int id = int.Parse(ltrCarCategoryID.Text);
                        Response.Redirect("EditCategoryUI.aspx?id=" + id);
                        break;
                    }
                case "ViewItems":
                    {
                        Literal ltrCarCategoryID = (Literal)e.Item.FindControl("ltrCarCategoryID");
                        int id = int.Parse(ltrCarCategoryID.Text);
                        Response.Redirect("Display.aspx?id=" + id);
                        break;
                    }
                case "DeleteItems":
                    {
                        Literal ltrCarCategoryID = (Literal)e.Item.FindControl("ltrCarCategoryID");
                        int id = int.Parse(ltrCarCategoryID.Text);
                        Delete(id);
                        LoadData();
                        break;
                    }
                default:
                    break;
            }
        }

        protected void grvData_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            grvData.CurrentPageIndex = e.NewPageIndex;
            LoadData();
        }
        protected void btnAddCar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Display.aspx");
        }
        #endregion
        #region Private Methods
        private void SetUpForm()
        {      
            grvData.PageSize = 5;
        }
        private void LoadData()
        {
            CarParam carParam = new CarParam(FunctionType.CarCategoryFunction.SearchCarCategory);
            CarCategory enCarCategory = new CarCategory();
            List<CarCategory> ListCategory = new List<CarCategory>();
            carParam.CurrentPageIndex = grvData.CurrentPageIndex;
            carParam.Pagesize = 5;
            carParam.CarCategory = enCarCategory;
            MainController.Provider.Execute(carParam);
            ListCategory = carParam.ListCarCategories;
            grvData.VirtualItemCount = carParam.TotalItem.Value;
            grvData.DataSource = ListCategory;
            grvData.DataBind();
        }
        private void Delete(int? id)
        {
            CarParam carParam = new CarParam(FunctionType.CarCategoryFunction.DeleteCarCategory);
            CarCategory enCarCategory = new CarCategory();
            enCarCategory.CarCategoryID = id;
            carParam.CarCategory = enCarCategory;
            MainController.Provider.Execute(carParam);
        }
        #endregion

    }
}