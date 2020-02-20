using BookCar.SharedComponent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookCar.SharedComponent;
namespace BookCar.SharedComponent.Param
{
    public class CarParam : BaseParam
    {
        public CarParam(string functionType) : base(BookCar.SharedComponent.Constant.BusinessType.BookCar, functionType)
        {

        }
        public List<CarCategory> ListCarCategories { get; set; }
        public CarCategory CarCategory { get; set; }
        public List<Car> ListCar { get; set; }
        public Car Car { get; set; }
        public List<ServiceOrder> ListServiceOrder { get; set; }
        public ServiceOrder ServiceOrder { get; set; }
        public List<TimeCategory> ListTimeCategory { get; set; }
        public TimeCategory TimeCategory { get; set; }
        public int Pagesize { get; set; }
        public int CurrentPageIndex { get; set; }
        public int? TotalItem { get; set; }

        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
   
    }
}
