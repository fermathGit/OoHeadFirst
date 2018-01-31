using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_2_weather {
    public interface Observer {
        void Update( Subject subject ); //pull
        void Update( float temp, float humidity, float pressure ); //push
    }
}
