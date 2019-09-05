using System;

namespace PatternsExample
{
    class Program
    {
        abstract class Command
        {
            public abstract void Execute();
            public abstract void Undo();
        }
        // конкретная команда
        class ConcreteCommand : Command
        {
            Printer printer;
            public ConcreteCommand(Printer r)
            {
                printer = r;
            }
            public override void Execute()
            {
                printer.ButtonbeenPressed();
            }

            public override void Undo()
            {
                printer.ButtonsBeenChanged();
            }
        }

        // получатель команды
        class Printer
        {
            public void ButtonbeenPressed()
            {
                Console.WriteLine("You've pressed the button");
            }
            public void ButtonsBeenChanged()
            {
                Console.WriteLine("You've changed the button");
            }
        }
        // инициатор команды
        class ViewM
        {
            Command command;
            public void SetCommand(Command c)
            {
                command = c;
            }
            public void Run()
            {
                command.Execute();
            }
            public void Cancel()
            {
                command.Undo();
            }
        }
        class Client
        {
            static void Main()
            {
                ViewM viewm = new ViewM();
                Printer printer = new Printer();
                ConcreteCommand command = new ConcreteCommand(printer);
                viewm.SetCommand(command);
                viewm.Run();
                viewm.Cancel();
            }
        }
    }
}
