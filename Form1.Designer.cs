namespace Linespectra
{
    partial class Spektrallinien
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.höhereQualitätSpeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importNISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spektrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontinuierlichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heliumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nISTDatenbankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(11, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.spektrenToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.höhereQualitätSpeichernToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.importNISTToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.importToolStripMenuItem.Text = "Import...";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // höhereQualitätSpeichernToolStripMenuItem
            // 
            this.höhereQualitätSpeichernToolStripMenuItem.Name = "höhereQualitätSpeichernToolStripMenuItem";
            this.höhereQualitätSpeichernToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.höhereQualitätSpeichernToolStripMenuItem.Text = "Importieren und speichern (HQ)...";
            this.höhereQualitätSpeichernToolStripMenuItem.Click += new System.EventHandler(this.höhereQualitätSpeichernToolStripMenuItem_Click);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.speichernToolStripMenuItem.Text = "Speichern...";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // importNISTToolStripMenuItem
            // 
            this.importNISTToolStripMenuItem.Name = "importNISTToolStripMenuItem";
            this.importNISTToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.importNISTToolStripMenuItem.Text = "Import NIST...";
            this.importNISTToolStripMenuItem.Click += new System.EventHandler(this.importNISTToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // spektrenToolStripMenuItem
            // 
            this.spektrenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kontinuierlichToolStripMenuItem,
            this.heliumToolStripMenuItem,
            this.nISTDatenbankToolStripMenuItem});
            this.spektrenToolStripMenuItem.Name = "spektrenToolStripMenuItem";
            this.spektrenToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.spektrenToolStripMenuItem.Text = "Spektren";
            // 
            // kontinuierlichToolStripMenuItem
            // 
            this.kontinuierlichToolStripMenuItem.Name = "kontinuierlichToolStripMenuItem";
            this.kontinuierlichToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.kontinuierlichToolStripMenuItem.Text = "Kontinuierlich";
            this.kontinuierlichToolStripMenuItem.Click += new System.EventHandler(this.kontinuierlichToolStripMenuItem_Click);
            // 
            // heliumToolStripMenuItem
            // 
            this.heliumToolStripMenuItem.Name = "heliumToolStripMenuItem";
            this.heliumToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.heliumToolStripMenuItem.Text = "Helium";
            this.heliumToolStripMenuItem.Click += new System.EventHandler(this.heliumToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.überToolStripMenuItem.Text = "Über...";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // nISTDatenbankToolStripMenuItem
            // 
            this.nISTDatenbankToolStripMenuItem.Name = "nISTDatenbankToolStripMenuItem";
            this.nISTDatenbankToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.nISTDatenbankToolStripMenuItem.Text = "NIST Datenbank...";
            this.nISTDatenbankToolStripMenuItem.Click += new System.EventHandler(this.nISTDatenbankToolStripMenuItem_Click);
            // 
            // Spektrallinien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 158);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Spektrallinien";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Linespectra v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spektrenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontinuierlichToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heliumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem höhereQualitätSpeichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importNISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nISTDatenbankToolStripMenuItem;
    }
}

