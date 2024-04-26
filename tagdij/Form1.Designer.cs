namespace tagdij
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            ügyfélAdatokRögzítéseToolStripMenuItem = new ToolStripMenuItem();
            befizetésToolStripMenuItem = new ToolStripMenuItem();
            lekérdezésToolStripMenuItem = new ToolStripMenuItem();
            kilépésToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ügyfélAdatokRögzítéseToolStripMenuItem, befizetésToolStripMenuItem, lekérdezésToolStripMenuItem, kilépésToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(417, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ügyfélAdatokRögzítéseToolStripMenuItem
            // 
            ügyfélAdatokRögzítéseToolStripMenuItem.Name = "ügyfélAdatokRögzítéseToolStripMenuItem";
            ügyfélAdatokRögzítéseToolStripMenuItem.Size = new Size(142, 20);
            ügyfélAdatokRögzítéseToolStripMenuItem.Text = "Ügyfél adatok rögzítése";
            ügyfélAdatokRögzítéseToolStripMenuItem.Click += ügyfélAdatokRögzítéseToolStripMenuItem_Click;
            // 
            // befizetésToolStripMenuItem
            // 
            befizetésToolStripMenuItem.Name = "befizetésToolStripMenuItem";
            befizetésToolStripMenuItem.Size = new Size(65, 20);
            befizetésToolStripMenuItem.Text = "Befizetés";
            befizetésToolStripMenuItem.Click += befizetésToolStripMenuItem_Click;
            // 
            // lekérdezésToolStripMenuItem
            // 
            lekérdezésToolStripMenuItem.Name = "lekérdezésToolStripMenuItem";
            lekérdezésToolStripMenuItem.Size = new Size(76, 20);
            lekérdezésToolStripMenuItem.Text = "Lekérdezés";
            lekérdezésToolStripMenuItem.Click += lekérdezésToolStripMenuItem_Click;
            // 
            // kilépésToolStripMenuItem
            // 
            kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            kilépésToolStripMenuItem.Size = new Size(56, 20);
            kilépésToolStripMenuItem.Text = "Kilépés";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 34);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Főmenü";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ügyfélAdatokRögzítéseToolStripMenuItem;
        private ToolStripMenuItem befizetésToolStripMenuItem;
        private ToolStripMenuItem lekérdezésToolStripMenuItem;
        private ToolStripMenuItem kilépésToolStripMenuItem;
    }
}
