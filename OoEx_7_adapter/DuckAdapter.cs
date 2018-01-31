using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OoEx_7_adapter.theTurkey;
using OoEx_7_adapter.theDuck;

namespace OoEx_7_adapter {
    class DuckAdapter : Turkey {
        Duck m_duck;
        public DuckAdapter( Duck duck ) {
            m_duck = duck;
        }

        public void gobble() {
            m_duck.quack();
        }

        public void shotFly() {
            m_duck.fly();
        }
    }
}
