using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_A11_tooManyOos {
    public class Observable : QuackObservable {
        List<Observer> m_observers = new List<Observer>();
        QuackObservable m_duck;

        public Observable( QuackObservable duck ) {
            m_duck = duck;
        }

        public void notifyObservers() {
            if ( m_observers != null && m_observers.Count > 0 ) {
                for ( int i = 0, imax = m_observers.Count; i < imax; ++i ) {
                    m_observers[i].update( m_duck );
                }
            }
        }

        public void registerObserver( Observer observer ) {
            m_observers.Add( observer );
        }
    }
}
