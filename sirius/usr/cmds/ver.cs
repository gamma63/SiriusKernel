using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Sirius.Builtin
{
    public class ver : Command
    {
        public ver (String name) : base (name) { }

        public override String execute (String[] args)
        {
            var OS_VER = "Infinity M2, Build: 105";
            Console.WriteLine(OS_VER);
            return "";
        }
    }
}