using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_4_pizza {
    class Program {
        static void Main( string[] args ) {
            PizzaStore nYPizzaStore = new NYPizzaStore();
            nYPizzaStore.OrderPizza( pizzaType.veggie);

            PizzaStore pizzaStore = new NormalStore();
            pizzaStore.OrderPizza( pizzaType.cheese );
            Console.Read();
        }
    }
}
