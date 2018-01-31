using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_8_module {
    public class Coffee {
        void prepareRecipe() {
            boilWater();
            brewCoffeeGrinds();
            pourInCup();
            addSugarAndMilk();
        }

        private void boilWater() {
            Console.WriteLine( "Boiling water" );
        }

        private void brewCoffeeGrinds() {
            Console.WriteLine( "through filter" );
        }

        private void pourInCup() {
            Console.WriteLine( "Pouring into cup" );
        }

        private void addSugarAndMilk() {
            Console.WriteLine( "Adding Sugar and Milk" );
        }
    }
}
