using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_1_duck {
    class FlyNoWay : IFlyBehavior {
        public void fly() {
            Console.WriteLine( "..... 什么都没发生" );
        }
    }
}
