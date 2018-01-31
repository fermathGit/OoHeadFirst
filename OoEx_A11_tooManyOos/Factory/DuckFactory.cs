﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_A11_tooManyOos {
    public class DuckFactory : AbstractDuckFactory {

        public override Quackable createDuckCall() {
            return new DuckCall();
        }

        public override Quackable createMallardDuck() {
            return new MallardDuck();
        }

        public override Quackable createRedheadDuck() {
            return new RedheadDuck();
        }

        public override Quackable createRubberDuck() {
            return new RubberDuck();
        }
    }
}
