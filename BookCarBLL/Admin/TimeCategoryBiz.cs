using BookCarDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCar.SharedComponent.Param;
using BookCar.SharedComponent.Entities;

namespace BookCarBLL.Admin
{
    public class TimeCategoryBiz
    {
        public void AddNewTimeCategory(CarParam param)
        {
            TimeCategoryDao daoTimeCategory = new TimeCategoryDao();

            TimeCategory enTimeCategory = param.TimeCategory;
            enTimeCategory.Deleted = 0;
            enTimeCategory.Version = 0;
            enTimeCategory.CreatedBy = "Thanh";
            enTimeCategory.CreatedDTG = DateTime.Now;

            daoTimeCategory.InsertTimeCategory(enTimeCategory);
        }

        public void UpdateTimeCategory(CarParam param)
        {
            TimeCategoryDao daoTimeCategory = new TimeCategoryDao();

            TimeCategory enTimeCategory = param.TimeCategory;
            enTimeCategory.UpdatedBy = "Thanh";
            enTimeCategory.UpdatedDTG = DateTime.Now;

            daoTimeCategory.UpdateTimeCategory(enTimeCategory);
        }

        public void DeleteTimeCategory(CarParam param)
        {
            TimeCategoryDao daoTimeCategory = new TimeCategoryDao();

            TimeCategory enTimeCategory = param.TimeCategory;
            enTimeCategory.Deleted = 1;
            enTimeCategory.UpdatedBy = "Thanh";
            enTimeCategory.UpdatedDTG = DateTime.Now;

            daoTimeCategory.UpdateTimeCategory(enTimeCategory);
        }

        #region Getting methods

        public void LoadDataDisplayTimeCategory(CarParam param)
        {
            TimeCategoryDao daoTimeCategory = new TimeCategoryDao();

            TimeCategory enTimeCategory = daoTimeCategory.GetTimeCategoryByID(param.TimeCategory.TimeCategoryID);
            if (enTimeCategory == null)
                throw new Exception("");
            param.TimeCategory = enTimeCategory;
        }

        public void LoadDataEditTimeCategory(CarParam param)
        {
            TimeCategoryDao daoTimeCategory = new TimeCategoryDao();

            TimeCategory enTimeCategory = daoTimeCategory.GetTimeCategoryByID(param.TimeCategory.TimeCategoryID);
            if (enTimeCategory == null)
                throw new Exception("ex");
            param.TimeCategory = enTimeCategory;
        }

        public void GetTimeCategoryByID(CarParam param)
        {
            TimeCategoryDao daoTimeCategory = new TimeCategoryDao();
            param.TimeCategory = daoTimeCategory.GetTimeCategoryByID(param.TimeCategory.TimeCategoryID);
        }

        #endregion

        #region Searching methods

        public void SearchTimeCategory(CarParam param)
        {
            TimeCategoryDao daoTimeCategory = new TimeCategoryDao();
            daoTimeCategory.SearchTimeCategory(param);
        }

        #endregion

        public void ValidateTimeCategory(TimeCategory item)
        {
            List<string> lstErr = new List<string>();

            if (lstErr.Count == 0)
            {
                throw new Exception("ex");
            }
        }
    }
}
