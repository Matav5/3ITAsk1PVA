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
    public partial class Ctverecek : UserControl
    {
        public Action<Ctverecek> onCtverecekClicked;
        public Ctverecek()
        {
            InitializeComponent();
        }

        public virtual void Ctverecek_MouseClick(object sender, MouseEventArgs e)
        {
            if(onCtverecekClicked != null)
                onCtverecekClicked.Invoke(this);
        }
    }
}
