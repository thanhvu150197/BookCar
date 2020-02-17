using BookCar.SharedComponent.Entities;
using BookCar.SharedComponent.Param;
using BookCarBLL.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookCar2.Admin.ServiceOrders
{
    public partial class ConfirmOrders : System.Web.UI.Page
    {
        #region Page Evens
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadData();
            }
        }
        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            ServiceOrderBiz serviceOrderBiz = new ServiceOrderBiz();
            ServiceOrder enServiceOrder = new ServiceOrder();
            enServiceOrder.OrderID = int.Parse(id);
            enServiceOrder.Status = 2;
            DateTime StartTime = Convert.ToDateTime(Convert.ToDateTime(dpTimeStart.SelectedDate).ToShortDateString() + " " + tpStar.SelectedTime.ToString());
            DateTime EndTime = Convert.ToDateTime(Convert.ToDateTime(dpTimeEnd.SelectedDate).ToShortDateString() + " " + tpEnd.SelectedTime.ToString());

            enServiceOrder.ActualStartDTG = StartTime;
            enServiceOrder.ActualEndDTG = EndTime;
            enServiceOrder.Description = txtDes.Text;
            enServiceOrder.UpdatedBy = "Thanh";
            enServiceOrder.UpdatedDTG = DateTime.Now;

            serviceOrderBiz.UpdateService(enServiceOrder);
        }
        #endregion
        #region Private Methods
        private void LoadData()
        {
            ServiceOrderBiz _bizServiceOrder = new ServiceOrderBiz();
            CarParam carParam = new CarParam();
            ServiceOrder serviceOrder = new ServiceOrder();
            string id = Request.QueryString["id"];


            if (!string.IsNullOrEmpty(id))
            {
                serviceOrder.OrderID = int.Parse(id);
                carParam.ServiceOrder = serviceOrder;
                _bizServiceOrder.SearchService(carParam);
            }
            serviceOrder = carParam.ServiceOrder;

            txtOrderID.Text = serviceOrder.OrderID.ToString();
            txtCusName.Text = serviceOrder.CustomerName;
            txtPSDTG.Text = serviceOrder.PlanStartDTG.ToString();
            txtPEDTG.Text = serviceOrder.PlanEndDTG.ToString();
            txtCarID.Text = serviceOrder.CarID.ToString();
            lblCrBy.Text = serviceOrder.CreatedBy;
            lblCrByDTG.Text = serviceOrder.CreatedDTG.ToString();
            txtOD.Text = serviceOrder.OrderDuration.ToString();
            if (serviceOrder.TimeCategory == 1)
            {
                txtCT.Text = "Hours";
            }
            else txtCT.Text = "Days";

        }
        protected void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("ServiceOrder.aspx?Stt=1");
        }
        #endregion


    }
}