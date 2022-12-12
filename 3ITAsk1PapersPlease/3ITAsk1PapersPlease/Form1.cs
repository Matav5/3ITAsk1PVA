namespace _3ITAsk1PapersPlease
{
    public partial class Form1 : Form
    {
        List<string> jmena = new List<string>() { "Tomáš", "Kubík", "Matìj", "Pavel", "Rozndazr", "" };
        List<string> prijmeni = new List<string>() { "Kujo","Brandon","Kubín","Werner"};
        List<string> statniObcanstvi = new List<string>() { "Liberla", "Románie", "Alfštat" };
        public Form1()
        {
            InitializeComponent();
            VytvorDoklad();
        }
        public void VytvorDoklad()
        {
            Random r = new Random();
            Doklad doklad = new Doklad(
                jmena[r.Next(jmena.Count)],
                prijmeni[r.Next(prijmeni.Count)],
                new DateTime(r.Next(1970,2022),r.Next(1,13),r.Next(1,32)),
                statniObcanstvi[r.Next(statniObcanstvi.Count)],
                new DateTime(r.Next(2022,2023),r.Next(1,13),1)
                );
            flowLayoutPanel1.Controls.Add(doklad);
        }
    }
}