using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCar.SharedComponent
{
    public abstract class BaseParam
    {
        public string BusinessType { get; private set; }
        public string FunctionType { get; set; }

        protected BaseParam(string businessType, string functionType)
        {
            BusinessType = businessType;
            FunctionType = functionType;
        }
    }
}
