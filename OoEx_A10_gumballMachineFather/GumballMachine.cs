using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_A10_gumballMachineFather {
    public class GumballMachine {
        State m_SOLD_OUT_STATE;
        State m_NO_QUARTER_STATE;
        State m_HAS_QUARTER_STATE;
        State m_SOLD_STATE;
        State m_WINNER_STATE;
        public State s_SOLD_OUT_STATE { get { return m_SOLD_OUT_STATE; } }
        public State s_NO_QUARTER_STATE { get { return m_NO_QUARTER_STATE; } }
        public State s_HAS_QUARTER_STATE { get { return m_HAS_QUARTER_STATE; } }
        public State s_SOLD_STATE { get { return m_SOLD_STATE; } }
        public State s_WINNER_STATE { get { return m_WINNER_STATE; } }

        int m_count = 0;
        public int Count { get { return m_count; } }
        State m_state;

        public GumballMachine( int num ) {
            m_SOLD_OUT_STATE = new SoldOutState( this );
            m_NO_QUARTER_STATE = new NoQuarterState( this );
            m_HAS_QUARTER_STATE = new HasQuarterState( this );
            m_SOLD_STATE = new SoldState( this );
            m_WINNER_STATE = new WinnerState( this );

            m_state = s_SOLD_OUT_STATE;
            this.m_count = num;
            if ( num > 0 ) {
                m_state = s_NO_QUARTER_STATE;
            }
        }
        
        public void ejectQuarter() {
            m_state.ejectQuarter();
        }

        public void insertQuarter() {
            m_state.insertQuarter();
        }

        public void turnCrank() {
            m_state.turnCrank();
            m_state.dispense();
        }

        public void setState( State state ) {
            m_state = state;
        }

        public void releaseBall() {
            Console.WriteLine( "正在发放" );
            if ( m_count != 0 ) {
                m_count--;
                Console.WriteLine( "发放成功，欢迎下次光临@@@@@@@@@@@@@@@@@@@@@@@" );
            }
        }
    }
}
