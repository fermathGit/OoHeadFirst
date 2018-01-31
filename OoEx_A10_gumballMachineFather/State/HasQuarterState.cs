using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_A10_gumballMachineFather {
    public class HasQuarterState : State {
        GumballMachine m_gm;

        Random rd = new Random();

        public HasQuarterState( GumballMachine gm ) {
            m_gm = gm;
        }

        public void dispense() {
            Console.WriteLine( "无法发放，请摇一摇" );
        }

        public void ejectQuarter() {
            Console.WriteLine( "退回成功" );
            m_gm.setState( m_gm.s_NO_QUARTER_STATE );
        }

        public void insertQuarter() {
            Console.WriteLine( "你都投了" );
        }

        public void turnCrank() {
            Console.WriteLine( "转动成功" );
            int winnerIndex = rd.Next( 0, 10 );
            if ( ( winnerIndex == 1 ) && m_gm.Count > 1 ) {
                m_gm.setState( m_gm.s_WINNER_STATE );
            } else {
                m_gm.setState( m_gm.s_SOLD_STATE );
            }
        }
    }
}
