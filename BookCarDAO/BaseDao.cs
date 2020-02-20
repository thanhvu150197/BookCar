using System.Linq;
using System.Data ;
using SoftMart.Core.Dao;
using System.Data.SqlClient;
using SoftMart.Kernel.Entity;
using System.Collections.Generic;
 

namespace BookCarDAO
{
    public abstract class BaseDao
    {
        protected string BuildLikeFilter(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return null;
            return string.Format("%{0}%", keyword.Trim());
        }

        protected string BuildLikeFilterStartWith(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return null;
            return string.Format("{0}%", keyword.Trim());
        }

        protected string BuildInCondition(List<int> lstValue)
        {
            if (lstValue.Count == 0)
            {
                return "null";
            }
            else
            {
                return string.Join(", ", lstValue.ToArray());
            }
        }

        protected string BuildInCondition(List<string> lstValue)
        {
            if (lstValue.Count == 0)
            {
                return "null";
            }
            else
            {
                string result = string.Empty;
                string separator = string.Empty;

                foreach (string item in lstValue)
                {
                    result += separator + "N'" + item.Trim().Replace("'", "''") + "'";
                    separator = ",";
                }
                return result;
            }
        }

        protected List<T> ExecutePaging<T>(DataContext dataContext, SqlCommand command, string orderStatement, PagingInfo pagingInfo)
        {
            int recordCord;
            List<T> lst = dataContext.ExecutePaging<T>(command, pagingInfo.PageIndex, pagingInfo.PageSize, orderStatement, out recordCord);
            pagingInfo.RecordCount = recordCord;
            return lst;
        }

        protected List<T> ExecutePaging<T>(DataContext dataContext, string query, string orderStatement, PagingInfo pagingInfo)
        {
            SqlCommand sqlCmd = new SqlCommand(query);

            return ExecutePaging<T>(dataContext, sqlCmd, orderStatement, pagingInfo);
        }

        protected System.Data.DataTable ExecuteDataTablePaging(DataContext dataContext, SqlCommand sqlCmd, string orderStatement, PagingInfo pagingInfo)
        {
            int recordCord;
            System.Data.DataTable data = dataContext.ExecuteDataTable(sqlCmd, pagingInfo.PageIndex, pagingInfo.PageSize, orderStatement, out recordCord);
            pagingInfo.RecordCount = recordCord;

            return data;
        }

        protected string GetTopRowByPaging(SoftMart.Kernel.Entity.PagingInfo pagingInfo)
        {
            if (pagingInfo == null)
                return "100 percent";

            return ((pagingInfo.PageIndex + 10) * pagingInfo.PageSize).ToString();
        }

        protected List<T> GetItemByPaging<T>(List<T> lstItem, SoftMart.Kernel.Entity.PagingInfo pagingInfo) where T : class
        {
            if (pagingInfo != null)
            {
                pagingInfo.RecordCount = lstItem.Count;
                return lstItem.Skip(pagingInfo.RowsSkip).Take(pagingInfo.PageSize).ToList();
            }

            return lstItem;
        }

        public void InsertItem<T>(T item) where T : BaseEntity
        {
            using (DataContext context = new DataContext())
            {
                context.InsertItem<T>(item);
            }
        }

        public void InsertItems<T>(List<T> lstItem) where T : BaseEntity
        {
            if (lstItem == null || lstItem.Count == 0)
                return;

            using (DataContext context = new DataContext())
            {
                context.InsertItems<T>(lstItem);
            }
        }

        public int UpdateItem<T>(T item, bool throwExceptionIfUpdateFail = false) where T : BaseEntity
        {
            using (DataContext context = new DataContext())
            {
                int affectedRow = context.UpdateItem<T>(item);
                if (throwExceptionIfUpdateFail == true
                    && affectedRow == 0)
                {
                    throw new SoftMart.Kernel.Exceptions.SMXException("Failed");
                }

                return affectedRow;
            }
        }

        public void UpdateItems<T>(List<T> lstItem, string[] columns, bool throwExceptionIfUpdateFail = false) where T : BaseEntity
        {
            if (lstItem == null || lstItem.Count == 0)
                return;

            using (DataContext context = new DataContext())
            {
                int affectedRow = context.UpdateItems<T>(lstItem, columns);

                if (throwExceptionIfUpdateFail == true
                   && affectedRow != lstItem.Count)
                {
                    throw new SoftMart.Kernel.Exceptions.SMXException("Failed");
                }
            }
        }

        public T GetItemByID<T>(object id) where T : BaseEntity
        {
            if (id == null)
                return null;

            using (DataContext context = new DataContext())
            {
                return context.SelectItemByID<T>(id);
            }
        }

        public T GetItemByID<T>(object id, string[] columns) where T : BaseEntity
        {
            if (id == null)
                return null;

            using (DataContext context = new DataContext())
            {
                return context.SelectFieldsByID<T>(columns, id);
            }
        }

        public List<T> SelectItemByColumnName<T>(string columnName, object value) where T : SoftMart.Core.Dao.BaseEntity
        {
            using (DataContext dataContext = new DataContext())
            {
                return dataContext.SelectItemByColumnName<T>(columnName, value);
            }
        }
    }
}
