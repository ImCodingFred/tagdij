namespace tagdij
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void �gyf�lAdatokR�gz�t�seToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adatrogzit rogz = new adatrogzit();
            rogz.ShowDialog();
        }

        private void befizet�sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            befiz be = new befiz();
            be.ShowDialog();
        }

        private void lek�rdez�sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lekerdezes lekerd = new lekerdezes();
            lekerd.ShowDialog();
        }
    }
}
