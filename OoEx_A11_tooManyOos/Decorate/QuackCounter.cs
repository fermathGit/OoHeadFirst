using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_A11_tooManyOos {
    public class QuackCounter : Quackable {
        Quackable m_duck;
        static int m_numberOfQuacks;

        public QuackCounter( Quackable duck ) {
            m_duck = duck;
        }

        public void quack() {
            m_duck.quack();
            m_numberOfQuacks++;
        }

        public static int getQuacks() {
            return m_numberOfQuacks;
        }

        public void registerObserver( Observer observer ) {
            m_duck.registerObserver( observer );
        }

        public void notifyObservers() {
            m_duck.notifyObservers();
        }
    }
}
