using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tagdij
{
    public partial class befiz : Form
    {
        public befiz()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void befiz_Load(object sender, EventArgs e)
        {
            dbload();
            l_nev.Text = string.Empty;
        }
        private void dbload()
        {
            DGV.Rows.Clear();
            string querry = "SELECT * FROM ugyfel";
            db db = new db(querry);
            while (db.Dr.Read())
            {
                DGV.Rows.Add(db.Dr["azon"], db.Dr["nev"], db.Dr["szulev"], db.Dr["irszam"], db.Dr["orsz"]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                DGV.Rows.Clear();
                string querry = $"SELECT * FROM ugyfel WHERE nev LIKE '%{textBox1.Text}%';";
                db db = new db(querry);
                while (db.Dr.Read())
                {
                    DGV.Rows.Add(db.Dr["azon"], db.Dr["nev"], db.Dr["szulev"], db.Dr["irszam"], db.Dr["orsz"]);
                }
            }
            else
            {
                dbload();
            }
        }

        private void tb_azon_TextChanged(object sender, EventArgs e)
        {
            if (tb_azon.TextLength > 0)
            {
                try
                {
                    int a = int.Parse(tb_azon.Text);
                    string querry = $"SELECT nev FROM ugyfel WHERE azon = {tb_azon.Text}";
                    db db = new db(querry);
                    if (db.Dr.HasRows)
                    {
                        db.Dr.Read();
                        l_nev.Text = db.Dr["nev"].ToString();
                    }
                    else
                    {
                        l_nev.Text = null;
                    }
                }
                catch
                {
                    tb_azon.Text = null;
                    MessageBox.Show("Csak számot adjon meg!");
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (tb_osszeg.TextLength > 0)
            {
                try
                {
                    int a = int.Parse(tb_osszeg.Text);
                }
                catch
                {
                    tb_osszeg.Text = null;
                    MessageBox.Show("Csak számot adjon meg!");
                }
            }
        }

        private void btn_mentes_Click(object sender, EventArgs e)
        {
            if (tb_azon.TextLength==0)
            {
                MessageBox.Show("Adjon meg értéket!");
                tb_azon.Focus();
            }
            else if (tb_osszeg.TextLength==0)
            {
                MessageBox.Show("Adjon meg értéket!");
                tb_osszeg.Focus();
            }
            else
            {
                try
                {
                    string querry = $"INSERT INTO befiz(azon,datum,osszeg)" +
                        $"values('{tb_azon.Text}','{dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss")}','{tb_osszeg.Text}');";
                    db db = new db(querry);
                    db.Dr.Read();
                    foreach (Control c in panel1.Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                    }
                    MessageBox.Show("sikeres művelet!");
                }
                catch
                {
                    MessageBox.Show("hibás művelet!");
                }
            }
        }
    }
}
