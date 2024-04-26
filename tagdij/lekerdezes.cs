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
    public partial class lekerdezes : Form
    {
        public lekerdezes()
        {
            InitializeComponent();
        }

        private void lekerdezes_Load(object sender, EventArgs e)
        {
            dbload();
            foreach (Control item in panel1.Controls)
            {
                if (item is Label)
                {
                    if (item.Name.Contains("l_"))
                    {
                        item.Text = "";
                    }
                }
            }
        }
        private void dbload()
        {
            DGV.Rows.Clear();
            string querry = "SELECT ugyfel.azon,ugyfel.nev,count(befiz.azon),sum(befiz.osszeg), max(datum) FROM ugyfel,befiz where ugyfel.azon = befiz.azon group by ugyfel.azon";
            DGV.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss";
            db db = new db(querry);
            while (db.Dr.Read())
            {
                DGV.Rows.Add(db.Dr[0], db.Dr[1], db.Dr[2], db.Dr[3], db.Dr[4]);
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            db db = new db($"Select * from ugyfel where azon = {DGV.Rows[e.RowIndex].Cells[0].Value}");
            db.Dr.Read();
            l_azon.Text = db.Dr[0].ToString();
            l_nev.Text = db.Dr[1].ToString();
            l_szulev.Text = db.Dr[2].ToString();
            l_irszam.Text = db.Dr[3].ToString();
            l_orsz.Text = db.Dr[4].ToString();
        }
    }
}
