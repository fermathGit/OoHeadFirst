using OoEx_7_adapter.theDuck;
using OoEx_7_adapter.theTurkey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_7_adapter {
    class Program {
        static void Main( string[] args ) {
            List<Duck> ducks = new List<Duck>();

            MallardDuck duck = new MallardDuck();
            ducks.Add( duck );

            //ducks.Add( new WildTurkey() );
            WildTurkey wt = new WildTurkey();
            ducks.Add( new TurkeyAdapter( wt ) );



            for ( int i=0, imax = ducks.Count; i < imax; ++i ) {
                ducks[i].fly();
                ducks[i].quack();
            }

            Console.Read();
        }
    }
}
