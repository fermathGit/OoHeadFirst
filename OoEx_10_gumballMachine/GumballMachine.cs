using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_10_gumballMachine {
    public class GumballMachine {
        const int SOLD_OUT = 0;
        const int NO_QUARTER = 1;
        const int HAS_QUARTER = 2;
        const int SOLD = 3;

        int state = SOLD_OUT;
        int count = 0;

        public GumballMachine( int count ) {
            this.count = count;
            if ( count > 0 ) {
                state = NO_QUARTER;
            }
        }

        public void insertQuarter() {
            if ( state == HAS_QUARTER ) {
                Console.WriteLine( "你都投了" );
            } else if ( state == NO_QUARTER ) {
                state = HAS_QUARTER;
                Console.WriteLine( "投入成功" );
            } else if ( state == SOLD_OUT ) {
                Console.WriteLine( "已经卖光了" );
            } else if ( state == SOLD ) {
                Console.WriteLine( "不要着急，正在出售时不接受投币" );
            }
        }

        public void ejectQuarter() {
            if ( state == HAS_QUARTER ) {
                Console.WriteLine( "退回成功" );
                state = NO_QUARTER;
            } else if ( state == NO_QUARTER ) {
                Console.WriteLine( "你也妹投啊" );
            } else if ( state == SOLD_OUT ) {
                Console.WriteLine( "你也妹投啊" );
            } else if ( state == SOLD ) {
                Console.WriteLine( "不好意思，泼出去的水难以收回来了" );
            }
        }

        public void turnCrank() {
            if ( state == HAS_QUARTER ) {
                Console.WriteLine( "转动成功" );
                state = SOLD;
                dispense();
            } else if ( state == NO_QUARTER ) {
                Console.WriteLine( "你转动的挺有劲的，但是你妹投币" );
            } else if ( state == SOLD_OUT ) {
                Console.WriteLine( "你转动的挺有劲的，但是我根本没有糖果了" );
            } else if ( state == SOLD ) {
                Console.WriteLine( "别着急，马上就给你发放" );
            }
        }

        public void dispense() {
            if ( state == HAS_QUARTER ) {
                Console.WriteLine( "无法发放，请摇一摇" );
            } else if ( state == NO_QUARTER ) {
                Console.WriteLine( "无法发放，请投币" );
            } else if ( state == SOLD_OUT ) {
                Console.WriteLine( "无法发放，售罄了" );
            } else if ( state == SOLD ) {
                Console.WriteLine( "正在发放" );
                count--;
                Console.WriteLine( "发放成功，欢迎下次光临@@@@@@@@@@@@@@@@@@@@@@@" );
                if ( count == 0 ) {
                    Console.WriteLine( "Oops,卖光了" );
                    state = SOLD_OUT;
                } else {
                    state = NO_QUARTER;
                }
            }
        }

        public override string ToString() {
            return string.Format( "******\n状态为：{0},还剩{1}个糖果\n******", state, count );
        }
    }
    
}
