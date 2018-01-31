using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_A11_tooManyOos {
    class Program {
        static void Main( string[] args ) {
            Program p = new Program();
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            p.simulate( duckFactory );
        }

        private void simulate( AbstractDuckFactory duckFactory ) {
            Quackable md = duckFactory.createMallardDuck();
            Quackable rd = duckFactory.createRedheadDuck();
            Quackable dc = duckFactory.createDuckCall();
            Quackable rud = duckFactory.createRubberDuck();
            Quackable gd = new GooseAdapter( new Goose() );
            Console.WriteLine( "\nDuck Simulator\n\n" );

            Flock flockOfDucks = new Flock();
            flockOfDucks.add( md );
            flockOfDucks.add( rd );
            flockOfDucks.add( dc );

            Quackologist qolo = new Quackologist();
            flockOfDucks.registerObserver( qolo );
            gd.registerObserver( qolo );

            simulate( flockOfDucks );
            simulate( rud );
            simulate( gd );

            Console.WriteLine( "\nDuck quacked " +
                               QuackCounter.getQuacks() );
            Console.ReadLine();
        }

        private void simulate( Quackable q ) {
            q.quack();
        }
    }
}
