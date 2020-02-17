using BookCar.SharedComponent.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCarDAO;
using BookCar.SharedComponent.Entities;

namespace BookCarBLL.Admin
{
    public class CarsBiz
    {
        CarDao _daoCar = new CarDao();
        public void SearchItems(CarParam param)
        {
            _daoCar.SearchCar(param);
        }
        public void UpdateCar(Car item)
        {
            _daoCar.UpdateCar(item);
        }
    }
}
