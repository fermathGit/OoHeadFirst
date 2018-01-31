using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_A10_gumballMachineFather {
    class Program {
        static void Main( string[] args ) {
            GumballMachine gm = new GumballMachine( 5 );
            gm.turnCrank();
            gm.insertQuarter();
            gm.turnCrank();
            gm.insertQuarter();
            gm.turnCrank();
            gm.insertQuarter();
            gm.turnCrank();
            gm.insertQuarter();
            gm.turnCrank();
            gm.insertQuarter();
            gm.turnCrank();
            gm.insertQuarter();
            gm.turnCrank();

            Console.Read();
        }
    }
}
