using PatternsExample.Comman;
using System;

namespace PatternsExample
{
    class Program
    { 
            static void Main()
            {
                Client viewm = new Client();
                Printer printer = new Printer();
                ConcreteCommand command = new ConcreteCommand(printer);
                viewm.SetCommand(command);
                viewm.Run();
            }   
    }
}
