using Chess.Engine;
using System;

namespace Chess.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var greet = new Greetings(new ShowColorConsole());
            greet.ShowGreet();
        }
    }
}
