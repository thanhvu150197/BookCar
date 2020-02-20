using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCar.SharedComponent.Param;
using BookCar.SharedComponent.Entities;

using SoftMart.Core.Dao;
using SoftMart.Kernel.Exceptions;

namespace BookCarDAO
{
    public class CarDao : BaseDao
    {
        #region Modification methods

        public void InsertCar(Car item)
        {
            using (DataContext dataContext = new DataContext())
            {
                dataContext.InsertItem<Car>(item);
            }
        }

        public void UpdateCar(Car item)
        {
            int affectedRows;
            using (DataContext dataContext = new DataContext())
            {
                affectedRows = dataContext.UpdateItem<Car>(item);
            }
            if (affectedRows == 0)
            {
                throw new SMXException("");
            }
        }

        #endregion

        #region Getting methods

        public Car GetCarByID(int? id)
        {
            using (DataContext dataContext = new DataContext())
            {
                return dataContext.SelectItemByID<Car>(id);
            }
        }

        #endregion

        #region Searching methods
        public void SearchCar(CarParam param)
        {
            Car enCar =param.Car;
            string cmd = @"select * from Car where Deleted<1 ";

            if (param.Car.CarID!=null)
                cmd += "and CarID=" + param.Car.CarID + " ";

            if (!string.IsNullOrEmpty(param.Car.Color))
                cmd += "and Color='" + param.Car.Color + "'";

            if (!string.IsNullOrEmpty(param.Car.PlateNumber))
                cmd += "and PlateNumber='" + param.Car.PlateNumber.ToString() + "'";

            if (param.Car.Price!=null)
                cmd += "and Price='" + enCar.Price + "'";

            if (param.Car.CategoryID!=null)
                cmd += "and CategoryID='" + param.Car.CategoryID + "'";

            if(!string.IsNullOrEmpty(enCar.MaxPrice.ToString()))
                cmd += "and Price<'" + enCar.MaxPrice + "'";

            if (!string.IsNullOrEmpty(enCar.MinPrice.ToString()))
                cmd += "and Price>'" + enCar.MinPrice + "'";

            List<Car> lstItem = new List<Car>();
            using (var dataContext = new DataContext())
            {
                lstItem = dataContext.ExecuteSelect<Car>(cmd);
            }
            foreach(Car item in lstItem)
            {
                enCar = item;
            }

            int count = lstItem.Count;
            lstItem = lstItem.Skip(param.CurrentPageIndex* param.Pagesize).Take(param.Pagesize).ToList();
            param.TotalItem = count;
            param.ListCar = lstItem;
            param.Car = enCar;
        }

        //public void SearchCar(CarParam param)
        //{

        //}

        #endregion
        #region Delate methods
        public void DeleteCarByID(Car item)
        {
            if (!string.IsNullOrEmpty(item.CarID.ToString()))
            {
                DataContext dataContext = new DataContext();
                int affectedRows = dataContext.DeleteItemByColumn<Car>(Car.C_CarID, item.CarID);
                if (affectedRows == 0)
                {
                   // throw new SMXException(Messages.Common.ItemChanged);
                }
            }
        }
        #endregion
    }

}
