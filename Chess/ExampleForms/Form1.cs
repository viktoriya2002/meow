﻿using Chess.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleForms
{
    public partial class Form1 : Form
    {
        private readonly Greetings greetings;

        public Form1(Greetings greetings)
        {
            InitializeComponent();
            this.greetings = greetings;
        }

        private void helloButton_Click(object sender, EventArgs e)
        {
            greetings.ShowGreet();
        }
    }
}
