namespace tagdij
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ügyfélAdatokRögzítéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adatrogzit rogz = new adatrogzit();
            rogz.ShowDialog();
        }

        private void befizetésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            befiz be = new befiz();
            be.ShowDialog();
        }

        private void lekérdezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lekerdezes lekerd = new lekerdezes();
            lekerd.ShowDialog();
        }
    }
}
