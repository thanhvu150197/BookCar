using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCar.SharedComponent.Param;
using BookCar.SharedComponent.Entities;
using BookCarDAO;

namespace BookCarBLL.Admin
{
    public class AdminDefaultBLL
    {
        CarCategoryDao _daoCarCategory = new CarCategoryDao();
        CarDao _daoCar = new CarDao();
        ServiceOrderDao _serviceOrderDao = new ServiceOrderDao();
        #region InsertCategory
        public void ThemDanhMuc(CarCategory CarCategory)
        {
            try
            {
                _daoCarCategory.InsertCarCategory(CarCategory);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region SearchCategory
        public void DanhMucXe(CarParam param)
        {
           // param.ListCarCategories= _daoCarCategory.SearchCarCategory();
            
        }
        public void DanhMucXeTheoID(CarParam param,string Id)
        {
            //param.ListCarCategories = _daoCarCategory.SearchCarCategoryByID(Id);
        }
        #endregion
        #region UpdateCategory
        public void CapNhapDanhMucXe(CarCategory CarCategory)
        {
            _daoCarCategory.UpdateCarCategory(CarCategory);
        }
        #endregion
        #region InsertCar
        public void ThemXe(Car item)
        {
            _daoCar.InsertCar(item);

        }
        #endregion
        #region UpdateCar
        public void CapNhatXe(Car item)
        {
            _daoCar.UpdateCar(item);
        }
        #endregion
        #region SearchCar
        public void SearchListCar(CarParam param)
        {           
            _daoCar.SearchCar(param);
        }
        #endregion
        #region DeleteCar
        public void XoaXeTheoId(Car item)
        {
            _daoCar.DeleteCarByID(item);

        }
        public void XoaDanhMucXe(CarCategory item)
        {
            _daoCarCategory.DeleteCategory(item);

        }
        #endregion
        #region SearchService
        public void DanhSachChoDuyet(CarParam param)
        {
            param.ListServiceOrder = _serviceOrderDao.DanhSachChoDuyet();

        }
        public void DanhSachDangThue(CarParam param)
        {
           // param.ListServiceOrder = _serviceOrderDao.DanhSachDangDat();

        }
        public void ListComplete(CarParam param)
        {
            param.ListServiceOrder = _serviceOrderDao.ListComplete();
        }
        public void DanhSachDangThueTheoID(CarParam param,int ID)
        {
            param.ListServiceOrder = _serviceOrderDao.DanhSachDangThueTheoID(ID);

        }
        public void DanhSachDone(CarParam param, int ID)
        {
            param.ListServiceOrder = _serviceOrderDao.DanhSachDone(ID);

        }
        #endregion
        #region InsertService
        public void InsertService(ServiceOrder item)
        {
             _serviceOrderDao.InsertServiceOrder(item);

        }
        #endregion
        #region UpdateService
        public void UpdateService(ServiceOrder item)
        {
            _serviceOrderDao.UpdateServiceOrder(item);

        }
        #endregion

    }
}
