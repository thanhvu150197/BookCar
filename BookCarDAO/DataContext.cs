using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCarDAO
{
    public class DataContext : SoftMart.Core.Dao.EnterpriseService
    {
        //private PLogger _logger;
        public DataContext()
            : base("Data Source = .; Initial Catalog = BookCar;User ID=sa;Password=123")
         {
            //var callerName = new System.Diagnostics.StackTrace().GetFrame(1).GetMethod().Name;
            //_logger = new PLogger(string.Format("DataContext - {0}", callerName));
         }

      
    }
}
