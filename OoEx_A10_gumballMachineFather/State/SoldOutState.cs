using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_A10_gumballMachineFather {
    public class SoldOutState : State {
        GumballMachine m_gm;

        public SoldOutState( GumballMachine gm ) {
            m_gm = gm;
        }

        public void dispense() {
            Console.WriteLine( "无法发放，售罄了" );
        }

        public void ejectQuarter() {
            Console.WriteLine( "你也妹投啊" );
        }

        public void insertQuarter() {
            Console.WriteLine( "已经卖光了" );
        }

        public void turnCrank() {
            Console.WriteLine( "你转动的挺有劲的，但是我根本没有糖果了" );
        }
    }
}
