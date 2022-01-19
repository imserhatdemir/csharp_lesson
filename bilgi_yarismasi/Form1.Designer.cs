namespace bilgi_yarismasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btna = new System.Windows.Forms.Button();
            this.btnb = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsn = new System.Windows.Forms.Label();
            this.lbldn = new System.Windows.Forms.Label();
            this.lblyn = new System.Windows.Forms.Label();
            this.btns = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 8);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(337, 118);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btna
            // 
            this.btna.Location = new System.Drawing.Point(14, 140);
            this.btna.Name = "btna";
            this.btna.Size = new System.Drawing.Size(152, 40);
            this.btna.TabIndex = 1;
            this.btna.Text = "A";
            this.btna.UseVisualStyleBackColor = true;
            this.btna.Click += new System.EventHandler(this.Btna_Click);
            // 
            // btnb
            // 
            this.btnb.Location = new System.Drawing.Point(193, 140);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(152, 40);
            this.btnb.TabIndex = 2;
            this.btnb.Text = "B";
            this.btnb.UseVisualStyleBackColor = true;
            this.btnb.Click += new System.EventHandler(this.Btnb_Click);
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(14, 186);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(152, 40);
            this.btnc.TabIndex = 3;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.Btnc_Click);
            // 
            // btnd
            // 
            this.btnd.Location = new System.Drawing.Point(193, 186);
            this.btnd.Name = "btnd";
            this.btnd.Size = new System.Drawing.Size(152, 40);
            this.btnd.TabIndex = 4;
            this.btnd.Text = "D";
            this.btnd.UseVisualStyleBackColor = true;
            this.btnd.Click += new System.EventHandler(this.Btnd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "SORU NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "DOĞRU:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "YANLIŞ:";
            // 
            // lblsn
            // 
            this.lblsn.AutoSize = true;
            this.lblsn.Location = new System.Drawing.Point(509, 32);
            this.lblsn.Name = "lblsn";
            this.lblsn.Size = new System.Drawing.Size(22, 26);
            this.lblsn.TabIndex = 8;
            this.lblsn.Text = "0";
            // 
            // lbldn
            // 
            this.lbldn.AutoSize = true;
            this.lbldn.Location = new System.Drawing.Point(509, 58);
            this.lbldn.Name = "lbldn";
            this.lbldn.Size = new System.Drawing.Size(22, 26);
            this.lbldn.TabIndex = 9;
            this.lbldn.Text = "0";
            // 
            // lblyn
            // 
            this.lblyn.AutoSize = true;
            this.lblyn.Location = new System.Drawing.Point(509, 84);
            this.lblyn.Name = "lblyn";
            this.lblyn.Size = new System.Drawing.Size(22, 26);
            this.lblyn.TabIndex = 10;
            this.lblyn.Text = "0";
            // 
            // btns
            // 
            this.btns.Location = new System.Drawing.Point(385, 113);
            this.btns.Name = "btns";
            this.btns.Size = new System.Drawing.Size(215, 33);
            this.btns.TabIndex = 11;
            this.btns.Text = "SONRAKİ SORU";
            this.btns.UseVisualStyleBackColor = true;
            this.btns.Click += new System.EventHandler(this.Btns_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(385, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(490, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(611, 262);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btns);
            this.Controls.Add(this.lblyn);
            this.Controls.Add(this.lbldn);
            this.Controls.Add(this.lblsn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnd);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnb);
            this.Controls.Add(this.btna);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btna;
        private System.Windows.Forms.Button btnb;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsn;
        private System.Windows.Forms.Label lbldn;
        private System.Windows.Forms.Label lblyn;
        private System.Windows.Forms.Button btns;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

