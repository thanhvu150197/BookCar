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
    public class TimeCategoryDao : BaseDao
    {
        #region Modification methods

        public void InsertTimeCategory(TimeCategory item)
        {
            using (DataContext dataContext = new DataContext())
            {
                dataContext.InsertItem<TimeCategory>(item);
            }
        }

        public void UpdateTimeCategory(TimeCategory item)
        {
            int affectedRows;
            using (DataContext dataContext = new DataContext())
            {
                affectedRows = dataContext.UpdateItem<TimeCategory>(item);
            }
            if (affectedRows == 0)
            {
                throw new SMXException("Failed");
            }
        }

        #endregion

        #region Getting methods

        public TimeCategory GetTimeCategoryByID(int? id)
        {
            using (DataContext dataContext = new DataContext())
            {
                return dataContext.SelectItemByID<TimeCategory>(id);
            }
        }

        #endregion

        #region Searching methods

        public void SearchTimeCategory(CarParam caParam)
        {
            var cmdText = @"select * from TimeCategory";
            DataContext dt = new DataContext();
            caParam.ListTimeCategory= dt.ExecuteSelect<TimeCategory>(cmdText);
        }

        #endregion
    }
}
