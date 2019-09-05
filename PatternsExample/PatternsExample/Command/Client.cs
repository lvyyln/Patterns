using System;
using System.Collections.Generic;
using System.Text;
using PatternsExample;
using static PatternsExample.Program;

namespace PatternsExample.Comman
{
    class Client
    {
        BaseCommand command;
        public void SetCommand(BaseCommand c)
        {
            command = c;
        }
        public void Run()
        {
            command.Execute();
        }
        
    }
}
