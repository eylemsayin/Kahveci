namespace RabiaKandemir_EylemSayin_UygulamaSinavi
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.flpEkstralar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSiparisTamamla = new System.Windows.Forms.Button();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrAdetSayisi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoyut = new System.Windows.Forms.GroupBox();
            this.rdoVenti = new System.Windows.Forms.RadioButton();
            this.rdoGrande = new System.Windows.Forms.RadioButton();
            this.rdoTall = new System.Windows.Forms.RadioButton();
            this.cmbIcecekler = new System.Windows.Forms.ComboBox();
            this.pcPicture = new System.Windows.Forms.PictureBox();
            this.prb4 = new System.Windows.Forms.ProgressBar();
            this.txtBarista4 = new System.Windows.Forms.TextBox();
            this.prb3 = new System.Windows.Forms.ProgressBar();
            this.txtBarista3 = new System.Windows.Forms.TextBox();
            this.prb2 = new System.Windows.Forms.ProgressBar();
            this.txtBarista2 = new System.Windows.Forms.TextBox();
            this.prb1 = new System.Windows.Forms.ProgressBar();
            this.txtBarista1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSiparişEkle = new System.Windows.Forms.Button();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.tmr2 = new System.Windows.Forms.Timer(this.components);
            this.tmr3 = new System.Windows.Forms.Timer(this.components);
            this.tmr4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdetSayisi)).BeginInit();
            this.grpBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "SİPARİŞLER";
            // 
            // flpEkstralar
            // 
            this.flpEkstralar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpEkstralar.Location = new System.Drawing.Point(15, 405);
            this.flpEkstralar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flpEkstralar.Name = "flpEkstralar";
            this.flpEkstralar.Size = new System.Drawing.Size(430, 182);
            this.flpEkstralar.TabIndex = 37;
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.BackColor = System.Drawing.Color.Silver;
            this.btnSiparisTamamla.Location = new System.Drawing.Point(936, 277);
            this.btnSiparisTamamla.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(183, 47);
            this.btnSiparisTamamla.TabIndex = 36;
            this.btnSiparisTamamla.Text = "SİPARİŞİ TAMAMLA";
            this.btnSiparisTamamla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSiparisTamamla.UseVisualStyleBackColor = false;
            this.btnSiparisTamamla.Click += new System.EventHandler(this.btnSiparisTamamla_Click);
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(702, 281);
            this.lblToplamTutar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(39, 13);
            this.lblToplamTutar.TabIndex = 35;
            this.lblToplamTutar.Text = "0,00₺";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "TOPLAM TUTAR:";
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.HorizontalScrollbar = true;
            this.lstSiparisler.Location = new System.Drawing.Point(534, 22);
            this.lstSiparisler.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.ScrollAlwaysVisible = true;
            this.lstSiparisler.Size = new System.Drawing.Size(585, 238);
            this.lstSiparisler.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 372);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "EKSTRA MALZEMELER";
            // 
            // nmrAdetSayisi
            // 
            this.nmrAdetSayisi.Location = new System.Drawing.Point(236, 342);
            this.nmrAdetSayisi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nmrAdetSayisi.Name = "nmrAdetSayisi";
            this.nmrAdetSayisi.Size = new System.Drawing.Size(210, 20);
            this.nmrAdetSayisi.TabIndex = 31;
            this.nmrAdetSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 348);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "ADET";
            // 
            // grpBoyut
            // 
            this.grpBoyut.Controls.Add(this.rdoVenti);
            this.grpBoyut.Controls.Add(this.rdoGrande);
            this.grpBoyut.Controls.Add(this.rdoTall);
            this.grpBoyut.Location = new System.Drawing.Point(15, 277);
            this.grpBoyut.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grpBoyut.Name = "grpBoyut";
            this.grpBoyut.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grpBoyut.Size = new System.Drawing.Size(430, 57);
            this.grpBoyut.TabIndex = 29;
            this.grpBoyut.TabStop = false;
            this.grpBoyut.Text = "Boyutlar";
            // 
            // rdoVenti
            // 
            this.rdoVenti.AutoSize = true;
            this.rdoVenti.Location = new System.Drawing.Point(253, 24);
            this.rdoVenti.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdoVenti.Name = "rdoVenti";
            this.rdoVenti.Size = new System.Drawing.Size(54, 17);
            this.rdoVenti.TabIndex = 2;
            this.rdoVenti.TabStop = true;
            this.rdoVenti.Text = "Venti";
            this.rdoVenti.UseVisualStyleBackColor = true;
            // 
            // rdoGrande
            // 
            this.rdoGrande.AutoSize = true;
            this.rdoGrande.Location = new System.Drawing.Point(124, 24);
            this.rdoGrande.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdoGrande.Name = "rdoGrande";
            this.rdoGrande.Size = new System.Drawing.Size(66, 17);
            this.rdoGrande.TabIndex = 1;
            this.rdoGrande.TabStop = true;
            this.rdoGrande.Text = "Grande";
            this.rdoGrande.UseVisualStyleBackColor = true;
            // 
            // rdoTall
            // 
            this.rdoTall.AutoSize = true;
            this.rdoTall.Location = new System.Drawing.Point(10, 23);
            this.rdoTall.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdoTall.Name = "rdoTall";
            this.rdoTall.Size = new System.Drawing.Size(46, 17);
            this.rdoTall.TabIndex = 0;
            this.rdoTall.TabStop = true;
            this.rdoTall.Text = "Tall";
            this.rdoTall.UseVisualStyleBackColor = true;
            // 
            // cmbIcecekler
            // 
            this.cmbIcecekler.FormattingEnabled = true;
            this.cmbIcecekler.Location = new System.Drawing.Point(15, 240);
            this.cmbIcecekler.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbIcecekler.Name = "cmbIcecekler";
            this.cmbIcecekler.Size = new System.Drawing.Size(408, 21);
            this.cmbIcecekler.TabIndex = 28;
            // 
            // pcPicture
            // 
            this.pcPicture.Image = global::RabiaKandemir_EylemSayin_UygulamaSinavi.Properties.Resources.WhatsApp_Image_2022_12_28_at_13_48_46;
            this.pcPicture.Location = new System.Drawing.Point(15, 13);
            this.pcPicture.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pcPicture.Name = "pcPicture";
            this.pcPicture.Size = new System.Drawing.Size(275, 183);
            this.pcPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcPicture.TabIndex = 27;
            this.pcPicture.TabStop = false;
            // 
            // prb4
            // 
            this.prb4.Location = new System.Drawing.Point(639, 580);
            this.prb4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prb4.Name = "prb4";
            this.prb4.Size = new System.Drawing.Size(484, 23);
            this.prb4.TabIndex = 50;
            // 
            // txtBarista4
            // 
            this.txtBarista4.Location = new System.Drawing.Point(639, 551);
            this.txtBarista4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBarista4.Name = "txtBarista4";
            this.txtBarista4.Size = new System.Drawing.Size(484, 20);
            this.txtBarista4.TabIndex = 49;
            // 
            // prb3
            // 
            this.prb3.Location = new System.Drawing.Point(639, 504);
            this.prb3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prb3.Name = "prb3";
            this.prb3.Size = new System.Drawing.Size(484, 23);
            this.prb3.TabIndex = 48;
            // 
            // txtBarista3
            // 
            this.txtBarista3.Location = new System.Drawing.Point(639, 475);
            this.txtBarista3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBarista3.Name = "txtBarista3";
            this.txtBarista3.Size = new System.Drawing.Size(484, 20);
            this.txtBarista3.TabIndex = 47;
            // 
            // prb2
            // 
            this.prb2.Location = new System.Drawing.Point(639, 432);
            this.prb2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prb2.Name = "prb2";
            this.prb2.Size = new System.Drawing.Size(484, 23);
            this.prb2.TabIndex = 46;
            // 
            // txtBarista2
            // 
            this.txtBarista2.Location = new System.Drawing.Point(639, 402);
            this.txtBarista2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBarista2.Name = "txtBarista2";
            this.txtBarista2.Size = new System.Drawing.Size(484, 20);
            this.txtBarista2.TabIndex = 45;
            // 
            // prb1
            // 
            this.prb1.Location = new System.Drawing.Point(639, 367);
            this.prb1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prb1.Name = "prb1";
            this.prb1.Size = new System.Drawing.Size(484, 23);
            this.prb1.TabIndex = 44;
            // 
            // txtBarista1
            // 
            this.txtBarista1.Location = new System.Drawing.Point(639, 338);
            this.txtBarista1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBarista1.Name = "txtBarista1";
            this.txtBarista1.Size = new System.Drawing.Size(484, 20);
            this.txtBarista1.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(531, 554);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "BARİSTA 4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 475);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "BARİSTA 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 402);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "BARİSTA 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 342);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "BARİSTA 1";
            // 
            // btnSiparişEkle
            // 
            this.btnSiparişEkle.BackColor = System.Drawing.Color.Silver;
            this.btnSiparişEkle.Location = new System.Drawing.Point(240, 594);
            this.btnSiparişEkle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSiparişEkle.Name = "btnSiparişEkle";
            this.btnSiparişEkle.Size = new System.Drawing.Size(205, 55);
            this.btnSiparişEkle.TabIndex = 51;
            this.btnSiparişEkle.Text = "SİPARİŞ EKLE";
            this.btnSiparişEkle.UseVisualStyleBackColor = false;
            this.btnSiparişEkle.Click += new System.EventHandler(this.btnSiparişEkle_Click);
            // 
            // tmr1
            // 
            this.tmr1.Interval = 1500;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // tmr2
            // 
            this.tmr2.Interval = 1500;
            this.tmr2.Tick += new System.EventHandler(this.tmr2_Tick);
            // 
            // tmr3
            // 
            this.tmr3.Interval = 1500;
            this.tmr3.Tick += new System.EventHandler(this.tmr3_Tick);
            // 
            // tmr4
            // 
            this.tmr4.Interval = 1500;
            this.tmr4.Tick += new System.EventHandler(this.tmr4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1381, 663);
            this.Controls.Add(this.btnSiparişEkle);
            this.Controls.Add(this.prb4);
            this.Controls.Add(this.txtBarista4);
            this.Controls.Add(this.prb3);
            this.Controls.Add(this.txtBarista3);
            this.Controls.Add(this.prb2);
            this.Controls.Add(this.txtBarista2);
            this.Controls.Add(this.prb1);
            this.Controls.Add(this.txtBarista1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flpEkstralar);
            this.Controls.Add(this.btnSiparisTamamla);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmrAdetSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBoyut);
            this.Controls.Add(this.cmbIcecekler);
            this.Controls.Add(this.pcPicture);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdetSayisi)).EndInit();
            this.grpBoyut.ResumeLayout(false);
            this.grpBoyut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flpEkstralar;
        private System.Windows.Forms.Button btnSiparisTamamla;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmrAdetSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoyut;
        private System.Windows.Forms.RadioButton rdoVenti;
        private System.Windows.Forms.RadioButton rdoGrande;
        private System.Windows.Forms.RadioButton rdoTall;
        private System.Windows.Forms.ComboBox cmbIcecekler;
        private System.Windows.Forms.PictureBox pcPicture;
        private System.Windows.Forms.ProgressBar prb4;
        private System.Windows.Forms.TextBox txtBarista4;
        private System.Windows.Forms.ProgressBar prb3;
        private System.Windows.Forms.TextBox txtBarista3;
        private System.Windows.Forms.ProgressBar prb2;
        private System.Windows.Forms.TextBox txtBarista2;
        private System.Windows.Forms.ProgressBar prb1;
        private System.Windows.Forms.TextBox txtBarista1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSiparişEkle;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Timer tmr2;
        private System.Windows.Forms.Timer tmr3;
        private System.Windows.Forms.Timer tmr4;
    }
}

