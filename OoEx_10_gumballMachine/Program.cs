using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_10_gumballMachine {
    class Program {
        static void Main( string[] args ) {
            GumballMachine gm = new GumballMachine( 5 );
            Console.WriteLine( gm );

            gm.insertQuarter();
            gm.turnCrank();

            Console.WriteLine( gm );

            gm.insertQuarter();
            gm.ejectQuarter();
            gm.turnCrank();

            Console.WriteLine( gm );

            gm.insertQuarter();
            gm.turnCrank();
            gm.insertQuarter();
            gm.turnCrank();
            gm.ejectQuarter();

            Console.WriteLine( gm );

            gm.insertQuarter();
            gm.insertQuarter();
            gm.turnCrank();
            gm.insertQuarter();
            gm.turnCrank();
            gm.insertQuarter();
            gm.turnCrank();

            Console.WriteLine( gm );

            Console.ReadLine();
        }
    }
}
