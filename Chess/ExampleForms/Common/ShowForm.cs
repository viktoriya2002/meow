using Chess.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleForms.Common
{
    class ShowForm : IShow
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
