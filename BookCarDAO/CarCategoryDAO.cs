using BookCar.SharedComponent.Entities;
using BookCar.SharedComponent.Param;
using SoftMart.Kernel.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCarDAO
{
    public class CarCategoryDao : BaseDao
    {
        #region Modification methods

        public void InsertCarCategory(CarCategory item)
        {
            using (DataContext dataContext = new DataContext())
            {
                dataContext.InsertItem<CarCategory>(item);
            }
        }

        public void UpdateCarCategory(CarCategory item)
        {
            int affectedRows;
            using (DataContext dataContext = new DataContext())
            {
                affectedRows = dataContext.UpdateItem<CarCategory>(item);
            }
            if (affectedRows == 0)
            {
                throw new SMXException("Failed");
            }
        }

        #endregion

        #region Getting methods

        public CarCategory GetCarCategoryByID(int? id)
        {
            using (DataContext dataContext = new DataContext())
            {
                return dataContext.SelectItemByID<CarCategory>(id);
            }
        }

        #endregion

        #region Searching methods
        public void SearchCarCategoryNoPaging(CarParam param)
        {
            CarCategory enCategory = new CarCategory();
            enCategory = param.CarCategory;

            int? id = enCategory.CarCategoryID;
            string cmd = @"select * from CarCategory where Deleted<1 ";


            if (id != null)
                cmd += "and CarCategoryID=" + id + " ";

            if (!string.IsNullOrEmpty(enCategory.Name))
                cmd += "and Name='" + enCategory.Name + "'";


            List<CarCategory> lstItem = new List<CarCategory>();
            using (var dataContext = new DataContext())
            {
                lstItem = dataContext.ExecuteSelect<CarCategory>(cmd);
            }
            foreach (CarCategory item in lstItem)
            {
                enCategory = item;
            }
            param.ListCarCategories = lstItem;
            param.CarCategory = enCategory;
        }
        public void SearchCarCategory(CarParam param)
        {
            CarCategory enCategory = new CarCategory();
            enCategory=param.CarCategory;

            int? id = enCategory.CarCategoryID;
            string cmd = @"select * from CarCategory where Deleted<1 ";


            if (id!=null)
                cmd += "and CarCategoryID=" + id + " ";

            if (!string.IsNullOrEmpty(enCategory.Name))
                cmd += "and Name='" + enCategory.Name + "'";


            List<CarCategory> lstItem = new List<CarCategory>();
            using (var dataContext = new DataContext())
            {
                lstItem = dataContext.ExecuteSelect<CarCategory>(cmd);
            }
            foreach (CarCategory item in lstItem)
            {
                enCategory = item;
            }

            int count = lstItem.Count;
            lstItem = lstItem.Skip(param.CurrentPageIndex * param.Pagesize).Take(param.Pagesize).ToList();
            param.TotalItem = count;
            param.ListCarCategories = lstItem;
            param.CarCategory = enCategory;
        }
        public List<CarCategory> SearchAllCarCategory()
        {
            var cmdText = @"select * from CarCategory where Deleted<1";
            DataContext dt = new DataContext();
            return dt.ExecuteSelect<CarCategory>(cmdText);
        }
        public List<Car> SearchCar(string Id)
        {
            string cmdText = @"select * from Car where CategoryID=";
            cmdText +="'"+Id+"'";
            DataContext dt = new DataContext();
            return dt.ExecuteSelect<Car>(cmdText);
            //return dt.ExecuteSelect<Car>(cmdText);
        }
        public List<Car> SearchBookedCar(string Id)
        {
            string cmd = @"select CarID,Color,PlateNumber,Price from Car where CarID=";
            cmd += "'" + Id + "'";
            DataContext dt = new DataContext();
            return dt.ExecuteSelect<Car>(cmd);

        }
        #endregion
        #region Delete Methods
        public void DeleteCategory(CarCategory item)
        {
            if (!string.IsNullOrEmpty(item.CarCategoryID.ToString()))
            {
                DataContext dataContext = new DataContext();
                int affectedRows = dataContext.DeleteItemByColumn<CarCategory>(CarCategory.C_CarCategoryID, item.CarCategoryID);
                if (affectedRows == 0)
                {
                    // throw new SMXException(Messages.Common.ItemChanged);
                }

            }
        }
    #endregion
}

}
