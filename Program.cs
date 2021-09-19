using System;
using System.Collections.Generic;

namespace Fillword
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleDrawer consoleDrawer = new ConsoleDrawer();
            Fillword fillword = new Fillword(consoleDrawer);

            //fillword.Run();

            Button[] buttons = {new Button("1") , new Button("2"),
                new Button("1", new Button[] { } )
            };
        }

        
    }
}
