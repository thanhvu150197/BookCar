using BookCar.SharedComponent;
using BookCar.SharedComponent.Param;
using BookCarBLL.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCar.SharedComponent.Constant;
namespace BookCarBLL
{
    public partial class MainController
    {
        private static MainController provider;

        private MainController() { }

        public static MainController Provider
        {
            get
            {
                if (provider == null)
                {
                    provider = new MainController();
                }
                return provider;
            }
        }
        public void Execute(BaseParam baseParam)
        {
            string function = string.Format("MainController: {0} - {1}", baseParam.BusinessType, baseParam.FunctionType);
            switch (baseParam.BusinessType)
            {
                case BusinessType.BookCar:
                    ExecuteBC(baseParam as CarParam);
                    break;
                default:
                    break;
            }

        }
        private void ExecuteBC(CarParam param)
        {
            switch (param.FunctionType)
            {
                #region CarFunction
                case FunctionType.CarFunction.AddNewCar:
                    {
                        var biz = new CarsBiz();
                        biz.AddNewCar(param);
                        break;
                    }
                case FunctionType.CarFunction.UpdateCar:
                    {
                        var biz = new CarsBiz();
                        biz.UpdateCar(param);
                        break;
                    }
                case FunctionType.CarFunction.DeleteCar:
                    {
                        var biz = new CarsBiz();
                        biz.DeleteCar(param);
                        break;
                    }
                case FunctionType.CarFunction.SearchCar:
                    {
                        var biz = new CarsBiz();
                        biz.SearchCar(param);
                        break;
                    }
                case FunctionType.CarFunction.LoadDataEditCar:
                    {
                        var biz = new CarsBiz();
                        biz.LoadDataEditCar(param);
                        break;
                    }
                case FunctionType.CarFunction.LoadDataDisplayCar:
                    {
                        var biz = new CarsBiz();
                        biz.LoadDataDisplayCar(param);
                        break;
                    }
                #endregion
                #region CategoryFunction

                case FunctionType.CarCategoryFunction.AddNewCarCategory:
                    {
                        var biz = new CarCategoryBiz();
                        biz.AddNewCarCategory(param);
                        break;
                    }
                case FunctionType.CarCategoryFunction.UpdateCarCategory:
                    {
                        var biz = new CarCategoryBiz();
                        biz.UpdateCarCategory(param);
                        break;
                    }
                case FunctionType.CarCategoryFunction.DeleteCarCategory:
                    {
                        var biz = new CarCategoryBiz();
                        biz.DeleteCarCategory(param);
                        break;
                    }
                case FunctionType.CarCategoryFunction.SearchCarCategory:
                    {
                        var biz = new CarCategoryBiz();
                        biz.SearchCarCategory(param);
                        break;
                    }
                case FunctionType.CarCategoryFunction.SearchCarCategoryNoPaging:
                    {
                        var biz = new CarCategoryBiz();
                        biz.SearchCarCategoryNoPaging(param);
                        break;
                    }
                case FunctionType.CarCategoryFunction.LoadDataEditCarCategory:
                    {
                        var biz = new CarCategoryBiz();
                        biz.LoadDataEditCarCategory(param);
                        break;
                    }
                case FunctionType.CarCategoryFunction.LoadDataDisplayCarCategory:
                    {
                        var biz = new CarCategoryBiz();
                        biz.LoadDataDisplayCarCategory(param);
                        break;
                    }
                default:
                    break;
                #endregion
                #region ServiceOrdersFunction
                case FunctionType.ServiceOrderFunction.AddNewServiceOrder:
                    {
                        var biz = new ServiceOrderBiz();
                        biz.AddNewServiceOrder(param);
                        break;
                    }
                case FunctionType.ServiceOrderFunction.UpdateServiceOrder:
                    {
                        var biz = new ServiceOrderBiz();
                        biz.UpdateServiceOrder(param);
                        break;
                    }
                case FunctionType.ServiceOrderFunction.DeleteServiceOrder:
                    {
                        var biz = new ServiceOrderBiz();
                        biz.DeleteServiceOrder(param);
                        break;
                    }
                case FunctionType.ServiceOrderFunction.SearchServiceOrder:
                    {
                        var biz = new ServiceOrderBiz();
                        biz.SearchServiceOrder(param);
                        break;
                    }
                case FunctionType.ServiceOrderFunction.LoadDataEditServiceOrder:
                    {
                        var biz = new ServiceOrderBiz();
                        biz.LoadDataEditServiceOrder(param);
                        break;
                    }
                case FunctionType.ServiceOrderFunction.LoadDataDisplayServiceOrder:
                    {
                        var biz = new ServiceOrderBiz();
                        biz.LoadDataDisplayServiceOrder(param);
                        break;
                    }
                #endregion
                #region TimeCategoryFunction
                case FunctionType.TimeCategoryFunction.AddNewTimeCategory:
                    {
                        var biz = new TimeCategoryBiz();
                        biz.AddNewTimeCategory(param);
                        break;
                    }
                case FunctionType.TimeCategoryFunction.UpdateTimeCategory:
                    {
                        var biz = new TimeCategoryBiz();
                        biz.UpdateTimeCategory(param);
                        break;
                    }
                case FunctionType.TimeCategoryFunction.DeleteTimeCategory:
                    {
                        var biz = new TimeCategoryBiz();
                        biz.DeleteTimeCategory(param);
                        break;
                    }
                case FunctionType.TimeCategoryFunction.SearchTimeCategory:
                    {
                        var biz = new TimeCategoryBiz();
                        biz.SearchTimeCategory(param);
                        break;
                    }
                case FunctionType.TimeCategoryFunction.LoadDataEditTimeCategory:
                    {
                        var biz = new TimeCategoryBiz();
                        biz.LoadDataEditTimeCategory(param);
                        break;
                    }
                case FunctionType.TimeCategoryFunction.LoadDataDisplayTimeCategory:
                    {
                        var biz = new TimeCategoryBiz();
                        biz.LoadDataDisplayTimeCategory(param);
                        break;
                    }

                    #endregion

            }
        }
    }
}
