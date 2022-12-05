using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3ITAsk1Ctverecky
{
    public partial class ZvetsovaciCtverecek : Ctverecek
    {
        public ZvetsovaciCtverecek()
        {
            InitializeComponent();
        }
        public override void Ctverecek_MouseClick(object sender, MouseEventArgs e)
        {
            base.Ctverecek_MouseClick(sender, e);
            Size += new Size(6,6);
            Location -= new Size(3, 3);
        }
    }
}
