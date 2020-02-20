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
    public class CarCategoryBiz
    {
        CarCategoryDao _daoCategory = new CarCategoryDao();
        public void InsertCategory(CarCategory CarCategory)
        {
            try
            {
                _daoCategory.InsertCarCategory(CarCategory);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateCategory(CarCategory CarCategory)
        {
            _daoCategory.UpdateCarCategory(CarCategory);
        }
        public void AddNewCarCategory(CarParam param)
        {
            CarCategoryDao daoCarCategory = new CarCategoryDao();

            CarCategory enCarCategory = param.CarCategory;
            enCarCategory.Deleted = 0;
            enCarCategory.Version = 0;
            enCarCategory.CreatedBy = "Thanh";
            enCarCategory.CreatedDTG = DateTime.Now;

            daoCarCategory.InsertCarCategory(enCarCategory);
        }

        public void UpdateCarCategory(CarParam param)
        {
            CarCategoryDao daoCarCategory = new CarCategoryDao();

            CarCategory enCarCategory = param.CarCategory;
            enCarCategory.UpdatedBy = "Thanh";
            enCarCategory.UpdatedDTG = DateTime.Now;

            daoCarCategory.UpdateCarCategory(enCarCategory);
        }

        public void DeleteCarCategory(CarParam param)
        {
            CarCategoryDao daoCarCategory = new CarCategoryDao();

            CarCategory enCarCategory = param.CarCategory;
            enCarCategory.Deleted = 1;
            enCarCategory.UpdatedBy = "Thanh";
            enCarCategory.UpdatedDTG = DateTime.Now;
            daoCarCategory.UpdateCarCategory(enCarCategory);
        }

        #region Getting methods

        public void LoadDataDisplayCarCategory(CarParam param)
        {
            CarCategoryDao daoCarCategory = new CarCategoryDao();

            CarCategory enCarCategory = daoCarCategory.GetCarCategoryByID(param.CarCategory.CarCategoryID);
            if (enCarCategory == null)
                throw new Exception("Failed");
            param.CarCategory = enCarCategory;
        }

        public void LoadDataEditCarCategory(CarParam param)
        {
            CarCategoryDao daoCarCategory = new CarCategoryDao();

            CarCategory enCarCategory = daoCarCategory.GetCarCategoryByID(param.CarCategory.CarCategoryID);
            if (enCarCategory == null)
                throw new Exception("LinkNotExisted");
            param.CarCategory = enCarCategory;
        }

        public void GetCarCategoryByID(CarParam param)
        {
            CarCategoryDao daoCarCategory = new CarCategoryDao();
            param.CarCategory = daoCarCategory.GetCarCategoryByID(param.CarCategory.CarCategoryID);
        }

        #endregion

        #region Searching methods

        public void SearchCarCategory(CarParam param)
        {
            CarCategoryDao daoCarCategory = new CarCategoryDao();
            daoCarCategory.SearchCarCategory(param);
        }
        public void SearchCarCategoryNoPaging(CarParam param)
        {
            CarCategoryDao daoCarCategory = new CarCategoryDao();
            daoCarCategory.SearchCarCategoryNoPaging(param);
        }
        #endregion

        public void ValidateCarCategory(CarCategory item)
        {
            List<string> lstErr = new List<string>();

            if (lstErr.Count == 0)
            {
                throw new Exception("Failed");
            }
        }

    }
}
