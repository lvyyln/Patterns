using System;
using System.Collections.Generic;
using System.Text;
using static PatternsExample.Program;

namespace PatternsExample.Comman
{
    class ConcreteCommand : BaseCommand
    {
        Printer printer;
        public ConcreteCommand(Printer r)
        {
            printer = r;
        }
        public override void Execute() => printer.ButtonbeenPressed();
    }
}
