using BookCar.SharedComponent.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCarDAO;
using BookCar.SharedComponent.Entities;
using SoftMart.Kernel.Exceptions;

namespace BookCarBLL.Admin
{
    public class CarsBiz
    {
        CarDao _daoCar = new CarDao();
        public void SearchItems(CarParam param)
        {
            _daoCar.SearchCar(param);
        }
        //
        public void AddNewCar(CarParam param)
        {
            CarDao daoCar = new CarDao();
            Car enCar = param.Car;
            enCar.Deleted = 0;
            enCar.Version = 0;
            enCar.CreatedBy = "Thanh";
            enCar.CreatedDTG = DateTime.Now;

            daoCar.InsertCar(enCar);
        }

        public void UpdateCar(CarParam param)
        {
            CarDao daoCar = new CarDao();

            Car enCar = param.Car;
            enCar.UpdatedBy = "Thanh";
            enCar.UpdatedDTG = DateTime.Now;

            daoCar.UpdateCar(enCar);
        }

        public void DeleteCar(CarParam param)
        {
            CarDao daoCar = new CarDao();

            Car enCar = param.Car;
            enCar.Deleted = 1;
            enCar.UpdatedBy = "Thanh";
            enCar.UpdatedDTG = DateTime.Now;
            daoCar.UpdateCar(enCar);
        }

        #region Getting methods

        public void LoadDataDisplayCar(CarParam param)
        {
            CarDao daoCar = new CarDao();

            Car enCar = daoCar.GetCarByID(param.Car.CarID);          
            param.Car = enCar;
        }

        public void LoadDataEditCar(CarParam param)
        {
            CarDao daoCar = new CarDao();

            Car enCar = daoCar.GetCarByID(param.Car.CarID);
            if (enCar == null)
                throw new SMXException("Link Not Existed");
            param.Car = enCar;
        }

        public void GetCarByID(CarParam param)
        {
            CarDao daoCar = new CarDao();
            param.Car = daoCar.GetCarByID(param.Car.CarID);
        }

        #endregion

        #region Searching methods

        public void SearchCar(CarParam param)
        {
            CarDao daoCar = new CarDao();
            daoCar.SearchCar(param);
        }

        #endregion

        public void ValidateCar(Car item)
        {
            List<string> lstErr = new List<string>();

            if (lstErr.Count == 0)
            {
                throw new SMXException(lstErr);
            }
        }
    }
}
