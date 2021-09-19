using System;
using System.Collections.Generic;

namespace Fillword
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleDrawer consoleDrawer = new ConsoleDrawer();
            ConsoleLogic consoleLogic = new ConsoleLogic();
            Fillword fillword = new Fillword(consoleDrawer, consoleLogic);

            //fillword.Run();

            Button[] buttons = {new Button("1") , new Button("2"),
                new Button("1", new Button[] { } )
            };
        }

        
    }
}
