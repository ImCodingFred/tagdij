namespace tagdij
{
    partial class adatrogzit
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
            szulev = new DataGridViewTextBoxColumn();
            irszam = new DataGridViewTextBoxColumn();
            orsz = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tb_azon = new TextBox();
            label2 = new Label();
            tb_nev = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tb_irszam = new TextBox();
            label5 = new Label();
            tb_orsz = new TextBox();
            groupBox1 = new GroupBox();
            rb_mod = new RadioButton();
            rb_uj = new RadioButton();
            btn_ment = new Button();
            btn_elvet = new Button();
            tb_szulev = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGV.Columns.AddRange(new DataGridViewColumn[] { azon, nev, szulev, irszam, orsz });
            DGV.Location = new Point(12, 12);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.Size = new Size(398, 341);
            DGV.TabIndex = 0;
            DGV.CellClick += DGV_CellClick;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 19);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Azonosító";
            // 
            // tb_azon
            // 
            tb_azon.Location = new Point(75, 16);
            tb_azon.Name = "tb_azon";
            tb_azon.Size = new Size(100, 23);
            tb_azon.TabIndex = 2;
            tb_azon.TextChanged += tb_azon_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 48);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "Név";
            // 
            // tb_nev
            // 
            tb_nev.Location = new Point(53, 45);
            tb_nev.Name = "tb_nev";
            tb_nev.Size = new Size(100, 23);
            tb_nev.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 80);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 1;
            label3.Text = "Születési év";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 106);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 1;
            label4.Text = "Irányítószám";
            // 
            // tb_irszam
            // 
            tb_irszam.Location = new Point(92, 103);
            tb_irszam.Name = "tb_irszam";
            tb_irszam.Size = new Size(100, 23);
            tb_irszam.TabIndex = 2;
            tb_irszam.TextChanged += tb_irszam_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 135);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 1;
            label5.Text = "Ország";
            // 
            // tb_orsz
            // 
            tb_orsz.CharacterCasing = CharacterCasing.Upper;
            tb_orsz.Location = new Point(58, 132);
            tb_orsz.Name = "tb_orsz";
            tb_orsz.Size = new Size(100, 23);
            tb_orsz.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_mod);
            groupBox1.Controls.Add(rb_uj);
            groupBox1.Location = new Point(423, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(183, 87);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müvelet";
            // 
            // rb_mod
            // 
            rb_mod.AutoSize = true;
            rb_mod.Location = new Point(15, 53);
            rb_mod.Name = "rb_mod";
            rb_mod.Size = new Size(80, 19);
            rb_mod.TabIndex = 0;
            rb_mod.Text = "Módosítás";
            rb_mod.UseVisualStyleBackColor = true;
            // 
            // rb_uj
            // 
            rb_uj.AutoSize = true;
            rb_uj.Location = new Point(15, 28);
            rb_uj.Name = "rb_uj";
            rb_uj.Size = new Size(76, 19);
            rb_uj.TabIndex = 0;
            rb_uj.Text = "új felvétel";
            rb_uj.UseVisualStyleBackColor = true;
            rb_uj.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btn_ment
            // 
            btn_ment.Location = new Point(427, 274);
            btn_ment.Name = "btn_ment";
            btn_ment.Size = new Size(100, 79);
            btn_ment.TabIndex = 5;
            btn_ment.Text = "Mentés";
            btn_ment.UseVisualStyleBackColor = true;
            btn_ment.Click += btn_ment_Click;
            // 
            // btn_elvet
            // 
            btn_elvet.Location = new Point(542, 274);
            btn_elvet.Name = "btn_elvet";
            btn_elvet.Size = new Size(100, 79);
            btn_elvet.TabIndex = 5;
            btn_elvet.Text = "Elvetés";
            btn_elvet.UseVisualStyleBackColor = true;
            btn_elvet.Click += btn_elvet_Click;
            // 
            // tb_szulev
            // 
            tb_szulev.Location = new Point(82, 77);
            tb_szulev.Name = "tb_szulev";
            tb_szulev.Size = new Size(100, 23);
            tb_szulev.TabIndex = 6;
            tb_szulev.TextChanged += tb_szulev_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(tb_szulev);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tb_azon);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tb_nev);
            panel1.Controls.Add(tb_orsz);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tb_irszam);
            panel1.Location = new Point(423, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 168);
            panel1.TabIndex = 7;
            // 
            // adatrogzit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 365);
            Controls.Add(panel1);
            Controls.Add(btn_elvet);
            Controls.Add(btn_ment);
            Controls.Add(groupBox1);
            Controls.Add(DGV);
            Name = "adatrogzit";
            Text = "adatrogzit";
            Load += adatrogzit_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV;
        private Label label1;
        private TextBox tb_azon;
        private Label label2;
        private TextBox tb_nev;
        private Label label3;
        private Label label4;
        private TextBox tb_irszam;
        private Label label5;
        private TextBox tb_orsz;
        private GroupBox groupBox1;
        private RadioButton rb_mod;
        private RadioButton rb_uj;
        private Button btn_ment;
        private Button btn_elvet;
        private DataGridViewTextBoxColumn azon;
        private DataGridViewTextBoxColumn nev;
        private DataGridViewTextBoxColumn szulev;
        private DataGridViewTextBoxColumn irszam;
        private DataGridViewTextBoxColumn orsz;
        private TextBox tb_szulev;
        private Panel panel1;
    }
}