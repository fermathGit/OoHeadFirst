using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_A11_tooManyOos {
    public class DuckCall : Quackable {
        Observable m_observable;

        public DuckCall() {
            m_observable = new Observable( this );
        }

        public void quack() {
            Console.WriteLine( "假装的，呱呱呱" );
            notifyObservers();
        }

        public void registerObserver( Observer observer ) {
            m_observable.registerObserver( observer );
        }

        public void notifyObservers() {
            m_observable.notifyObservers();
        }
    }
}
