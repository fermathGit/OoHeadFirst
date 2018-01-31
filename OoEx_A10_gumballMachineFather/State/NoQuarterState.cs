using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_A10_gumballMachineFather {
    public class NoQuarterState : State {
        GumballMachine m_gm;

        public NoQuarterState( GumballMachine gm ) {
            m_gm = gm;
        }

        public void dispense() {
            Console.WriteLine( "无法发放，请投币" );
        }

        public void ejectQuarter() {
            Console.WriteLine( "你也妹投啊" );
        }

        public void insertQuarter() {
            Console.WriteLine( "投入成功" );
            m_gm.setState( m_gm.s_HAS_QUARTER_STATE );
        }

        public void turnCrank() {
            Console.WriteLine( "你转动的挺有劲的，但是你妹投币" );
        }
    }
}
