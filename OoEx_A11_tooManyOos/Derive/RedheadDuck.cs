using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_A11_tooManyOos {
    public class RedheadDuck : Quackable {
        Observable m_observable;

        public RedheadDuck() {
            m_observable = new Observable( this );
        }

        public void quack() {
            Console.WriteLine( "红头的我，呱呱呱" );
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
