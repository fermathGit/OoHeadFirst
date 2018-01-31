using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_6_remoteControl {
    class RemoteLoader {
        int c_count = 7;
        theCommand[] m_onCommands;
        theCommand[] m_offCommands;
        theCommand m_undoConmmand;

        public RemoteLoader() {
            m_onCommands = new theCommand[c_count];
            m_offCommands = new theCommand[c_count];

            theCommand noCommand = new NoCommand();
            for ( int i = 0, imax = c_count; i < imax; ++i ) {
                m_onCommands[i] = noCommand;
                m_offCommands[i] = noCommand;
            }
            m_undoConmmand = noCommand;
        }

        public void SetCommand( int slot, theCommand onCommand, theCommand offCommand ) {
            m_onCommands[slot] = onCommand;
            m_offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed( int slot ) {
            m_onCommands[slot].execute();
            m_undoConmmand = m_onCommands[slot];
        }

        public void OffButtonWasPushed( int slot ) {
            m_offCommands[slot].execute();
            m_undoConmmand = m_offCommands[slot];
        }

        public void UndoButtonWasPushed() {
            m_undoConmmand.undo();
        }

    }
}
