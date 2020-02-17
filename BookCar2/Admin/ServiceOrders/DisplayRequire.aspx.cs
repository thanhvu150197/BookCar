﻿using BookCar.SharedComponent.Entities;
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
    public partial class DisplayRequire : System.Web.UI.Page
    {
        #region Page Evens
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadData();
            }
        }
        #endregion
        #region Prive Methods
        protected void LoadData()
        {
            ServiceOrderBiz _bizServiceOrder = new ServiceOrderBiz();
            CarParam carParam = new CarParam();
            ServiceOrder serviceOrder = new ServiceOrder();
            string id = Request.QueryString["id"].ToString();


            if (!string.IsNullOrEmpty(id))
            {
                serviceOrder.OrderID = int.Parse(id);
                serviceOrder.Status = 0;
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
        #endregion

        protected void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("ServiceOrder.aspx?Stt=" + "0");
        }
    }
}