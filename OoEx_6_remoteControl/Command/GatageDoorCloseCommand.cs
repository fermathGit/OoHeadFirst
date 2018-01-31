using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_6_remoteControl {
    class GatageDoorCloseCommand :theCommand{
        GatageDoor m_gatageDoor;

        public GatageDoorCloseCommand( GatageDoor gatageDoor ) {
            m_gatageDoor = gatageDoor;
        }

        public void execute() {
            m_gatageDoor.CloseDoor();
        }

        public void undo() {
            m_gatageDoor.OpenDoor();
        }
    }
}
