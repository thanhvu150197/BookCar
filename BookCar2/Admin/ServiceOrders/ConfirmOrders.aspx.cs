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
            CarParam param = new CarParam(FunctionType.ServiceOrderFunction.UpdateServiceOrder);
            ServiceOrder enServiceOrder = GetObjectInForm();
            param.ServiceOrder = enServiceOrder;
            MainController.Provider.Execute(param);
        }
        protected void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("ServiceOrder.aspx?Stt=1");
        }

        #endregion
        #region Private Methods
        private void LoadData()
        {
            CarParam carParam = new CarParam(FunctionType.ServiceOrderFunction.SearchServiceOrder);
            ServiceOrder serviceOrder = new ServiceOrder();
            string id = Request.QueryString["id"];

            if (!string.IsNullOrEmpty(id))
            {
                serviceOrder.OrderID = int.Parse(id);
                carParam.ServiceOrder = serviceOrder;
                carParam.Pagesize = 1;
                MainController.Provider.Execute(carParam);
                serviceOrder = carParam.ServiceOrder;
            }            
            BindObjectToForm(serviceOrder);

        }       
        private void BindObjectToForm(ServiceOrder item)
        {
            txtOrderID.Text = item.OrderID.ToString();
            txtCusName.Text = item.CustomerName;
            txtPSDTG.Text = item.PlanStartDTG.ToString();
            txtPEDTG.Text = item.PlanEndDTG.ToString();
            txtCarID.Text = item.CarID.ToString();
            lblCrBy.Text = item.CreatedBy;
            lblCrByDTG.Text = item.CreatedDTG.ToString();
            txtOD.Text = item.OrderDuration.ToString();
            if (item.TimeCategory == 1)
            {
                txtCT.Text = "Hours";
            }
            else txtCT.Text = "Days";
        }
        private ServiceOrder GetObjectInForm()
        {
            string id = Request.QueryString["id"];
            ServiceOrder enServiceOrder = new ServiceOrder();
            enServiceOrder.OrderID = int.Parse(id);
            enServiceOrder.Status = int.Parse(ServiceStatus.Completed);
            DateTime StartTime = Convert.ToDateTime(Convert.ToDateTime(dpTimeStart.SelectedDate).ToShortDateString() + " " + tpStar.SelectedTime.ToString());
            DateTime EndTime = Convert.ToDateTime(Convert.ToDateTime(dpTimeEnd.SelectedDate).ToShortDateString() + " " + tpEnd.SelectedTime.ToString());

            enServiceOrder.ActualStartDTG = StartTime;
            enServiceOrder.ActualEndDTG = EndTime;
            enServiceOrder.Description = txtDes.Text;
            return enServiceOrder;
        }
        #endregion
    }
}