namespace tagdij
{
    partial class lekerdezes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGV = new DataGridView();
            azon = new DataGridViewTextBoxColumn();
            nev = new DataGridViewTextBoxColumn();
            befizszam = new DataGridViewTextBoxColumn();
            osszbefiz = new DataGridViewTextBoxColumn();
            utbefiz = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            l_orsz = new Label();
            label5 = new Label();
            l_irszam = new Label();
            label4 = new Label();
            l_szulev = new Label();
            l_nev = new Label();
            label3 = new Label();
            l_azon = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Columns.AddRange(new DataGridViewColumn[] { azon, nev, befizszam, osszbefiz, utbefiz });
            DGV.Location = new Point(12, 12);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.Size = new Size(570, 426);
            DGV.TabIndex = 0;
            DGV.CellClick += DGV_CellClick;
            // 
            // azon
            // 
            azon.HeaderText = "Ügyfél azonosító";
            azon.Name = "azon";
            azon.ReadOnly = true;
            // 
            // nev
            // 
            nev.HeaderText = "Név";
            nev.Name = "nev";
            nev.ReadOnly = true;
            // 
            // befizszam
            // 
            befizszam.HeaderText = "Befizetések száma";
            befizszam.Name = "befizszam";
            befizszam.ReadOnly = true;
            // 
            // osszbefiz
            // 
            osszbefiz.HeaderText = "Összes befizetés";
            osszbefiz.Name = "osszbefiz";
            osszbefiz.ReadOnly = true;
            // 
            // utbefiz
            // 
            utbefiz.HeaderText = "legutolsó befizetés ideje";
            utbefiz.Name = "utbefiz";
            utbefiz.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(l_orsz);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(l_irszam);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(l_szulev);
            panel1.Controls.Add(l_nev);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(l_azon);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(588, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 194);
            panel1.TabIndex = 1;
            // 
            // l_orsz
            // 
            l_orsz.AutoSize = true;
            l_orsz.Location = new Point(133, 148);
            l_orsz.Name = "l_orsz";
            l_orsz.Size = new Size(38, 15);
            l_orsz.TabIndex = 0;
            l_orsz.Text = "label1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 148);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 0;
            label5.Text = "Országkód";
            // 
            // l_irszam
            // 
            l_irszam.AutoSize = true;
            l_irszam.Location = new Point(133, 115);
            l_irszam.Name = "l_irszam";
            l_irszam.Size = new Size(38, 15);
            l_irszam.TabIndex = 0;
            l_irszam.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 115);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 0;
            label4.Text = "Irányítószám";
            // 
            // l_szulev
            // 
            l_szulev.AutoSize = true;
            l_szulev.Location = new Point(133, 84);
            l_szulev.Name = "l_szulev";
            l_szulev.Size = new Size(38, 15);
            l_szulev.TabIndex = 0;
            l_szulev.Text = "label1";
            // 
            // l_nev
            // 
            l_nev.AutoSize = true;
            l_nev.Location = new Point(133, 53);
            l_nev.Name = "l_nev";
            l_nev.Size = new Size(38, 15);
            l_nev.TabIndex = 0;
            l_nev.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 84);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 0;
            label3.Text = "Születési évszám";
            // 
            // l_azon
            // 
            l_azon.AutoSize = true;
            l_azon.Location = new Point(133, 23);
            l_azon.Name = "l_azon";
            l_azon.Size = new Size(38, 15);
            l_azon.TabIndex = 0;
            l_azon.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 53);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 0;
            label2.Text = "Név";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 23);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Azonosító";
            // 
            // lekerdezes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 450);
            Controls.Add(panel1);
            Controls.Add(DGV);
            Name = "lekerdezes";
            Text = "lekerdezes";
            Load += lekerdezes_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV;
        private DataGridViewTextBoxColumn azon;
        private DataGridViewTextBoxColumn nev;
        private DataGridViewTextBoxColumn befizszam;
        private DataGridViewTextBoxColumn osszbefiz;
        private DataGridViewTextBoxColumn utbefiz;
        private Panel panel1;
        private Label l_orsz;
        private Label label5;
        private Label l_irszam;
        private Label label4;
        private Label l_szulev;
        private Label l_nev;
        private Label label3;
        private Label l_azon;
        private Label label2;
        private Label label1;
    }
}