using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_6_remoteControl {
    class LightOnCommand : theCommand {
        Light m_light;

        public LightOnCommand( Light light ) {
            m_light = light;
        }

        public void execute() {
            m_light.On();
        }

        public void undo() {
            m_light.Off();
        }
    }
}
