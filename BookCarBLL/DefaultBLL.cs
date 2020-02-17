using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCar.SharedComponent.Param;
using BookCarDAO;
using BookCarModels;
namespace BookCarBLL
{
    public class DefaultBLL
    {
        CarCategoryDao _daoCar = new CarCategoryDao();
        public void SearchAllCarCategory(CarParam param)
        {
            param.ListCarCategories= _daoCar.SearchAllCarCategory();
        }
        public void XeTheoDanhMuc(CarParam param,string CarCategoryID)
        {
            param.ListCar = _daoCar.SearchCar(CarCategoryID);
        }

    }
}
