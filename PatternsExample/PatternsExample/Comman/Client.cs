using System;
using System.Collections.Generic;
using System.Text;
using PatternsExample;
using static PatternsExample.Program;

namespace PatternsExample.Comman
{
    class Client
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
        
    }
}
