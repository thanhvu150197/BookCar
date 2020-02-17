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
    }
}
