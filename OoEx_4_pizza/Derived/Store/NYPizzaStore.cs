﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_4_pizza {
    class NYPizzaStore : PizzaStore {
        public override Pizza CreatePizza( pizzaType type ) {
            switch ( type ) {
                case pizzaType.cheese: return new CheesePizza();
                case pizzaType.veggie: return new VeggiePizza();
            }
            return new Pizza();
        }
    }
}
