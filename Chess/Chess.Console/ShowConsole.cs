using Chess.Engine;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.ConsoleApp
{
    public class ShowConsole : IShow
    {
        public virtual void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class ShowColorConsole : ShowConsole
    {
        public override void ShowMessage(string message)
        {
            var tmp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            base.ShowMessage(message);
            Console.ForegroundColor = tmp;
        }
    }
}
