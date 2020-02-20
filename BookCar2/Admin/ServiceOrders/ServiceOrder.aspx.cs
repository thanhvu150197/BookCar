﻿using BookCar.SharedComponent.Constant;
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

namespace BookCar2.Admin.ServiceOrders
{
    public partial class ListRequire : System.Web.UI.Page
    {

        #region Page Evens
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SetUpForm();
                LoadData();
            }
        }
        protected void grvListRequire_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            grvListRequire.CurrentPageIndex = e.NewPageIndex;
            LoadData();
        }

        protected void grvListRequire_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "ViewCar":
                    {
                        LinkButton lbCarID = (LinkButton)e.Item.FindControl("lbCarID");
                        int id = int.Parse(lbCarID.Text);
                        Response.Redirect("~/Admin/Cars/Display.aspx?id=" + id + "&Fr=SO&Stt="+ddlStatus.SelectedValue);
                        break;
                    }
                case "ViewOrder":
                    {
                        Literal ltrOrderID = (Literal)e.Item.FindControl("ltrOrderID");
                        int id = int.Parse(ltrOrderID.Text);
                        switch (ddlStatus.SelectedValue)
                        {
                            case ServiceStatus.Require:
                                {
                                    Response.Redirect("DisplayRequire.aspx?id=" + id);
                                }
                                break;
                            case ServiceStatus.Booking:
                                {
                                    Response.Redirect("DisplayBooking.aspx?id=" + id);
                                }
                                break;
                            case ServiceStatus.Completed:
                                {
                                    Response.Redirect("DisplayCompleted.aspx?id=" + id);
                                }
                                break;
                        }
                        break;
                    }
                case "Confirm":
                    {
                        Literal ltrOrderID = (Literal)e.Item.FindControl("ltrOrderID");
                        int id = int.Parse(ltrOrderID.Text);
                        switch (ddlStatus.SelectedValue)
                        {
                            case ServiceStatus.Require:
                                {
                                    ConfirmToBooking(id);
                                    LoadData();
                                }
                                break;
                            case ServiceStatus.Booking:
                                {
                                    Response.Redirect("ConfirmOrders.aspx?id=" + id);
                                }
                                break;
                            case ServiceStatus.Completed:
                                {
                                    Response.Redirect("EditOrder.aspx?id=" + id);
                                }
                                break;
                        }
                        break;
                    }
                case "Cancle":
                    {
                        Literal ltrOrderID = (Literal)e.Item.FindControl("ltrOrderID");
                        int id = int.Parse(ltrOrderID.Text);
                        switch (ddlStatus.SelectedValue)
                        {
                            case ServiceStatus.Require:
                                {
                                    CancleRequire(id);
                                    LoadData();
                                }
                                break;
                            case ServiceStatus.Booking:
                                {
                                    CancleBooking(id);
                                    LoadData();
                                }
                                break;
                            case ServiceStatus.Completed:
                                {
                                    Response.Redirect("EditOrder.aspx?id=" + id);
                                }
                                break;
                        }
                        break;
                    }

                default:
                    break;
            }
        }
        protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            grvListRequire.CurrentPageIndex = 0;
            LoadData();
        }
        protected void grvListRequire_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                ServiceOrder item = (ServiceOrder)e.Item.DataItem;

                Literal ltrOrderID = (Literal)e.Item.FindControl("ltrOrderID");
                LinkButton lbCarID = (LinkButton)e.Item.FindControl("lbCarID");
                Literal ltrPlanStartDTG = (Literal)e.Item.FindControl("ltrPlanStartDTG");
                Literal ltrPlanEndDTG = (Literal)e.Item.FindControl("ltrPlanEndDTG");
                Literal ltrTime = (Literal)e.Item.FindControl("ltrTime");

                ltrOrderID.Text = item.OrderID.ToString();
                lbCarID.Text = item.CarID.ToString();
                ltrPlanStartDTG.Text = item.PlanStartDTG.ToString();
                ltrPlanEndDTG.Text = item.PlanEndDTG.ToString();

                string TimeCategory = "";
                if (item.TimeCategory == 1)
                {
                    TimeCategory = "Giờ";
                }
                if (item.TimeCategory == 2)
                {
                    TimeCategory = "Ngày";
                }
                ltrTime.Text = item.OrderDuration.ToString() + " " + TimeCategory;

            }
        }
        #endregion

        #region Page Evens
        private void SetUpForm()
        {
            //Fill DataGrid
            CarParam carParam = new CarParam(FunctionType.ServiceOrderFunction.SearchServiceOrder);
            ServiceOrder enServiceOrder = new ServiceOrder();
            List<ServiceOrder> ListService = new List<ServiceOrder>();

            carParam.Pagesize = 5;
            carParam.CurrentPageIndex = grvListRequire.CurrentPageIndex;
            carParam.ServiceOrder = enServiceOrder;
            MainController.Provider.Execute(carParam);
            ListService = carParam.ListServiceOrder;

            grvListRequire.VirtualItemCount = carParam.TotalItem.Value;
            grvListRequire.DataSource = ListService;
            grvListRequire.DataBind();

            //Fill dropdown
            ddlStatus.Items.Add(new ListItem("Requires", ServiceStatus.Require));
            ddlStatus.Items.Add(new ListItem("Booking", ServiceStatus.Booking));
            ddlStatus.Items.Add(new ListItem("Completed", ServiceStatus.Completed));

            string Status = Request.QueryString["Stt"];
            if (!string.IsNullOrEmpty(Status))
                ddlStatus.SelectedValue = Status;
            grvListRequire.PageSize = 5;
        }
        protected void DisplayCurrentPage(int PageIndex, CarParam carParam)
        {
            
            ServiceOrder enServiceOrder = new ServiceOrder();
            List<ServiceOrder> ListService = new List<ServiceOrder>();
            carParam.Pagesize = 5;
            carParam.CurrentPageIndex = grvListRequire.CurrentPageIndex;

            carParam.ServiceOrder = enServiceOrder;
            ListService = carParam.ListServiceOrder;

            grvListRequire.VirtualItemCount = carParam.TotalItem.Value;
            grvListRequire.DataSource = ListService;
            grvListRequire.DataBind();
        }
        private void ConfirmToBooking(int id)
        {
            CarParam param = new CarParam(FunctionType.ServiceOrderFunction.UpdateServiceOrder);
            ServiceOrder enServiceOrder = new ServiceOrder();
            enServiceOrder.OrderID = id;
            enServiceOrder.Status = 1;
            enServiceOrder.UpdatedDTG = DateTime.Now;
            param.ServiceOrder = enServiceOrder;
            MainController.Provider.Execute(param);
        }
        private void CancleRequire(int id)
        {
            CarParam param = new CarParam(FunctionType.ServiceOrderFunction.DeleteServiceOrder);
            ServiceOrder enServiceOrder = new ServiceOrder();
            enServiceOrder.OrderID = id;
            enServiceOrder.UpdatedDTG = DateTime.Now;
            param.ServiceOrder = enServiceOrder;
            MainController.Provider.Execute(param);
        }
        private void CancleBooking(int id)
        {
            CarParam param = new CarParam(FunctionType.ServiceOrderFunction.UpdateServiceOrder);
            ServiceOrder enServiceOrder = new ServiceOrder();
            enServiceOrder.OrderID = id;
            enServiceOrder.Status = 0;
            param.ServiceOrder = enServiceOrder;
            MainController.Provider.Execute(param);
        }
        protected void LoadData()
        {
            CarParam carParam = new CarParam(FunctionType.ServiceOrderFunction.SearchServiceOrder);
            List<ServiceOrder> ListService = new List<ServiceOrder>();
            ServiceOrder enServiceOrder = new ServiceOrder();
            enServiceOrder.Status = int.Parse(ddlStatus.SelectedValue);    
            carParam.Pagesize = 5;
            carParam.CurrentPageIndex = grvListRequire.CurrentPageIndex;
            carParam.ServiceOrder = enServiceOrder;
            MainController.Provider.Execute(carParam);
            ListService = carParam.ListServiceOrder;

            grvListRequire.VirtualItemCount = carParam.TotalItem.Value;
            grvListRequire.DataSource = ListService;
            grvListRequire.DataBind();
        }      
        #endregion
    }
}