namespace hastane_proje
{
    partial class frm_bilgiduzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_bilgiduzenle));
            this.btnbilgiguncelle = new System.Windows.Forms.Button();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbilgiguncelle
            // 
            this.btnbilgiguncelle.BackColor = System.Drawing.Color.SkyBlue;
            this.btnbilgiguncelle.Location = new System.Drawing.Point(178, 407);
            this.btnbilgiguncelle.Name = "btnbilgiguncelle";
            this.btnbilgiguncelle.Size = new System.Drawing.Size(185, 47);
            this.btnbilgiguncelle.TabIndex = 32;
            this.btnbilgiguncelle.Text = "Güncelle";
            this.btnbilgiguncelle.UseVisualStyleBackColor = false;
            this.btnbilgiguncelle.Click += new System.EventHandler(this.btnbilgiguncelle_Click);
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(178, 352);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(185, 36);
            this.cmbcinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 30;
            this.label6.Text = "Cinsiyet:";
            // 
            // msktel
            // 
            this.msktel.Location = new System.Drawing.Point(178, 236);
            this.msktel.Mask = "(999) 000-0000";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(185, 36);
            this.msktel.TabIndex = 4;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(178, 61);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(185, 36);
            this.txtad.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ad:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(178, 300);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(185, 36);
            this.txtsifre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Telefon No:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(178, 116);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(185, 36);
            this.txtsoyad.TabIndex = 2;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(178, 177);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(185, 36);
            this.msktc.TabIndex = 3;
            this.msktc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "TC Kimlik No:";
            // 
            // frm_bilgiduzenle
            // 
            this.AcceptButton = this.btnbilgiguncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(479, 523);
            this.Controls.Add(this.btnbilgiguncelle);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msktel);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frm_bilgiduzenle";
            this.Text = "Bilgi Düzenle";
            this.Load += new System.EventHandler(this.frm_bilgiduzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbilgiguncelle;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}