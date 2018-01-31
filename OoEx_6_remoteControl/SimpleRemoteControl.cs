using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_6_remoteControl {
    class SimpleRemoteControl {
        theCommand m_slot;

        public SimpleRemoteControl() { }

        public void SetCommand( theCommand command ) {
            m_slot = command;
        }

        public void ButtonWasPressed() {
            m_slot.execute();
        }
    }
}
