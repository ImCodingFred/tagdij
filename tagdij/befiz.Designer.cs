namespace tagdij
{
    partial class befiz
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
            textBox1 = new TextBox();
            DGV = new DataGridView();
            azon = new DataGridViewTextBoxColumn();
            nev = new DataGridViewTextBoxColumn();
            szulev = new DataGridViewTextBoxColumn();
            irszam = new DataGridViewTextBoxColumn();
            orsz = new DataGridViewTextBoxColumn();
            tb_azon = new TextBox();
            tb_osszeg = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            btn_mentes = new Button();
            btn_elvet = new Button();
            l_nev = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGV.Columns.AddRange(new DataGridViewColumn[] { azon, nev, szulev, irszam, orsz });
            DGV.Location = new Point(12, 41);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.Size = new Size(398, 341);
            DGV.TabIndex = 2;
            // 
            // azon
            // 
            azon.HeaderText = "Azonosító";
            azon.Name = "azon";
            azon.ReadOnly = true;
            // 
            // nev
            // 
            nev.HeaderText = "Név";
            nev.Name = "nev";
            nev.ReadOnly = true;
            // 
            // szulev
            // 
            szulev.HeaderText = "Születési év";
            szulev.Name = "szulev";
            szulev.ReadOnly = true;
            // 
            // irszam
            // 
            irszam.HeaderText = "Irányító szám";
            irszam.Name = "irszam";
            irszam.ReadOnly = true;
            // 
            // orsz
            // 
            orsz.HeaderText = "Ország";
            orsz.Name = "orsz";
            orsz.ReadOnly = true;
            // 
            // tb_azon
            // 
            tb_azon.Location = new Point(79, 26);
            tb_azon.Name = "tb_azon";
            tb_azon.Size = new Size(94, 23);
            tb_azon.TabIndex = 3;
            tb_azon.TextChanged += tb_azon_TextChanged;
            // 
            // tb_osszeg
            // 
            tb_osszeg.Location = new Point(79, 126);
            tb_osszeg.Name = "tb_osszeg";
            tb_osszeg.Size = new Size(94, 23);
            tb_osszeg.TabIndex = 3;
            tb_osszeg.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 29);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Azonosító";
            label1.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(79, 83);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 89);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Dátum";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 129);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 4;
            label3.Text = "Összeg";
            label3.Click += label1_Click;
            // 
            // btn_mentes
            // 
            btn_mentes.Location = new Point(427, 277);
            btn_mentes.Name = "btn_mentes";
            btn_mentes.Size = new Size(115, 62);
            btn_mentes.TabIndex = 6;
            btn_mentes.Text = "Mentés";
            btn_mentes.UseVisualStyleBackColor = true;
            btn_mentes.Click += btn_mentes_Click;
            // 
            // btn_elvet
            // 
            btn_elvet.Location = new Point(548, 277);
            btn_elvet.Name = "btn_elvet";
            btn_elvet.Size = new Size(115, 62);
            btn_elvet.TabIndex = 6;
            btn_elvet.Text = "Elvetés";
            btn_elvet.UseVisualStyleBackColor = true;
            // 
            // l_nev
            // 
            l_nev.AutoSize = true;
            l_nev.Location = new Point(192, 29);
            l_nev.Name = "l_nev";
            l_nev.Size = new Size(38, 15);
            l_nev.TabIndex = 7;
            l_nev.Text = "label4";
            l_nev.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(l_nev);
            panel1.Controls.Add(tb_osszeg);
            panel1.Controls.Add(tb_azon);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(427, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 181);
            panel1.TabIndex = 8;
            // 
            // befiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 410);
            Controls.Add(panel1);
            Controls.Add(btn_elvet);
            Controls.Add(btn_mentes);
            Controls.Add(DGV);
            Controls.Add(textBox1);
            Name = "befiz";
            Text = "befiz";
            Load += befiz_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private DataGridView DGV;
        private DataGridViewTextBoxColumn azon;
        private DataGridViewTextBoxColumn nev;
        private DataGridViewTextBoxColumn szulev;
        private DataGridViewTextBoxColumn irszam;
        private DataGridViewTextBoxColumn orsz;
        private TextBox tb_azon;
        private TextBox tb_osszeg;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private Button btn_mentes;
        private Button btn_elvet;
        private Label l_nev;
        private Panel panel1;
    }
}