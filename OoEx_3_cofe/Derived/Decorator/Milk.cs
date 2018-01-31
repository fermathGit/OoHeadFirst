using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_3_cofe {
    class Milk : CondimentDecorator {
        Beverage m_beverage;

        public Milk( Beverage beverage ) {
            m_beverage = beverage;
        }

        public override double Cost() {
            return m_beverage.Cost() + 100;
        }

        public override string GetDescription() {
            return m_beverage.GetDescription() + ",Milk";
        }

        public override BeverageSize GetSize() {
            return m_beverage.GetSize();
        }
    }
}
