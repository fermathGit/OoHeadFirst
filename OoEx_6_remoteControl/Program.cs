using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoEx_6_remoteControl {
    class Program {
        static void Main( string[] args ) {
            SimpleRemoteControl src = new SimpleRemoteControl();

            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand( light );

            src.SetCommand( lightOn );
            src.ButtonWasPressed();

            GatageDoor gatageDoor = new GatageDoor();
            GatageDoorOpenCommand doorOpen = new GatageDoorOpenCommand( gatageDoor );

            src.SetCommand( doorOpen );
            src.ButtonWasPressed();

            /*************************************************************/
            Console.WriteLine( "华丽丽的****" );

            RemoteLoader remoteLoader = new RemoteLoader();

            LightOffCommand lightOff = new LightOffCommand( light );
            GatageDoorCloseCommand doorClose = new GatageDoorCloseCommand( gatageDoor );

            remoteLoader.SetCommand( 0, lightOn, lightOff );
            remoteLoader.SetCommand( 1, doorOpen, doorClose );

            remoteLoader.OnButtonWasPushed( 0 );
            remoteLoader.OffButtonWasPushed( 0 );
            remoteLoader.UndoButtonWasPushed();
            remoteLoader.OnButtonWasPushed( 1 );
            remoteLoader.OffButtonWasPushed( 1 );
            remoteLoader.UndoButtonWasPushed();
            Console.Read();
        }
    }
}
