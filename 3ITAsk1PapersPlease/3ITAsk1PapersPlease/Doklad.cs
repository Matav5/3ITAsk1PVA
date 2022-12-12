using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3ITAsk1PapersPlease
{
    public partial class Doklad : UserControl
    {
        public string jmeno;
        public string prijmeni;
        public DateTime datumNarozeni;
        public string statniObcanstvi;
        public DateTime datumExpirace;
        protected Doklad()
        {
            InitializeComponent();
        }
        public Doklad(string jmeno, string prijmeni, DateTime datumNarozeni, string statniObcanstvi, DateTime datumExpirace) : this()
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNarozeni = datumNarozeni;
            this.statniObcanstvi = statniObcanstvi;
            this.datumExpirace = datumExpirace;
            UpdateUI();
        }

        public void UpdateUI()
        {
            label1.Text = "Příjmení: " + prijmeni;
            label2.Text = "Jméno: " + jmeno;
            label4.Text = datumNarozeni.ToString("d");
            label6.Text = statniObcanstvi;
            label8.Text = datumExpirace.ToString("d");
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
