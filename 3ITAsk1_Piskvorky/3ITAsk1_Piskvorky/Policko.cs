using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3ITAsk1_Piskvorky
{
    public partial class Policko : UserControl
    {
        public Hrac vlastnikPolicka;
        public int X { get; private set; }
        public int Y { get; private set; }
        public Policko()
        {
            InitializeComponent();
        }

        private void Policko_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
