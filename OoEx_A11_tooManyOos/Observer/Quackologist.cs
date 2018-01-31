using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_A11_tooManyOos {
    public class Quackologist : Observer {
        public void update( QuackObservable duck ) {
            Console.WriteLine( "Quackologist: " + duck + " just quacked" );
        }
    }
}
