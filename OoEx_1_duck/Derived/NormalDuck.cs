using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_1_duck {
    class NormalDuck : Duck {
        public NormalDuck( string n ) : base( n, new FlyWithWings() ) {

        }

        public override void Display() {
            
        }
    }
}
