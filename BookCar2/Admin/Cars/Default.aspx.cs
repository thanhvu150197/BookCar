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
                Car item = (Car)e.Item.DataItem;


                Literal ltrCarID = (Literal)e.Item.FindControl("ltrCarID");
                Literal ltrColor = (Literal)e.Item.FindControl("ltrColor");
                Literal ltrPrice = (Literal)e.Item.FindControl("ltrPrice");
                LinkButton ltrPlateNumber = (LinkButton)e.Item.FindControl("ltrPlateNumber");

                ltrCarID.Text = item.CarID.ToString();
                ltrColor.Text = item.Color.ToString();
                ltrPrice.Text = item.Price.ToString();
                ltrPlateNumber.Text = item.PlateNumber.ToString();
            }
        }

        protected void grdData_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            grdData.CurrentPageIndex = e.NewPageIndex;
            LoadData();
        }

        protected void grdData_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "ViewItems":
                    {
                        Literal ltrCarID = (Literal)e.Item.FindControl("ltrCarID");
                        int id = int.Parse(ltrCarID.Text);
                        Response.Redirect("Display.aspx?id=" + id);
                        break;
                    }
                case "EditItems":
                    {
                        Literal ltrCarID = (Literal)e.Item.FindControl("ltrCarID");
                        int id = int.Parse(ltrCarID.Text);
                        Response.Redirect("Edit.aspx?id=" + id);
                        break;
                    }
                case "DeleteItems":
                    {
                        Literal ltrCarID = (Literal)e.Item.FindControl("ltrCarID");
                        int id = int.Parse(ltrCarID.Text);
                        Delete(id);
                        LoadData();

                        break;
                    }
                   
                default:
                    break;
            }
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            grdData.CurrentPageIndex = 0;
            LoadData();
        }
        protected void btnAddCar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddNew.aspx");
        }
        #endregion

        #region Private Methods

        private void SetUpForm()
        {
            DefaultBLL defaultBLL = new DefaultBLL();
            CarParam carParam = new CarParam();
            List<CarCategory> ListCarCategory = new List<CarCategory>();
            defaultBLL.SearchAllCarCategory(carParam);
            ListCarCategory = carParam.ListCarCategories;
            ddlCategory.DataSource = ListCarCategory;
            ddlCategory.DataBind();
            grdData.PageSize = 5;
        }

        private void LoadData()
        {
            CarParam param = new CarParam();
            CarsBiz CarsBiz = new CarsBiz();

            param.CurrentPageIndex = grdData.CurrentPageIndex;
            param.Pagesize = grdData.PageSize;
            param.Car = GetSearchFilter();

            CarsBiz.SearchItems(param);
            List<Car> lstItem = param.ListCar;

            grdData.VirtualItemCount = param.TotalItem.Value;
            grdData.DataSource = lstItem;
            grdData.DataBind();
        }

        private Car GetSearchFilter()
        {
            Car enCar = new Car();
            enCar.CategoryID = int.Parse(ddlCategory.SelectedValue);
            enCar.Color = txtColor.Text;
            enCar.PlateNumber = txtPlateNumber.Text;
            enCar.MinPrice = decimal.Parse("0");
            enCar.MaxPrice = 99999999999999999;

            return enCar;
        }

        private void Delete(int? id)
        {
            AdminDefaultBLL AdBLL = new AdminDefaultBLL();
            CarParam carParam = new CarParam();

            Car enCar = new Car();
            enCar.CarID = id;
            AdBLL.XoaXeTheoId(enCar);

        }

        #endregion

      
    }
}
