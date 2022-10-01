using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Engine
{
    public class Greetings
    {
        private readonly IShow show;

        public Greetings(IShow show)
        {
            this.show = show;
        }
        public string Greet()
        {
            return "Привет!!!";
        }

        public void ShowGreet()
        {
            show.ShowMessage(Greet());
        }
    }
}
