using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_3_cofe {

    public abstract class CondimentDecorator : Beverage {
        public override abstract BeverageSize GetSize();
    }
}
