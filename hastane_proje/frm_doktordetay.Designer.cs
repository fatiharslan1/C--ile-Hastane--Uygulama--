namespace hastane_proje
{
    partial class frm_doktordetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_doktordetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rchsikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnduyuru = new System.Windows.Forms.Button();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbladsoyad);
            this.groupBox1.Controls.Add(this.lbltc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(133, 97);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(127, 28);
            this.lbladsoyad.TabIndex = 4;
            this.lbladsoyad.Text = "NULL NULL";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(133, 58);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(144, 28);
            this.lbltc.TabIndex = 2;
            this.lbltc.Text = "00000000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC NO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rchsikayet);
            this.groupBox2.Location = new System.Drawing.Point(12, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // rchsikayet
            // 
            this.rchsikayet.Location = new System.Drawing.Point(12, 35);
            this.rchsikayet.Name = "rchsikayet";
            this.rchsikayet.Size = new System.Drawing.Size(319, 173);
            this.rchsikayet.TabIndex = 1;
            this.rchsikayet.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(349, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(697, 575);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(691, 540);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnduyuru);
            this.groupBox4.Controls.Add(this.btncıkıs);
            this.groupBox4.Controls.Add(this.btnguncelle);
            this.groupBox4.Location = new System.Drawing.Point(12, 427);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(331, 160);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // btnduyuru
            // 
            this.btnduyuru.Location = new System.Drawing.Point(163, 35);
            this.btnduyuru.Name = "btnduyuru";
            this.btnduyuru.Size = new System.Drawing.Size(145, 47);
            this.btnduyuru.TabIndex = 7;
            this.btnduyuru.Text = "Duyurular";
            this.btnduyuru.UseVisualStyleBackColor = true;
            this.btnduyuru.Click += new System.EventHandler(this.btnduyuru_Click);
            // 
            // btncıkıs
            // 
            this.btncıkıs.Location = new System.Drawing.Point(12, 94);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(296, 47);
            this.btncıkıs.TabIndex = 6;
            this.btncıkıs.Text = "Çıkış";
            this.btncıkıs.UseVisualStyleBackColor = true;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(12, 35);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(145, 47);
            this.btnguncelle.TabIndex = 5;
            this.btnguncelle.Text = "Bilgi Düzenle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // frm_doktordetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1058, 602);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frm_doktordetay";
            this.Text = "Doktor Detay";
            this.Load += new System.EventHandler(this.frm_doktordetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox rchsikayet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnduyuru;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Button btnguncelle;
    }
}