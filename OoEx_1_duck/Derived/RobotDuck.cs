using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_1_duck {
    class RobotDuck : Duck {
        public RobotDuck( string name ) : base( name, new FlyWithMachine() ) {
        }

        public override void Display() {

        }
    }
}
