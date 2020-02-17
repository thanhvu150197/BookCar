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
    public class CategoryBiz
    {
        CarCategoryDao _daoCategory = new CarCategoryDao();
        public void SearchListCategory(CarParam param)
        {
            _daoCategory.SearchCarCategory(param);
        }
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
    }
}
