using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_4_pizza {
    abstract class PizzaStore {
        public Pizza OrderPizza( pizzaType type ) {
            Pizza pizza;
            pizza = CreatePizza( type );

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public abstract Pizza CreatePizza( pizzaType type );
    }
}
