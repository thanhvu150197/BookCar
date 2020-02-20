using BookCar.SharedComponent.Param;
using BookCar.SharedComponent.Entities;
using SoftMart.Kernel.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCarDAO
{
    public class ServiceOrderDao : BaseDao
    {
        #region Modification methods

        public void InsertServiceOrder(ServiceOrder item)
        {
            using (DataContext dataContext = new DataContext())
            {
                dataContext.InsertItem<ServiceOrder>(item);
            }
        }

        public void UpdateServiceOrder(ServiceOrder item)
        {
            int affectedRows;
            using (DataContext dataContext = new DataContext())
            {
                affectedRows = dataContext.UpdateItem<ServiceOrder>(item);
            }
            if (affectedRows == 0)
            {
                throw new SMXException("Failed");
            }
        }

        #endregion

        #region Getting methods

        public ServiceOrder GetServiceOrderByID(int? id)
        {
            using (DataContext dataContext = new DataContext())
            {
                return dataContext.SelectItemByID<ServiceOrder>(id);
            }
        }

        #endregion

        #region Searching methods
        public void SearchService(CarParam param)
        {
            ServiceOrder enServiceOrder = new ServiceOrder();
            var cmdText = @"select * from ServiceOrder where Deleted=0";

            if (!string.IsNullOrEmpty(param.ServiceOrder.OrderID.ToString()))
                cmdText += " and OrderID=" + param.ServiceOrder.OrderID + "";
            if (!string.IsNullOrEmpty(param.ServiceOrder.CarID.ToString()))
                cmdText += " and CarID=" + param.ServiceOrder.CarID + "";

            if (!string.IsNullOrEmpty(param.ServiceOrder.Status.ToString()))
                cmdText += " and Status=" + param.ServiceOrder.Status + "";

            List<ServiceOrder> lstItem = new List<ServiceOrder>();
            using (var dataContext = new DataContext())
            {
                lstItem = dataContext.ExecuteSelect<ServiceOrder>(cmdText);
            }
            foreach (ServiceOrder item in lstItem)
            {
                enServiceOrder = item;
            }
            int count = lstItem.Count;
            lstItem = lstItem.Skip(param.CurrentPageIndex* param.Pagesize).Take(param.Pagesize).ToList();

            param.TotalItem = count;
            param.ListServiceOrder = lstItem;
            param.ServiceOrder = enServiceOrder;
        }

        public List<ServiceOrder> DanhSachChoDuyet()
        {
            var cmdText = @"select * from ServiceOrder where Status=0 and Deleted=0 order by CustomerName,CreatedDTG,PlanEndDTG";
            DataContext dt = new DataContext();
            return dt.ExecuteSelect<ServiceOrder>(cmdText);
        }
        public void DanhSachDangDat(CarParam parm)
        {
            var cmdText = @"select * from ServiceOrder where Status=1 and Deleted=0 order by CustomerName,CreatedDTG,PlanEndDTG";

            List<ServiceOrder> lstItem = new List<ServiceOrder>();
            using (var dataContext = new DataContext())
            {
                lstItem = dataContext.ExecuteSelect<ServiceOrder>(cmdText);
            }
            int count = lstItem.Count;
            lstItem = lstItem.Skip(parm.CurrentPageIndex).Take(parm.Pagesize).ToList();

            parm.TotalItem = count;
            parm.ListServiceOrder = lstItem;

        }
        public List<ServiceOrder> ListComplete()
        {
            var cmdText = @"select * from ServiceOrder where Status=2 and Deleted=0 order by CustomerName,CreatedDTG,PlanEndDTG";
            DataContext dt = new DataContext();
            return dt.ExecuteSelect<ServiceOrder>(cmdText);
        }
        public List<ServiceOrder> DanhSachDangThueTheoID(int ID)
        {
            var cmdText = @"select * from ServiceOrder where Status=1 and Deleted=0" + " and OrderID='" + ID + "' order by CustomerName,CreatedDTG,PlanEndDTG";
            DataContext dt = new DataContext();
            return dt.ExecuteSelect<ServiceOrder>(cmdText);
        }
        public List<ServiceOrder> DanhSachDone(int ID)
        {
            var cmdText = @"select * from ServiceOrder where Status=2 and Deleted=0" + " and OrderID='" + ID + "' order by CustomerName,CreatedDTG,PlanEndDTG";
            DataContext dt = new DataContext();
            return dt.ExecuteSelect<ServiceOrder>(cmdText);
        }
        #endregion
    }

}
