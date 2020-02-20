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
    public partial class EditOrder : System.Web.UI.Page
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
        protected void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("ServiceOrder.aspx?Stt=" + ServiceStatus.Completed);
        }
        #endregion
        #region private methods
        private void SetUpForm()
        {

        }
        protected void LoadData()
        {
            CarParam carParam = new CarParam(FunctionType.ServiceOrderFunction.SearchServiceOrder);
            ServiceOrder serviceOrder = new ServiceOrder();
            carParam.ServiceOrder = GetObjectInForm();
            carParam.Pagesize = 1;
            MainController.Provider.Execute(carParam);
            serviceOrder = carParam.ServiceOrder;
            BindObjectToForm(serviceOrder);


        }
        private void BindObjectToForm(ServiceOrder item)
        {
            txtOrderID.Text = item.OrderID.ToString();
            txtCusName.Text = item.CustomerName;
            txtPSDTG.Text = item.PlanStartDTG.ToString();
            txtPEDTG.Text = item.PlanEndDTG.ToString();
            txtASDTG.Text = item.ActualStartDTG.ToString();
            txtAEDTG.Text = item.ActualEndDTG.ToString();
            txtDes.Text = item.Description;
            txtCarID.Text = item.CarID.ToString();
            lblCrBy.Text = item.CreatedBy;
            lblCrByDTG.Text = item.CreatedDTG.ToString();
            lblUpBy.Text = item.UpdatedBy;
            lblUpDTG.Text = item.UpdatedDTG.ToString();
            txtOD.Text = item.OrderDuration.ToString();

            if (item.TimeCategory == 1)
            {
                txtCT.Text = "Hours";
            }
            else txtCT.Text = "Days";
        }
        private ServiceOrder GetObjectInForm()
        {
            ServiceOrder enServiceOrder = new ServiceOrder();
            string id = Request.QueryString["id"].ToString();
            if (!string.IsNullOrEmpty(id))
            {
                enServiceOrder.OrderID = int.Parse(id);
            }
            return enServiceOrder;
        }
        #endregion


    }
}