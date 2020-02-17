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
                        switch (ddlStatus.SelectedValue)
                        {
                            case "0":
                                {
                                    Response.Redirect("~/Admin/Cars/Display.aspx?id=" + id+"&Fr=SO&Stt=0");
                                }
                                break;
                            case "1":
                                {
                                    Response.Redirect("~/Admin/Cars/Display.aspx?id=" + id + "&Fr=SO&Stt=1");
                                }
                                break;
                            case "2":
                                {
                                    Response.Redirect("~/Admin/Cars/Display.aspx?id=" + id + "&Fr=SO&Stt=2");
                                }
                                break;
                        }
                        
                        break;
                    }
                case "ViewOrder":
                    {
                        Literal ltrOrderID = (Literal)e.Item.FindControl("ltrOrderID");
                        int id = int.Parse(ltrOrderID.Text);
                        switch(ddlStatus.SelectedValue)
                        {
                            case "0":
                                {
                                    Response.Redirect("DisplayRequire.aspx?id=" + id);
                                }
                                break;
                            case "1":
                                {
                                    Response.Redirect("DisplayBooking.aspx?id=" + id);
                                }
                                break;
                            case "2":
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
                            case "0":
                                {
                                    ConfirmOrders(id);
                                    LoadData();
                                }
                                break;
                            case "1":
                                {
                                    Response.Redirect("ConfirmOrders.aspx?id=" + id);
                                }
                                break;
                            case "2":
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
                            case "0":
                                {
                                    CancleRequire(id);
                                    LoadData();
                                }
                                break;
                            case "1":
                                {
                                    CancleBooking(id);
                                    LoadData();
                                }
                                break;
                            case "2":
                                {
                                    Response.Redirect("EditOrder.aspx?id=" + id);
                                }
                                break;
                        }
                        break;
                    }
                    break;
                default:
                    break;
            }
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
            CarParam carParam = new CarParam();
            ServiceOrderBiz ServiceBiz = new ServiceOrderBiz();
            ServiceOrder enServiceOrder = new ServiceOrder();
            List<ServiceOrder> ListService = new List<ServiceOrder>();
            carParam.Pagesize = 5;
            carParam.CurrentPageIndex = grvListRequire.CurrentPageIndex;

            carParam.ServiceOrder = enServiceOrder;
            ServiceBiz.SearchService(carParam);
            ListService = carParam.ListServiceOrder;

            grvListRequire.VirtualItemCount = carParam.TotalItem.Value;
            grvListRequire.DataSource = ListService;
            grvListRequire.DataBind();

            //Fill dropdown
            ddlStatus.Items.Add(new ListItem("Requires", "0"));
            ddlStatus.Items.Add(new ListItem("Booking", "1"));
            ddlStatus.Items.Add(new ListItem("Completed", "2"));

            string Status = Request.QueryString["Stt"];
            if (!string.IsNullOrEmpty(Status))
                ddlStatus.SelectedValue = Status;
            grvListRequire.PageSize = 5;
        }
        protected void DisplayCurrentPage(int PageIndex, CarParam carParam)
        {
            ServiceOrderBiz ServiceBiz = new ServiceOrderBiz();
            ServiceOrder enServiceOrder = new ServiceOrder();
            List<ServiceOrder> ListService = new List<ServiceOrder>();
            carParam.Pagesize = 5;
            carParam.CurrentPageIndex = grvListRequire.CurrentPageIndex;

            carParam.ServiceOrder = enServiceOrder;
            ServiceBiz.SearchService(carParam);
            ListService = carParam.ListServiceOrder;

            grvListRequire.VirtualItemCount = carParam.TotalItem.Value;
            grvListRequire.DataSource = ListService;
            grvListRequire.DataBind();
        }
        protected void ConfirmOrders(int id)
        {
            ServiceOrderBiz serviceOrderBiz = new ServiceOrderBiz();
            ServiceOrder enServiceOrder = new ServiceOrder();
            enServiceOrder.OrderID = id;      
            enServiceOrder.Status = 1;
            enServiceOrder.UpdatedDTG = DateTime.Now;
            serviceOrderBiz.UpdateService(enServiceOrder);
        }
        private void CancleRequire(int id)
        {
            ServiceOrderBiz serviceOrderBiz = new ServiceOrderBiz();
            ServiceOrder enServiceOrder = new ServiceOrder();
            enServiceOrder.OrderID = id;
            enServiceOrder.Deleted = 1;
            enServiceOrder.UpdatedDTG = DateTime.Now;
            serviceOrderBiz.UpdateService(enServiceOrder);
        }
        private void CancleBooking(int id)
        {
            ServiceOrderBiz serviceOrderBiz = new ServiceOrderBiz();
            ServiceOrder enServiceOrder = new ServiceOrder();
            enServiceOrder.OrderID = id;
            enServiceOrder.Status = 0;
            enServiceOrder.UpdatedDTG = DateTime.Now;
            serviceOrderBiz.UpdateService(enServiceOrder);
        }
            protected void LoadData()
        {
            
            ServiceOrderBiz ServiceBiz = new ServiceOrderBiz();
            List<ServiceOrder> ListService = new List<ServiceOrder>();

            ServiceOrder enServiceOrder = new ServiceOrder();
            enServiceOrder.Status =int.Parse(ddlStatus.SelectedValue);

            CarParam carParam = new CarParam();
            carParam.Pagesize = 5;
            carParam.CurrentPageIndex = grvListRequire.CurrentPageIndex;
            carParam.ServiceOrder = enServiceOrder;

            ServiceBiz.SearchService(carParam);
            ListService = carParam.ListServiceOrder;

            grvListRequire.VirtualItemCount = carParam.TotalItem.Value;
            grvListRequire.DataSource = ListService;
            grvListRequire.DataBind();
        }
        protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion


    }
}