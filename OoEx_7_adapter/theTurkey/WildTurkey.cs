using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_7_adapter.theTurkey {
    public class WildTurkey : Turkey {
        public void gobble() {
            Console.WriteLine( "gobble" );
        }

        public void shotFly() {
            Console.WriteLine( "shotFly" );
        }
    }
}
