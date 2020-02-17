using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookCar.SharedComponent.Param;
using BookCarBLL;
using BookCar.SharedComponent.Entities;

namespace BookCar2.Views
{
    public partial class NhanDatXe : System.Web.UI.Page
    {
        DateTime StartTime;
        DateTime EndTime;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
                FillGridView();
                FillDropDown();
                checkTime();
                lblPS.Text= StartTime.ToString("dd/MM/yyyy HH:mm:ss tt");
                lblPE.Text= EndTime.ToString("dd/MM/yyyy HH:mm:ss tt");
               


            }
        }
        protected void checkTime()
        {

            StartTime = Convert.ToDateTime(Request.QueryString["TimeS"].ToString());
            EndTime = Convert.ToDateTime(Request.QueryString["TimeE"].ToString());
            TimeSpan OrderDuration = EndTime - StartTime;
            double time;
            if (ddlTime.SelectedValue == "1")
            {
                time = Convert.ToDouble(OrderDuration.TotalHours.ToString());
                lblOD.Text = Math.Round(time).ToString();
            }
            if (ddlTime.SelectedValue == "2")
            {
                time = Convert.ToDouble(OrderDuration.TotalDays.ToString());
                lblOD.Text = Math.Round(time).ToString();
            }
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            NhanDatXeBLL DBLL = new NhanDatXeBLL();
            CarParam carParam = new CarParam();

            StartTime = Convert.ToDateTime(Request.QueryString["TimeS"].ToString());
            EndTime = Convert.ToDateTime(Request.QueryString["TimeE"].ToString());
            try
            {
                foreach (GridViewRow row in GridView1.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        ServiceOrder SO = new ServiceOrder();
                        SO.CarID = int.Parse(row.Cells[0].Text);
                        SO.TimeCategory = int.Parse(ddlTime.SelectedValue);
                        SO.OrderDuration = int.Parse(lblOD.Text);
                        SO.PlanStartDTG = StartTime;
                        SO.PlanEndDTG = EndTime;
                       
                        SO.CustomerName = txtName.Text;
                        SO.Description = row.Cells[3].Text;
                        SO.Status = 0;
                        SO.Deleted = 0;
                        SO.Version = 0;
                        SO.CreatedBy = txtName.Text;
                        SO.CreatedDTG = DateTime.Now;
                        SO.UpdatedBy = "Thanh";
                        SO.UpdatedDTG = DateTime.Now;
                        DBLL.InsertOrder(SO);
                    }
                }
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Messagebox", "alert('Đơn đặt xe đang được xử lý');", true);
                Response.Redirect("Default.aspx");
            }
            catch(Exception ex)
            {
                
            }

        }
        protected void FillGridView()
        {
            NhanDatXeBLL DBLL = new NhanDatXeBLL();
            CarParam carParam = new CarParam();
            List<Car> ListCar = new List<Car>();

            string ListCarBook = Request.QueryString["CarID"].ToString();
            string[] arrLis = ListCarBook.Split(',');
            foreach (string item in arrLis)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    DBLL.DanhSachXeDat(carParam, item);
                    ListCar.Add(carParam.Car);
                }
            }

            GridView1.DataSource = ListCar;
            GridView1.DataBind();
        }
        protected void FillDropDown()
        {
            NhanDatXeBLL NDXLL = new NhanDatXeBLL();
            CarParam carParam = new CarParam();
            NDXLL.TimeCategory(carParam);
            List<TimeCategory> ListTimeCategory = carParam.ListTimeCategory;
            ddlTime.DataSource = ListTimeCategory;
            ddlTime.DataBind();
        }

        protected void ddlTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkTime();
        }
    }
}