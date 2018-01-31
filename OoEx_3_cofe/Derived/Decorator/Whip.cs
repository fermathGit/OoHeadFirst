using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_3_cofe {
    class Whip : CondimentDecorator {
        Beverage m_beverage;

        public Whip( Beverage bevarage) {
            m_beverage = bevarage;
        }

        public override string GetDescription() {
            return m_beverage.GetDescription() + ",Whip";
        }

        public override double Cost() {
            return m_beverage.Cost() + .40;
        }

        public override BeverageSize GetSize() {
            return m_beverage.GetSize();
        }
    }
}
