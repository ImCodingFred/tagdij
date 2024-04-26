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
    public partial class adatrogzit : Form
    {
        public adatrogzit()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_uj.Checked)
            {
                DGV.Enabled = false;
                tb_azon.Enabled = true;
                foreach (Control c in panel1.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = null;
                    }
                }
            }
            else
            {
                DGV.Enabled = true;
                tb_azon.Enabled = false;
                foreach (Control c in panel1.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = null;
                    }
                }
            }
        }

        private void btn_ment_Click(object sender, EventArgs e)
        {
            if (tb_azon.TextLength == 0)
            {
                tb_azon.Focus();
                MessageBox.Show("töltse ki a mezőt!");
            }
            else if (tb_nev.TextLength == 0)
            {
                tb_nev.Focus();
                MessageBox.Show("töltse ki a mezőt!");
            }
            else if (tb_szulev.TextLength == 0)
            {
                tb_szulev.Focus();
                MessageBox.Show("töltse ki a mezőt!");
            }
            else if (tb_szulev.TextLength > 4)
            {
                tb_szulev.Focus();
                tb_szulev.Clear();
                MessageBox.Show("max 4 szám jegyű lehet a szám");
            }
            else if (tb_irszam.TextLength == 0)
            {
                tb_irszam.Focus();
                MessageBox.Show("töltse ki a mezőt!");
            }
            else if (tb_irszam.TextLength > 4)
            {
                tb_irszam.Focus();
                tb_irszam.Clear();
                MessageBox.Show("max 4 szám jegyű lehet a szám");
            }
            else if (tb_orsz.TextLength == 0)
            {
                tb_orsz.Focus();
                MessageBox.Show("töltse ki a mezőt!");
            }
            else
            {
                if (rb_uj.Checked)
                {
                    try
                    {
                        string querry = "INSERT INTO ugyfel(azon,nev,szulev,irszam,orsz)" +
                        $"Values('{tb_azon.Text}','{tb_nev.Text}','{tb_szulev.Text}','{tb_irszam.Text}','{tb_orsz.Text}');";
                        db db = new db(querry);
                        dbload();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("hibás művelet!");
                    }
                }
                else
                {
                    try
                    {
                        string querry = $"UPDATE ugyfel SET nev='{tb_nev.Text}', szulev='{tb_szulev.Text}', irszam='{tb_irszam.Text}', orsz='{tb_orsz.Text}' WHERE azon = {tb_azon.Text};";
                        db db = new db(querry);
                        dbload();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("hibás művelet!");
                    }
                }
            }
        }

        private void adatrogzit_Load(object sender, EventArgs e)
        {
            dbload();
            rb_uj.Checked = true;
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

        private void tb_azon_TextChanged(object sender, EventArgs e)
        {
            if (tb_azon.TextLength > 0)
            {
                try
                {
                    int a = int.Parse(tb_azon.Text);
                }
                catch
                {
                    MessageBox.Show("csak számot adjon meg!");
                    tb_azon.Focus();
                    tb_azon.Clear();
                }
            }
        }

        private void tb_szulev_TextChanged(object sender, EventArgs e)
        {
            if (tb_szulev.TextLength > 0)
            {
                try
                {
                    int a = int.Parse(tb_szulev.Text);
                }
                catch
                {
                    MessageBox.Show("csak számot adjon meg!");
                    tb_szulev.Focus();
                    tb_szulev.Clear();
                }
            }
        }

        private void tb_irszam_TextChanged(object sender, EventArgs e)
        {
            if (tb_irszam.TextLength > 0)
            {
                try
                {
                    int a = int.Parse(tb_irszam.Text);
                }
                catch
                {
                    MessageBox.Show("csak számot adjon meg!");
                    tb_irszam.Focus();
                    tb_irszam.Clear();
                }
            }
        }

        private void btn_elvet_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = null;
                }
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_azon.Text = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_nev.Text = DGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_szulev.Text = DGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_irszam.Text = DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            tb_orsz.Text = DGV.Rows[e.RowIndex].Cells[4].Value.ToString();

        }
    }
}
