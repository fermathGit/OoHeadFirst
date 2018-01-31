using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_A11_tooManyOos {
    public class RubberDuck : Quackable {
        Observable m_observable;

        public RubberDuck() {
            m_observable = new Observable( this );
        }

        public void quack() {
            Console.WriteLine( "我只会，吱吱吱" );
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
