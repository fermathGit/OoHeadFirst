using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_1_duck {
    class Program {
        static void Main( string[] args ) {
            
            var a = new NormalDuck( "河里一般的鸭子" );
            a.Speak();
            a.PerformFly();

            var b = new JoyDuck( "小黄鸭" );
            b.Speak();
            b.PerformFly();

            var c = new RobotDuck( "钢铁鸭" );
            c.Speak();
            c.PerformFly();

            Console.Read();
        }
    }
}
