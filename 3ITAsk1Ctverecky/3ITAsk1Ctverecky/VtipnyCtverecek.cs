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
    public partial class VtipnyCtverecek : Ctverecek
    {
        List<string> vtipy = new() {
                "Přijde hluchý na diskotéku a řekne: 'Hm, tady něco nehraje.'",
                "Čím se utře kouzelník, když mu dojde toaleťák? Trikem.",
                "Co dělá humr, když má deprese? Chce humřít.",
                "Proč nemá krab peníze? Protože je na dně.",
                "Jaký strom se používá na výrobu kapesníků? Smrk.",
                "Jak umře voda? Zkape.",
                "Co říká farmář, když hledá traktor? 'Kde je můj traktor?'",
                "'Makám od nevidim do nevidim', říká slepý kariérista."
            };
        public VtipnyCtverecek()
        {
            InitializeComponent();
        }
        public override void Ctverecek_MouseClick(object sender, MouseEventArgs e)
        {
            base.Ctverecek_MouseClick(sender, e);
            Random r = new Random();
            label1.Text = vtipy[r.Next(vtipy.Count)];
        }
    }
}
