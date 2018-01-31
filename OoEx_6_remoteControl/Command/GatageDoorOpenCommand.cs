using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_6_remoteControl {
    class GatageDoorOpenCommand : theCommand {
        GatageDoor m_gatageDoor;

        public GatageDoorOpenCommand( GatageDoor gatageDoor ) {
            m_gatageDoor = gatageDoor;
        }

        public void execute() {
            m_gatageDoor.OpenDoor();
        }

        public void undo() {
            m_gatageDoor.CloseDoor();
        }
    }
}
