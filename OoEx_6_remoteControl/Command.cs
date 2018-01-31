using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_6_remoteControl {
    public interface theCommand {
        void execute() ;
        void undo();
    }
}
