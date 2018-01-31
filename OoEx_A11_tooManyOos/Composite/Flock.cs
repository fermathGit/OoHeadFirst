using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_A11_tooManyOos {
    public class Flock : Quackable {

        List<Quackable> m_quackers = new List<Quackable>();

        public void add( Quackable quacker ) { //不透明的方法
            m_quackers.Add( quacker );
        }

        public void quack() {
            if ( m_quackers != null && m_quackers.Count > 0 ) {
                for ( int i = 0, imax = m_quackers.Count; i < imax; ++i ) {
                    m_quackers[i].quack();
                }
            }
        }

        public void registerObserver( Observer observer ) {
            if ( m_quackers != null && m_quackers.Count > 0 ) {
                for ( int i = 0, imax = m_quackers.Count; i < imax; ++i ) {
                    m_quackers[i].registerObserver( observer );
                }
            }
        }

        public void notifyObservers() {
            if ( m_quackers != null && m_quackers.Count > 0 ) {
                for ( int i = 0, imax = m_quackers.Count; i < imax; ++i ) {
                    m_quackers[i].notifyObservers();

                }
            }
        }
    }
}
