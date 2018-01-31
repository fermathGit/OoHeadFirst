using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_7_adapter.theDuck {
    class MallardDuck : Duck {
        public void fly() {
            Console.WriteLine("fly");
        }

        public void quack() {
            Console.WriteLine( "quack" );
        }
    }
}
