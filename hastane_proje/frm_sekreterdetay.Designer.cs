namespace hastane_proje
{
    partial class frm_sekreterdetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sekreterdetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblsekreteradsoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsekretertc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnduyuruolustur = new System.Windows.Forms.Button();
            this.rchduyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkdurum = new System.Windows.Forms.CheckBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.cmbdoktor = new System.Windows.Forms.ComboBox();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.msksaat = new System.Windows.Forms.MaskedTextBox();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnduyuru = new System.Windows.Forms.Button();
            this.btnrandevuliste = new System.Windows.Forms.Button();
            this.btndoktorpanel = new System.Windows.Forms.Button();
            this.btnbranspanel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblsekreteradsoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblsekretertc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // lblsekreteradsoyad
            // 
            this.lblsekreteradsoyad.AutoSize = true;
            this.lblsekreteradsoyad.Location = new System.Drawing.Point(130, 92);
            this.lblsekreteradsoyad.Name = "lblsekreteradsoyad";
            this.lblsekreteradsoyad.Size = new System.Drawing.Size(127, 28);
            this.lblsekreteradsoyad.TabIndex = 4;
            this.lblsekreteradsoyad.Text = "NULL NULL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC NO:";
            // 
            // lblsekretertc
            // 
            this.lblsekretertc.AutoSize = true;
            this.lblsekretertc.Location = new System.Drawing.Point(130, 48);
            this.lblsekretertc.Name = "lblsekretertc";
            this.lblsekretertc.Size = new System.Drawing.Size(144, 28);
            this.lblsekretertc.TabIndex = 3;
            this.lblsekretertc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnduyuruolustur);
            this.groupBox2.Controls.Add(this.rchduyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 299);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnduyuruolustur
            // 
            this.btnduyuruolustur.Location = new System.Drawing.Point(6, 246);
            this.btnduyuruolustur.Name = "btnduyuruolustur";
            this.btnduyuruolustur.Size = new System.Drawing.Size(268, 47);
            this.btnduyuruolustur.TabIndex = 1;
            this.btnduyuruolustur.Text = "Oluştur";
            this.btnduyuruolustur.UseVisualStyleBackColor = true;
            this.btnduyuruolustur.Click += new System.EventHandler(this.btnduyuruolustur_Click);
            // 
            // rchduyuru
            // 
            this.rchduyuru.Location = new System.Drawing.Point(6, 35);
            this.rchduyuru.Name = "rchduyuru";
            this.rchduyuru.Size = new System.Drawing.Size(268, 205);
            this.rchduyuru.TabIndex = 0;
            this.rchduyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkdurum);
            this.groupBox3.Controls.Add(this.btnkaydet);
            this.groupBox3.Controls.Add(this.cmbdoktor);
            this.groupBox3.Controls.Add(this.cmbbrans);
            this.groupBox3.Controls.Add(this.msktc);
            this.groupBox3.Controls.Add(this.msksaat);
            this.groupBox3.Controls.Add(this.msktarih);
            this.groupBox3.Controls.Add(this.txtid);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(309, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 482);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // chkdurum
            // 
            this.chkdurum.AutoSize = true;
            this.chkdurum.Location = new System.Drawing.Point(129, 358);
            this.chkdurum.Name = "chkdurum";
            this.chkdurum.Size = new System.Drawing.Size(100, 32);
            this.chkdurum.TabIndex = 3;
            this.chkdurum.Text = "Durum";
            this.chkdurum.UseVisualStyleBackColor = true;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(129, 410);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(155, 51);
            this.btnkaydet.TabIndex = 17;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // cmbdoktor
            // 
            this.cmbdoktor.FormattingEnabled = true;
            this.cmbdoktor.Location = new System.Drawing.Point(129, 264);
            this.cmbdoktor.Name = "cmbdoktor";
            this.cmbdoktor.Size = new System.Drawing.Size(158, 36);
            this.cmbdoktor.TabIndex = 5;
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(129, 213);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(155, 36);
            this.cmbbrans.TabIndex = 4;
            this.cmbbrans.SelectedIndexChanged += new System.EventHandler(this.cmbbrans_SelectedIndexChanged);
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(129, 316);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(155, 36);
            this.msktc.TabIndex = 6;
            this.msktc.ValidatingType = typeof(int);
            // 
            // msksaat
            // 
            this.msksaat.Location = new System.Drawing.Point(129, 162);
            this.msksaat.Mask = "00:00";
            this.msksaat.Name = "msksaat";
            this.msksaat.Size = new System.Drawing.Size(155, 36);
            this.msksaat.TabIndex = 3;
            this.msksaat.ValidatingType = typeof(System.DateTime);
            // 
            // msktarih
            // 
            this.msktarih.Location = new System.Drawing.Point(129, 108);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(155, 36);
            this.msktarih.TabIndex = 2;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(129, 59);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(155, 36);
            this.txtid.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "TC NO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Doktor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Branş:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 28);
            this.label8.TabIndex = 8;
            this.label8.Text = "Saat:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 28);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tarih:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 28);
            this.label10.TabIndex = 10;
            this.label10.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(622, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(466, 281);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(460, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(625, 296);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(463, 328);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(457, 293);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnduyuru);
            this.groupBox6.Controls.Add(this.btnrandevuliste);
            this.groupBox6.Controls.Add(this.btndoktorpanel);
            this.groupBox6.Controls.Add(this.btnbranspanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 500);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(604, 124);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btnduyuru
            // 
            this.btnduyuru.Location = new System.Drawing.Point(304, 49);
            this.btnduyuru.Name = "btnduyuru";
            this.btnduyuru.Size = new System.Drawing.Size(136, 47);
            this.btnduyuru.TabIndex = 22;
            this.btnduyuru.Text = "Duyurular";
            this.btnduyuru.UseVisualStyleBackColor = true;
            this.btnduyuru.Click += new System.EventHandler(this.btnduyuru_Click);
            // 
            // btnrandevuliste
            // 
            this.btnrandevuliste.Location = new System.Drawing.Point(445, 49);
            this.btnrandevuliste.Name = "btnrandevuliste";
            this.btnrandevuliste.Size = new System.Drawing.Size(159, 47);
            this.btnrandevuliste.TabIndex = 21;
            this.btnrandevuliste.Text = "Randevu Liste";
            this.btnrandevuliste.UseVisualStyleBackColor = true;
            this.btnrandevuliste.Click += new System.EventHandler(this.btnrandevuliste_Click);
            // 
            // btndoktorpanel
            // 
            this.btndoktorpanel.Location = new System.Drawing.Point(6, 49);
            this.btndoktorpanel.Name = "btndoktorpanel";
            this.btndoktorpanel.Size = new System.Drawing.Size(150, 47);
            this.btndoktorpanel.TabIndex = 19;
            this.btndoktorpanel.Text = "Doktor Paneli";
            this.btndoktorpanel.UseVisualStyleBackColor = true;
            this.btndoktorpanel.Click += new System.EventHandler(this.btndoktorpanel_Click);
            // 
            // btnbranspanel
            // 
            this.btnbranspanel.Location = new System.Drawing.Point(162, 49);
            this.btnbranspanel.Name = "btnbranspanel";
            this.btnbranspanel.Size = new System.Drawing.Size(136, 47);
            this.btnbranspanel.TabIndex = 20;
            this.btnbranspanel.Text = "Branş Paneli";
            this.btnbranspanel.UseVisualStyleBackColor = true;
            this.btnbranspanel.Click += new System.EventHandler(this.btnbranspanel_Click);
            // 
            // frm_sekreterdetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1095, 636);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frm_sekreterdetay";
            this.Text = "Sekreter Detay";
            this.Load += new System.EventHandler(this.frm_sekreterdetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblsekreteradsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsekretertc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnduyuruolustur;
        private System.Windows.Forms.RichTextBox rchduyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkdurum;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.ComboBox cmbdoktor;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.MaskedTextBox msksaat;
        private System.Windows.Forms.MaskedTextBox msktarih;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnrandevuliste;
        private System.Windows.Forms.Button btnbranspanel;
        private System.Windows.Forms.Button btndoktorpanel;
        private System.Windows.Forms.Button btnduyuru;
    }
}