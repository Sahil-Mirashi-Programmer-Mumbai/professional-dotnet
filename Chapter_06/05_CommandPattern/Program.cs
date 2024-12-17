/*
Definition: Command Pattern turns a request into a stand-alone object, thus allowing for parameterization of clients with queues, requests, and operations.

Why it is used: To decouple sender and receiver, enabling operations to be executed, queued, or logged.
*/

namespace CommandPattern
{
    // Command Interface
    public interface ICommand
    {
        void Execute();
    }

    // Concrete Command
    public class LightOnCommand : ICommand
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }

    // Receiver
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is On");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is Off");
        }
    }

    // Invoker
    public class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            ICommand lightOnCommand = new LightOnCommand(light);

            RemoteControl remoteControl = new RemoteControl();
            remoteControl.SetCommand(lightOnCommand);
            remoteControl.PressButton();  // Output: Light is On
        }
    }
}