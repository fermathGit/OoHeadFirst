using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_A11_tooManyOos {
    public class GooseAdapter : Quackable {
        Goose m_g;
        Observable m_observable;

        public GooseAdapter( Goose g ) {
            m_g = g;
            m_observable = new Observable( this );
        }

        public void quack() {
            m_g.honk();
            notifyObservers();
        }

        public void registerObserver( Observer observer ) {
            m_observable.registerObserver(observer);
        }  

        public void notifyObservers() {
            m_observable.notifyObservers();
        }
    }
}
