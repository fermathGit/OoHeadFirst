using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OoEx_7_adapter.theTurkey;
using OoEx_7_adapter.theDuck;

namespace OoEx_7_adapter {
    class TurkeyAdapter : Duck {
        Turkey m_turkey; 

        public TurkeyAdapter( Turkey turkey ) {
            m_turkey = turkey;
        }

        public void fly() {
            for ( int i = 0, imax = 5; i < imax; ++i ) {
                m_turkey.shotFly();
            }
        }

        public void quack() {
            m_turkey.gobble();
        }
    }
}
