using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_3_cofe {
    class Program {
        static void Main( string[] args ) {
            Beverage beverage = new HouseBlend();
            beverage.SetSize( Beverage.BeverageSize.Small );
            Display( beverage );

            Beverage beverage2 = new DarkRoast();
            beverage2.SetSize( Beverage.BeverageSize.Big );
            beverage2 = new Mocha( beverage2 );
            beverage2 = new Mocha( beverage2 );
            //beverage2 = new Whip( beverage2 );
            Display( beverage2 );

            Beverage beverage3 = new Espresso();
            beverage3.SetSize( Beverage.BeverageSize.Mid );
            beverage3 = new Mocha( beverage3 );
            beverage3 = new Soy( beverage3 );
            beverage3 = new Whip( beverage3 );
            beverage3 = new Milk( beverage3 );
            Display( beverage3 );

            Console.Read();
        }

        private static void Display( Beverage beverage ) {
            Console.WriteLine( string.Format( "{0} $ {1}", beverage.GetDescription(), beverage.Cost() ) );
        }
    }
}
