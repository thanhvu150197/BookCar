using System.Text;
using System.Threading.Tasks;
using BookCar.SharedComponent.Param;
using BookCar.SharedComponent.Entities;
using BookCarDAO;


namespace BookCarBLL
{
    public class NhanDatXeBLL
    {
        CarCategoryDao _daoCar = new CarCategoryDao();
        ServiceOrderDao _daoServiceOrder = new ServiceOrderDao();
        TimeCategoryDao _daoTimeCategory = new TimeCategoryDao();
        public void DanhSachXeDat(CarParam param, string CarID)
        {
            Car XeDat = new Car();
            param.ListCar = _daoCar.SearchBookedCar(CarID);
            foreach (Car item in param.ListCar)
            {
                XeDat = item;
            }
            param.Car = XeDat;
        }
        public void InsertOrder(ServiceOrder SO)
        {
            _daoServiceOrder.InsertServiceOrder(SO);
        }
        public void TimeCategory(CarParam param)
        {
            param.ListTimeCategory= _daoTimeCategory.SearchTimeCategory();
        }
    }
}
