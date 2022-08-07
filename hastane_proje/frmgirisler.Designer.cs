namespace hastane_proje
{
    partial class frmgirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgirisler));
            this.btnhasta = new System.Windows.Forms.Button();
            this.btndoktor = new System.Windows.Forms.Button();
            this.btnsekreter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnhasta
            // 
            this.btnhasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhasta.BackgroundImage")));
            this.btnhasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhasta.Location = new System.Drawing.Point(31, 201);
            this.btnhasta.Name = "btnhasta";
            this.btnhasta.Size = new System.Drawing.Size(229, 217);
            this.btnhasta.TabIndex = 0;
            this.btnhasta.UseVisualStyleBackColor = true;
            this.btnhasta.Click += new System.EventHandler(this.btnhasta_Click);
            // 
            // btndoktor
            // 
            this.btndoktor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndoktor.BackgroundImage")));
            this.btndoktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndoktor.Location = new System.Drawing.Point(295, 201);
            this.btndoktor.Name = "btndoktor";
            this.btndoktor.Size = new System.Drawing.Size(229, 217);
            this.btndoktor.TabIndex = 1;
            this.btndoktor.UseVisualStyleBackColor = true;
            this.btndoktor.Click += new System.EventHandler(this.btndoktor_Click);
            // 
            // btnsekreter
            // 
            this.btnsekreter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsekreter.BackgroundImage")));
            this.btnsekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsekreter.Location = new System.Drawing.Point(562, 201);
            this.btnsekreter.Name = "btnsekreter";
            this.btnsekreter.Size = new System.Drawing.Size(229, 217);
            this.btnsekreter.TabIndex = 2;
            this.btnsekreter.UseVisualStyleBackColor = true;
            this.btnsekreter.Click += new System.EventHandler(this.btnsekreter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(760, 73);
            this.label4.TabIndex = 6;
            this.label4.Text = "Özel Şelale Hastanesi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(48, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 45);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bilgi Takip Sistemi";
            // 
            // frmgirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(831, 491);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsekreter);
            this.Controls.Add(this.btndoktor);
            this.Controls.Add(this.btnhasta);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmgirisler";
            this.Text = "Şelale Hastanesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhasta;
        private System.Windows.Forms.Button btndoktor;
        private System.Windows.Forms.Button btnsekreter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

