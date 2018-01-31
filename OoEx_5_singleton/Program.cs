using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_5_singleton {
    class Program {
        static void Main( string[] args ) {
            Singleton s = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            Singleton s3 = Singleton.GetInstance();
            Singleton s4 = Singleton.GetInstance();
            Singleton s5 = Singleton.GetInstance();
            Singleton s6 = Singleton.GetInstance();

            Console.Read();
        }
    }
}
