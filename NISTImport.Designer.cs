namespace Linespectra
{
    partial class NISTImport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NISTImport));
            this.txtPfadOpen = new System.Windows.Forms.TextBox();
            this.cmdPfad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbIntens = new System.Windows.Forms.CheckBox();
            this.cmdEinlesen = new System.Windows.Forms.Button();
            this.cmdSpeichern = new System.Windows.Forms.Button();
            this.cmdBeenden = new System.Windows.Forms.Button();
            this.lblVorschau = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkDatenbank = new System.Windows.Forms.CheckBox();
            this.cmbElement = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPfadOpen
            // 
            this.txtPfadOpen.Location = new System.Drawing.Point(12, 12);
            this.txtPfadOpen.Name = "txtPfadOpen";
            this.txtPfadOpen.Size = new System.Drawing.Size(342, 20);
            this.txtPfadOpen.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtPfadOpen, "Pfad zu einer lokalen Textdatei, die von der NIST-Website generiert wurde.");
            // 
            // cmdPfad
            // 
            this.cmdPfad.Location = new System.Drawing.Point(360, 10);
            this.cmdPfad.Name = "cmdPfad";
            this.cmdPfad.Size = new System.Drawing.Size(47, 23);
            this.cmdPfad.TabIndex = 1;
            this.cmdPfad.Text = "...";
            this.cmdPfad.UseVisualStyleBackColor = true;
            this.cmdPfad.Click += new System.EventHandler(this.cmdPfad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbIntens);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optionen";
            // 
            // ckbIntens
            // 
            this.ckbIntens.AutoSize = true;
            this.ckbIntens.Location = new System.Drawing.Point(6, 19);
            this.ckbIntens.Name = "ckbIntens";
            this.ckbIntens.Size = new System.Drawing.Size(91, 17);
            this.ckbIntens.TabIndex = 0;
            this.ckbIntens.Text = "Rel. Intensität";
            this.toolTip1.SetToolTip(this.ckbIntens, resources.GetString("ckbIntens.ToolTip"));
            this.ckbIntens.UseVisualStyleBackColor = true;
            // 
            // cmdEinlesen
            // 
            this.cmdEinlesen.Location = new System.Drawing.Point(218, 115);
            this.cmdEinlesen.Name = "cmdEinlesen";
            this.cmdEinlesen.Size = new System.Drawing.Size(75, 23);
            this.cmdEinlesen.TabIndex = 3;
            this.cmdEinlesen.Text = "Einlesen...";
            this.cmdEinlesen.UseVisualStyleBackColor = true;
            this.cmdEinlesen.Click += new System.EventHandler(this.cmdEinlesen_Click);
            // 
            // cmdSpeichern
            // 
            this.cmdSpeichern.Location = new System.Drawing.Point(198, 351);
            this.cmdSpeichern.Name = "cmdSpeichern";
            this.cmdSpeichern.Size = new System.Drawing.Size(75, 23);
            this.cmdSpeichern.TabIndex = 4;
            this.cmdSpeichern.Text = "Speichern...";
            this.cmdSpeichern.UseVisualStyleBackColor = true;
            this.cmdSpeichern.Click += new System.EventHandler(this.cmdSpeichern_Click);
            // 
            // cmdBeenden
            // 
            this.cmdBeenden.Location = new System.Drawing.Point(300, 351);
            this.cmdBeenden.Name = "cmdBeenden";
            this.cmdBeenden.Size = new System.Drawing.Size(75, 23);
            this.cmdBeenden.TabIndex = 5;
            this.cmdBeenden.Text = "Beenden";
            this.cmdBeenden.UseVisualStyleBackColor = true;
            this.cmdBeenden.Click += new System.EventHandler(this.cmdBeenden_Click);
            // 
            // lblVorschau
            // 
            this.lblVorschau.AutoSize = true;
            this.lblVorschau.Location = new System.Drawing.Point(12, 141);
            this.lblVorschau.Name = "lblVorschau";
            this.lblVorschau.Size = new System.Drawing.Size(55, 13);
            this.lblVorschau.TabIndex = 7;
            this.lblVorschau.Text = "Vorschau:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 168);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chkDatenbank
            // 
            this.chkDatenbank.AutoSize = true;
            this.chkDatenbank.Location = new System.Drawing.Point(218, 92);
            this.chkDatenbank.Name = "chkDatenbank";
            this.chkDatenbank.Size = new System.Drawing.Size(134, 17);
            this.chkDatenbank.TabIndex = 9;
            this.chkDatenbank.Text = "Aus lokaler Datenbank";
            this.toolTip1.SetToolTip(this.chkDatenbank, "Wenn aktiviert, können NIST-Spektren verschiedener Elemente ausgewählt werden, so" +
        "fern diese im \r\nData-Verzeichnis der Anwendung vorhanden sind.");
            this.chkDatenbank.UseVisualStyleBackColor = true;
            this.chkDatenbank.CheckedChanged += new System.EventHandler(this.chkDatenbank_CheckedChanged);
            // 
            // cmbElement
            // 
            this.cmbElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbElement.Enabled = false;
            this.cmbElement.FormattingEnabled = true;
            this.cmbElement.Items.AddRange(new object[] {
            "H",
            "He",
            "Li",
            "Be",
            "B",
            "C",
            "N",
            "O",
            "F",
            "Ne",
            "Na",
            "Mg",
            "Al",
            "Si",
            "P",
            "S",
            "Cl",
            "Ar",
            "K",
            "Ca",
            "Sc",
            "Ti",
            "V",
            "Cr",
            "Mn",
            "Fe",
            "Co",
            "Ni",
            "Cu",
            "Zn",
            "Ga",
            "Ge",
            "As",
            "Se",
            "Br",
            "Kr",
            "Rb"});
            this.cmbElement.Location = new System.Drawing.Point(360, 90);
            this.cmbElement.Name = "cmbElement";
            this.cmbElement.Size = new System.Drawing.Size(121, 21);
            this.cmbElement.TabIndex = 10;
            // 
            // NISTImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 386);
            this.Controls.Add(this.cmbElement);
            this.Controls.Add(this.chkDatenbank);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblVorschau);
            this.Controls.Add(this.cmdBeenden);
            this.Controls.Add(this.cmdSpeichern);
            this.Controls.Add(this.cmdEinlesen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdPfad);
            this.Controls.Add(this.txtPfadOpen);
            this.Name = "NISTImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NIST-Import";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPfadOpen;
        private System.Windows.Forms.Button cmdPfad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdEinlesen;
        private System.Windows.Forms.Button cmdSpeichern;
        private System.Windows.Forms.Button cmdBeenden;
        private System.Windows.Forms.Label lblVorschau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkDatenbank;
        private System.Windows.Forms.ComboBox cmbElement;
        private System.Windows.Forms.CheckBox ckbIntens;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}