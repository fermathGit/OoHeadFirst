using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_6_remoteControl {
    class LightOffCommand : theCommand {
        Light m_light;

        public LightOffCommand( Light light ) {
            m_light = light;
        }

        public void execute() {
            m_light.Off();
        }

        public void undo() {
            m_light.On();
        }
    }
}
