using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_3_cofe {
    class Mocha : CondimentDecorator {
        Beverage m_beverage;

        public Mocha( Beverage beverage ) {
            m_beverage = beverage;
        }

        public override string GetDescription() {
            return m_beverage.GetDescription() + ".Mocha";
        }

        public override double Cost() {
            double add = 0;
            var size = m_beverage.GetSize();
            if ( size == BeverageSize.Big )
                add = 2.89;
            else if ( size == BeverageSize.Mid )
                add = 1.50;
            else
                add = .50;
            return m_beverage.Cost() + add;
        }

        public override BeverageSize GetSize() {
            return m_beverage.GetSize();
        }
    }
}
