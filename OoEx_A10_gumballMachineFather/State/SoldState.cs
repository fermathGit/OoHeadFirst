using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_A10_gumballMachineFather {
    public class SoldState : State {
        GumballMachine m_gm;

        public SoldState( GumballMachine gm ) {
            m_gm = gm;
        }

        public void dispense() {
            m_gm.releaseBall();

            if ( m_gm.Count <= 0 ) {
                Console.WriteLine( "Oops,卖光了" );
                m_gm.setState( m_gm.s_SOLD_OUT_STATE );
            } else {
                m_gm.setState( m_gm.s_NO_QUARTER_STATE );
            }
        }

        public void ejectQuarter() {
            Console.WriteLine( "不好意思，泼出去的水难以收回来了" );
        }

        public void insertQuarter() {
            Console.WriteLine( "不要着急，正在出售时不接受投币" );
        }

        public void turnCrank() {
            Console.WriteLine( "别着急，马上就给你发放" );
        }
    }
}
