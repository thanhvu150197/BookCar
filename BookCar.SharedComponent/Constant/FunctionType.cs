using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.SharedComponent.Constant
{
    public class FunctionType
    {
        public class CarFunction
        {
            public const string AddNewCar = "AddNewCar";
            public const string UpdateCar = "UpdateCar";
            public const string DeleteCar = "DeleteCar";
            public const string SearchCar = "SearchCar";
            public const string LoadDataEditCar = "LoadDataEditCar";
            public const string LoadDataDisplayCar = "LoadDataDisplayCar";
        }
        public class CarCategoryFunction
        {
            public const string AddNewCarCategory = "AddNewCarCategory";
            public const string UpdateCarCategory = "UpdateCarCategory";
            public const string DeleteCarCategory = "DeleteCarCategory";
            public const string SearchCarCategory = "SearchCarCategory";
            public const string SearchCarCategoryNoPaging = "SearchCarCategoryNoPaging";
            public const string LoadDataEditCarCategory = "LoadDataEditCarCategory";
            public const string LoadDataDisplayCarCategory = "LoadDataDisplayCarCategory";
        }
        public class ServiceOrderFunction
        {
            public const string AddNewServiceOrder = "AddNewServiceOrder";
            public const string UpdateServiceOrder = "UpdateServiceOrder";
            public const string DeleteServiceOrder = "DeleteServiceOrder";
            public const string SearchServiceOrder = "SearchServiceOrder";
            public const string LoadDataEditServiceOrder = "LoadDataEditServiceOrder";
            public const string LoadDataDisplayServiceOrder = "LoadDataDisplayServiceOrder";
        }
        public class TimeCategoryFunction
        {
            public const string AddNewTimeCategory = "AddNewTimeCategory";
            public const string UpdateTimeCategory = "UpdateTimeCategory";
            public const string DeleteTimeCategory = "DeleteTimeCategory";
            public const string SearchTimeCategory = "SearchTimeCategory";
            public const string LoadDataEditTimeCategory = "LoadDataEditTimeCategory";
            public const string LoadDataDisplayTimeCategory = "LoadDataDisplayTimeCategory";
        }
    }
}
