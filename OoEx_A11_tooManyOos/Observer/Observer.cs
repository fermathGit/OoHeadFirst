using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_A11_tooManyOos {
    public interface Observer {
        void update( QuackObservable duck );
    }
}
