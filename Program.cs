using System;

namespace Fillword
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleDrawer consoleDrawer = new ConsoleDrawer();
            Fillword fillword = new Fillword(consoleDrawer);

            fillword.Run();
        }
    }
}
