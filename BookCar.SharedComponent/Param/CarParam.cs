using BookCar.SharedComponent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.SharedComponent.Param
{
    public class CarParam
    {
        public List<CarCategory> ListCarCategories { get; set; }
        public CarCategory CarCategory { get; set; }
        public List<Car> ListCar { get; set; }
        public Car Car { get; set; }
        public List<ServiceOrder> ListServiceOrder { get; set; }
        public ServiceOrder ServiceOrder { get; set; }
        public List<TimeCategory> ListTimeCategory { get; set; }

        public int Pagesize { get; set; }
        public int CurrentPageIndex { get; set; }
        public int? TotalItem { get; set; }

        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
    }
}
