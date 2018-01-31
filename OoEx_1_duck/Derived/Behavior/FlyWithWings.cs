using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_1_duck {
    class FlyWithWings : IFlyBehavior {
        public void fly() {
            Console.WriteLine( "我是真会飞，不是针对谁，在座的都" );
        }
    }
}
