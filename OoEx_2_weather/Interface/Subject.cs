using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_2_weather {
    public interface Subject {
         void RegisterObserver( Observer o );
         void RemoveObserver( Observer o );
         void NotifyObserver();
    }
}
