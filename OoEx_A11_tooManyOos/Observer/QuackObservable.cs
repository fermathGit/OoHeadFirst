using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_A11_tooManyOos {
    public interface QuackObservable {
        void registerObserver( Observer observer );
        void notifyObservers();
    }
}
