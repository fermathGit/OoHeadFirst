using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_1_duck {
     abstract class Duck {
        string m_name;
        readonly IFlyBehavior flyBehavior;

        protected Duck( string name, IFlyBehavior fb ) {
            m_name = name;
            flyBehavior = fb ?? new FlyWithWings();
        }

        public void Speak() {
            Console.WriteLine( string.Format( "我是{0}，呱呱呱", m_name ) );
        }

        public void Swim() {
            Console.WriteLine( "游啊游" );
        }

        public void PerformFly() {
            if ( flyBehavior != null )
                flyBehavior.fly();
        }

        public abstract void Display();
        
    }
}
