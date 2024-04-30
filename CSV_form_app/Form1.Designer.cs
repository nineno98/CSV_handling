
namespace CSV_form_app
{
    partial class Form1
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
            this.dolgozok_listbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nev_inp = new System.Windows.Forms.TextBox();
            this.reszleg = new System.Windows.Forms.TextBox();
            this.nem_valaszt = new System.Windows.Forms.GroupBox();
            this.ferfi = new System.Windows.Forms.RadioButton();
            this.no = new System.Windows.Forms.RadioButton();
            this.belepes_eve = new System.Windows.Forms.NumericUpDown();
            this.berezes = new System.Windows.Forms.TextBox();
            this.hozzaadas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rekordszam = new System.Windows.Forms.Label();
            this.nem_valaszt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.belepes_eve)).BeginInit();
            this.SuspendLayout();
            // 
            // dolgozok_listbox
            // 
            this.dolgozok_listbox.FormattingEnabled = true;
            this.dolgozok_listbox.Location = new System.Drawing.Point(17, 18);
            this.dolgozok_listbox.Name = "dolgozok_listbox";
            this.dolgozok_listbox.Size = new System.Drawing.Size(337, 420);
            this.dolgozok_listbox.TabIndex = 0;
            this.dolgozok_listbox.SelectedIndexChanged += new System.EventHandler(this.dolgozok_listbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Új dolgozó felvétele";
            // 
            // nev_inp
            // 
            this.nev_inp.Location = new System.Drawing.Point(492, 49);
            this.nev_inp.Name = "nev_inp";
            this.nev_inp.Size = new System.Drawing.Size(119, 20);
            this.nev_inp.TabIndex = 2;
            // 
            // reszleg
            // 
            this.reszleg.Location = new System.Drawing.Point(492, 156);
            this.reszleg.Name = "reszleg";
            this.reszleg.Size = new System.Drawing.Size(118, 20);
            this.reszleg.TabIndex = 3;
            // 
            // nem_valaszt
            // 
            this.nem_valaszt.Controls.Add(this.no);
            this.nem_valaszt.Controls.Add(this.ferfi);
            this.nem_valaszt.Location = new System.Drawing.Point(492, 78);
            this.nem_valaszt.Name = "nem_valaszt";
            this.nem_valaszt.Size = new System.Drawing.Size(118, 72);
            this.nem_valaszt.TabIndex = 4;
            this.nem_valaszt.TabStop = false;
            this.nem_valaszt.Text = "Nem kiválasztása";
            // 
            // ferfi
            // 
            this.ferfi.AutoSize = true;
            this.ferfi.Location = new System.Drawing.Point(16, 19);
            this.ferfi.Name = "ferfi";
            this.ferfi.Size = new System.Drawing.Size(45, 17);
            this.ferfi.TabIndex = 0;
            this.ferfi.TabStop = true;
            this.ferfi.Text = "Férfi";
            this.ferfi.UseVisualStyleBackColor = true;
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(16, 42);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(39, 17);
            this.no.TabIndex = 1;
            this.no.TabStop = true;
            this.no.Text = "Nő";
            this.no.UseVisualStyleBackColor = true;
            // 
            // belepes_eve
            // 
            this.belepes_eve.Location = new System.Drawing.Point(493, 189);
            this.belepes_eve.Maximum = new decimal(new int[] {
            2040,
            0,
            0,
            0});
            this.belepes_eve.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.belepes_eve.Name = "belepes_eve";
            this.belepes_eve.Size = new System.Drawing.Size(116, 20);
            this.belepes_eve.TabIndex = 5;
            this.belepes_eve.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // berezes
            // 
            this.berezes.Location = new System.Drawing.Point(492, 222);
            this.berezes.Name = "berezes";
            this.berezes.Size = new System.Drawing.Size(116, 20);
            this.berezes.TabIndex = 6;
            // 
            // hozzaadas
            // 
            this.hozzaadas.Location = new System.Drawing.Point(492, 263);
            this.hozzaadas.Name = "hozzaadas";
            this.hozzaadas.Size = new System.Drawing.Size(115, 33);
            this.hozzaadas.TabIndex = 7;
            this.hozzaadas.Text = "Hozzáadás";
            this.hozzaadas.UseVisualStyleBackColor = true;
            this.hozzaadas.Click += new System.EventHandler(this.hozzaadas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Név";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Részleg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bérezés";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Belépés éve";
            // 
            // rekordszam
            // 
            this.rekordszam.AutoSize = true;
            this.rekordszam.Location = new System.Drawing.Point(372, 405);
            this.rekordszam.Name = "rekordszam";
            this.rekordszam.Size = new System.Drawing.Size(0, 13);
            this.rekordszam.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rekordszam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hozzaadas);
            this.Controls.Add(this.berezes);
            this.Controls.Add(this.belepes_eve);
            this.Controls.Add(this.nem_valaszt);
            this.Controls.Add(this.reszleg);
            this.Controls.Add(this.nev_inp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dolgozok_listbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.nem_valaszt.ResumeLayout(false);
            this.nem_valaszt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.belepes_eve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dolgozok_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nev_inp;
        private System.Windows.Forms.TextBox reszleg;
        private System.Windows.Forms.GroupBox nem_valaszt;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.RadioButton ferfi;
        private System.Windows.Forms.NumericUpDown belepes_eve;
        private System.Windows.Forms.TextBox berezes;
        private System.Windows.Forms.Button hozzaadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label rekordszam;
    }
}

