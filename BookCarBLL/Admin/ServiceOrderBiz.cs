using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCar.SharedComponent.Entities;
using BookCar.SharedComponent.Param;
using BookCarDAO;
namespace BookCarBLL.Admin
{
    public class ServiceOrderBiz
    {
        ServiceOrderDao _serviceOrder = new ServiceOrderDao();
        public void SearchService(CarParam param)
        {
            _serviceOrder.SearchService(param);
        }
        public void UpdateService(ServiceOrder item)
        {
            _serviceOrder.UpdateServiceOrder(item);

        }
        public void AddNewServiceOrder(CarParam param)
        {
            ServiceOrderDao daoServiceOrder = new ServiceOrderDao();

            ServiceOrder enServiceOrder = param.ServiceOrder;
            enServiceOrder.Deleted = 0;
            enServiceOrder.Version = 0;
            enServiceOrder.CreatedBy = "Thanh";
            enServiceOrder.CreatedDTG = DateTime.Now;

            daoServiceOrder.InsertServiceOrder(enServiceOrder);
        }

        public void UpdateServiceOrder(CarParam param)
        {
            ServiceOrderDao daoServiceOrder = new ServiceOrderDao();

            ServiceOrder enServiceOrder = param.ServiceOrder;
            enServiceOrder.UpdatedBy = "Thanh";
            enServiceOrder.UpdatedDTG = DateTime.Now;

            daoServiceOrder.UpdateServiceOrder(enServiceOrder);
        }

        public void DeleteServiceOrder(CarParam param)
        {
            ServiceOrderDao daoServiceOrder = new ServiceOrderDao();

            ServiceOrder enServiceOrder = param.ServiceOrder;
            enServiceOrder.Deleted = 1;
            enServiceOrder.UpdatedBy = "Thanh";
            enServiceOrder.UpdatedDTG = DateTime.Now;

            daoServiceOrder.UpdateServiceOrder(enServiceOrder);
        }

        #region Getting methods

        public void LoadDataDisplayServiceOrder(CarParam param)
        {
            ServiceOrderDao daoServiceOrder = new ServiceOrderDao();

            ServiceOrder enServiceOrder = daoServiceOrder.GetServiceOrderByID(param.ServiceOrder.OrderID);
            if (enServiceOrder == null)
                throw new Exception("LinkNotExisted");
            param.ServiceOrder = enServiceOrder;
        }

        public void LoadDataEditServiceOrder(CarParam param)
        {
            ServiceOrderDao daoServiceOrder = new ServiceOrderDao();

            ServiceOrder enServiceOrder = daoServiceOrder.GetServiceOrderByID(param.ServiceOrder.OrderID);
            if (enServiceOrder == null)
                throw new Exception("LinkNotExisted");
            param.ServiceOrder = enServiceOrder;
        }

        public void GetServiceOrderByID(CarParam param)
        {
            ServiceOrderDao daoServiceOrder = new ServiceOrderDao();
            param.ServiceOrder = daoServiceOrder.GetServiceOrderByID(param.ServiceOrder.OrderID);
        }

        #endregion

        #region Searching methods

        public void SearchServiceOrder(CarParam param)
        {
            ServiceOrderDao daoServiceOrder = new ServiceOrderDao();
            daoServiceOrder.SearchService(param);
        }

        #endregion

        public void ValidateServiceOrder(ServiceOrder item)
        {
            List<string> lstErr = new List<string>();

            if (lstErr.Count == 0)
            {
                throw new Exception("Error");
            }
        }


    }

}
