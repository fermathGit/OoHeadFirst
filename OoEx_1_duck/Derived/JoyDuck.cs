using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_1_duck {
    class JoyDuck : Duck {
        public JoyDuck( string name ) : base( name , new FlyNoWay()) {
        }

        public override void Display() {
            
        }
    }
}
