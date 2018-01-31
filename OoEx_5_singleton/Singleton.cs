using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_5_singleton {
    public sealed class Singleton {
        private static Singleton uniqueInstance;
        private Singleton() {
            Console.WriteLine( "make" );
        }

        public static Singleton GetInstance() {
            if ( null == uniqueInstance ) {
                uniqueInstance = new Singleton();
            }
            return uniqueInstance;
        }
    }
}
