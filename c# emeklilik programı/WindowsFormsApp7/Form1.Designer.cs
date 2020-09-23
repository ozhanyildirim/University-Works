namespace WindowsFormsApp7
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
            this.btnbilgi = new System.Windows.Forms.Button();
            this.txttc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnhesap = new System.Windows.Forms.Button();
            this.burutmaastxt = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kisibox = new System.Windows.Forms.ListBox();
            this.fotopcbox = new System.Windows.Forms.PictureBox();
            this.damgatxt = new System.Windows.Forms.TextBox();
            this.gelirbox = new System.Windows.Forms.TextBox();
            this.netmaasbox = new System.Windows.Forms.TextBox();
            this.emeklibox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fotopcbox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbilgi
            // 
            this.btnbilgi.BackColor = System.Drawing.Color.Aqua;
            this.btnbilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbilgi.Location = new System.Drawing.Point(809, 28);
            this.btnbilgi.Name = "btnbilgi";
            this.btnbilgi.Size = new System.Drawing.Size(151, 51);
            this.btnbilgi.TabIndex = 0;
            this.btnbilgi.Text = "BİLGİLERİ GETİR";
            this.btnbilgi.UseVisualStyleBackColor = false;
            this.btnbilgi.Click += new System.EventHandler(this.btnbilgi_Click);
            // 
            // txttc
            // 
            this.txttc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txttc.Location = new System.Drawing.Point(535, 28);
            this.txttc.Multiline = true;
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(195, 29);
            this.txttc.TabIndex = 4;
            this.txttc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "TC NO";
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Red;
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.Location = new System.Drawing.Point(907, 410);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(151, 51);
            this.btncikis.TabIndex = 6;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnhesap
            // 
            this.btnhesap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnhesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnhesap.Location = new System.Drawing.Point(1030, 28);
            this.btnhesap.Name = "btnhesap";
            this.btnhesap.Size = new System.Drawing.Size(161, 51);
            this.btnhesap.TabIndex = 7;
            this.btnhesap.Text = "HESAPLAMALARI YAP";
            this.btnhesap.UseVisualStyleBackColor = false;
            this.btnhesap.Click += new System.EventHandler(this.btnhesap_Click);
            // 
            // burutmaastxt
            // 
            this.burutmaastxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.burutmaastxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.burutmaastxt.Location = new System.Drawing.Point(94, 339);
            this.burutmaastxt.Name = "burutmaastxt";
            this.burutmaastxt.Size = new System.Drawing.Size(255, 44);
            this.burutmaastxt.TabIndex = 9;
            this.burutmaastxt.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(506, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "KİŞİ BİLGİLERİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(479, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 40);
            this.label3.TabIndex = 11;
            this.label3.Text = "HESAPLAMALAR";
            // 
            // kisibox
            // 
            this.kisibox.BackColor = System.Drawing.SystemColors.Info;
            this.kisibox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kisibox.ForeColor = System.Drawing.Color.Maroon;
            this.kisibox.FormattingEnabled = true;
            this.kisibox.ItemHeight = 19;
            this.kisibox.Location = new System.Drawing.Point(94, 183);
            this.kisibox.Name = "kisibox";
            this.kisibox.Size = new System.Drawing.Size(1121, 80);
            this.kisibox.TabIndex = 12;
            // 
            // fotopcbox
            // 
            this.fotopcbox.BackColor = System.Drawing.Color.Maroon;
            this.fotopcbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fotopcbox.BackgroundImage")));
            this.fotopcbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fotopcbox.InitialImage = ((System.Drawing.Image)(resources.GetObject("fotopcbox.InitialImage")));
            this.fotopcbox.Location = new System.Drawing.Point(94, 6);
            this.fotopcbox.Name = "fotopcbox";
            this.fotopcbox.Size = new System.Drawing.Size(209, 173);
            this.fotopcbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fotopcbox.TabIndex = 13;
            this.fotopcbox.TabStop = false;
            // 
            // damgatxt
            // 
            this.damgatxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.damgatxt.Location = new System.Drawing.Point(94, 426);
            this.damgatxt.Multiline = true;
            this.damgatxt.Name = "damgatxt";
            this.damgatxt.Size = new System.Drawing.Size(255, 41);
            this.damgatxt.TabIndex = 14;
            // 
            // gelirbox
            // 
            this.gelirbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gelirbox.Location = new System.Drawing.Point(486, 426);
            this.gelirbox.Multiline = true;
            this.gelirbox.Name = "gelirbox";
            this.gelirbox.Size = new System.Drawing.Size(255, 44);
            this.gelirbox.TabIndex = 15;
            // 
            // netmaasbox
            // 
            this.netmaasbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.netmaasbox.Location = new System.Drawing.Point(855, 337);
            this.netmaasbox.Multiline = true;
            this.netmaasbox.Name = "netmaasbox";
            this.netmaasbox.Size = new System.Drawing.Size(255, 41);
            this.netmaasbox.TabIndex = 16;
            // 
            // emeklibox
            // 
            this.emeklibox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.emeklibox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emeklibox.Location = new System.Drawing.Point(486, 341);
            this.emeklibox.Multiline = true;
            this.emeklibox.Name = "emeklibox";
            this.emeklibox.Size = new System.Drawing.Size(255, 42);
            this.emeklibox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "BÜRÜT MAAŞ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "EMEKLİLİK KESİNTİSİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "GELİR VERGİSİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "DAMGA VERGİSİ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(852, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "NET MAAŞ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1290, 517);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emeklibox);
            this.Controls.Add(this.netmaasbox);
            this.Controls.Add(this.gelirbox);
            this.Controls.Add(this.damgatxt);
            this.Controls.Add(this.fotopcbox);
            this.Controls.Add(this.kisibox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.burutmaastxt);
            this.Controls.Add(this.btnhesap);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.btnbilgi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "HESAPLAMA PROGRAMI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotopcbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbilgi;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnhesap;
        private System.Windows.Forms.RichTextBox burutmaastxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox kisibox;
        private System.Windows.Forms.PictureBox fotopcbox;
        private System.Windows.Forms.TextBox damgatxt;
        private System.Windows.Forms.TextBox gelirbox;
        private System.Windows.Forms.TextBox netmaasbox;
        private System.Windows.Forms.TextBox emeklibox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

