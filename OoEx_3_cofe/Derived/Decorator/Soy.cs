using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_3_cofe {
    class Soy : CondimentDecorator {
        Beverage m_beverage;

        public Soy( Beverage beverage ) {
            m_beverage = beverage;
        }

        public override string GetDescription() {
            return m_beverage.GetDescription() + ",Soy";
        }

        public override double Cost() {
            return m_beverage.Cost() + .30;
        }

        public override BeverageSize GetSize() {
            return m_beverage.GetSize();
        }
    }
}
