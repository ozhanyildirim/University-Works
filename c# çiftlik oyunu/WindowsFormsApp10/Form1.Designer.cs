namespace WindowsFormsApp10
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tavukbar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inekbar = new System.Windows.Forms.ProgressBar();
            this.kecibar = new System.Windows.Forms.ProgressBar();
            this.ordekbar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TavukYumurtaSatbtn = new System.Windows.Forms.Button();
            this.OrdekYumurtaSatBtn = new System.Windows.Forms.Button();
            this.InekSutSatBtn = new System.Windows.Forms.Button();
            this.KecıSutSatBtn = new System.Windows.Forms.Button();
            this.tavuklbl = new System.Windows.Forms.Label();
            this.ordeklbl = new System.Windows.Forms.Label();
            this.kecilbl = new System.Windows.Forms.Label();
            this.ineklbl = new System.Windows.Forms.Label();
            this.tavukyembtn = new System.Windows.Forms.Button();
            this.ordekyembtn = new System.Windows.Forms.Button();
            this.inekyembtn = new System.Windows.Forms.Button();
            this.keciyembtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerlbl = new System.Windows.Forms.Label();
            this.Kasalbl = new System.Windows.Forms.Label();
            this.TavukDepolbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.OrdekDepolbl = new System.Windows.Forms.Label();
            this.KeciDepolbl = new System.Windows.Forms.Label();
            this.InekDepolbl = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 471);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(517, 311);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(177, 129);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(517, 471);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(177, 129);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "ÜRÜN DEPOSU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "KÜMES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tavukbar
            // 
            this.tavukbar.ForeColor = System.Drawing.Color.Green;
            this.tavukbar.Location = new System.Drawing.Point(208, 360);
            this.tavukbar.Name = "tavukbar";
            this.tavukbar.Size = new System.Drawing.Size(277, 37);
            this.tavukbar.Step = 100;
            this.tavukbar.TabIndex = 6;
            this.tavukbar.Value = 100;
            this.tavukbar.Click += new System.EventHandler(this.tavukbar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkOrange;
            this.label3.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(513, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(464, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "AHIR";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkOrange;
            this.label4.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(513, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "GIDA FABRİKASI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inekbar
            // 
            this.inekbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.inekbar.Location = new System.Drawing.Point(700, 360);
            this.inekbar.Name = "inekbar";
            this.inekbar.Size = new System.Drawing.Size(277, 37);
            this.inekbar.Step = 100;
            this.inekbar.TabIndex = 9;
            this.inekbar.Value = 100;
            // 
            // kecibar
            // 
            this.kecibar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kecibar.Location = new System.Drawing.Point(700, 519);
            this.kecibar.Name = "kecibar";
            this.kecibar.Size = new System.Drawing.Size(277, 37);
            this.kecibar.Step = 100;
            this.kecibar.TabIndex = 10;
            this.kecibar.Value = 100;
            // 
            // ordekbar
            // 
            this.ordekbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ordekbar.Location = new System.Drawing.Point(208, 519);
            this.ordekbar.Name = "ordekbar";
            this.ordekbar.Size = new System.Drawing.Size(277, 37);
            this.ordekbar.Step = 100;
            this.ordekbar.TabIndex = 11;
            this.ordekbar.Value = 100;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(784, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "GEÇEN SÜRE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkOrange;
            this.label6.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(784, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "KASA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TavukYumurtaSatbtn
            // 
            this.TavukYumurtaSatbtn.BackColor = System.Drawing.Color.White;
            this.TavukYumurtaSatbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TavukYumurtaSatbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TavukYumurtaSatbtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TavukYumurtaSatbtn.ForeColor = System.Drawing.Color.Red;
            this.TavukYumurtaSatbtn.Location = new System.Drawing.Point(517, 63);
            this.TavukYumurtaSatbtn.Name = "TavukYumurtaSatbtn";
            this.TavukYumurtaSatbtn.Size = new System.Drawing.Size(250, 35);
            this.TavukYumurtaSatbtn.TabIndex = 14;
            this.TavukYumurtaSatbtn.Text = "TAVUK YUMURTASI SAT";
            this.TavukYumurtaSatbtn.UseVisualStyleBackColor = false;
            this.TavukYumurtaSatbtn.Click += new System.EventHandler(this.TavukYumurtaSatbtn_Click);
            // 
            // OrdekYumurtaSatBtn
            // 
            this.OrdekYumurtaSatBtn.BackColor = System.Drawing.Color.White;
            this.OrdekYumurtaSatBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.OrdekYumurtaSatBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.OrdekYumurtaSatBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdekYumurtaSatBtn.ForeColor = System.Drawing.Color.Red;
            this.OrdekYumurtaSatBtn.Location = new System.Drawing.Point(517, 104);
            this.OrdekYumurtaSatBtn.Name = "OrdekYumurtaSatBtn";
            this.OrdekYumurtaSatBtn.Size = new System.Drawing.Size(250, 37);
            this.OrdekYumurtaSatBtn.TabIndex = 15;
            this.OrdekYumurtaSatBtn.Text = "ÖRDEK YUMURTASI SAT";
            this.OrdekYumurtaSatBtn.UseVisualStyleBackColor = false;
            this.OrdekYumurtaSatBtn.Click += new System.EventHandler(this.OrdekYumurtaSatBtn_Click);
            // 
            // InekSutSatBtn
            // 
            this.InekSutSatBtn.BackColor = System.Drawing.Color.White;
            this.InekSutSatBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.InekSutSatBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.InekSutSatBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InekSutSatBtn.ForeColor = System.Drawing.Color.Red;
            this.InekSutSatBtn.Location = new System.Drawing.Point(517, 159);
            this.InekSutSatBtn.Name = "InekSutSatBtn";
            this.InekSutSatBtn.Size = new System.Drawing.Size(250, 42);
            this.InekSutSatBtn.TabIndex = 16;
            this.InekSutSatBtn.Text = "İNEK SÜTÜ SAT";
            this.InekSutSatBtn.UseVisualStyleBackColor = false;
            this.InekSutSatBtn.Click += new System.EventHandler(this.InekSutSatBtn_Click);
            // 
            // KecıSutSatBtn
            // 
            this.KecıSutSatBtn.BackColor = System.Drawing.Color.White;
            this.KecıSutSatBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.KecıSutSatBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.KecıSutSatBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KecıSutSatBtn.ForeColor = System.Drawing.Color.Red;
            this.KecıSutSatBtn.Location = new System.Drawing.Point(517, 207);
            this.KecıSutSatBtn.Name = "KecıSutSatBtn";
            this.KecıSutSatBtn.Size = new System.Drawing.Size(250, 40);
            this.KecıSutSatBtn.TabIndex = 17;
            this.KecıSutSatBtn.Text = "KEÇİ SÜTÜ SAT";
            this.KecıSutSatBtn.UseVisualStyleBackColor = false;
            this.KecıSutSatBtn.Click += new System.EventHandler(this.KecıSutSatBtn_Click);
            // 
            // tavuklbl
            // 
            this.tavuklbl.BackColor = System.Drawing.Color.SeaShell;
            this.tavuklbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tavuklbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tavuklbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tavuklbl.Location = new System.Drawing.Point(208, 311);
            this.tavuklbl.Name = "tavuklbl";
            this.tavuklbl.Size = new System.Drawing.Size(277, 38);
            this.tavuklbl.TabIndex = 18;
            this.tavuklbl.Text = "CANLI";
            this.tavuklbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ordeklbl
            // 
            this.ordeklbl.BackColor = System.Drawing.Color.SeaShell;
            this.ordeklbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ordeklbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ordeklbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ordeklbl.Location = new System.Drawing.Point(208, 471);
            this.ordeklbl.Name = "ordeklbl";
            this.ordeklbl.Size = new System.Drawing.Size(277, 37);
            this.ordeklbl.TabIndex = 19;
            this.ordeklbl.Text = "CANLI";
            this.ordeklbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kecilbl
            // 
            this.kecilbl.BackColor = System.Drawing.Color.SeaShell;
            this.kecilbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kecilbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kecilbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kecilbl.Location = new System.Drawing.Point(700, 471);
            this.kecilbl.Name = "kecilbl";
            this.kecilbl.Size = new System.Drawing.Size(277, 35);
            this.kecilbl.TabIndex = 20;
            this.kecilbl.Text = "CANLI";
            this.kecilbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ineklbl
            // 
            this.ineklbl.BackColor = System.Drawing.Color.SeaShell;
            this.ineklbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ineklbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ineklbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ineklbl.Location = new System.Drawing.Point(700, 311);
            this.ineklbl.Name = "ineklbl";
            this.ineklbl.Size = new System.Drawing.Size(277, 38);
            this.ineklbl.TabIndex = 21;
            this.ineklbl.Text = "CANLI";
            this.ineklbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tavukyembtn
            // 
            this.tavukyembtn.BackColor = System.Drawing.Color.White;
            this.tavukyembtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tavukyembtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tavukyembtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tavukyembtn.ForeColor = System.Drawing.Color.Red;
            this.tavukyembtn.Location = new System.Drawing.Point(208, 403);
            this.tavukyembtn.Name = "tavukyembtn";
            this.tavukyembtn.Size = new System.Drawing.Size(277, 37);
            this.tavukyembtn.TabIndex = 22;
            this.tavukyembtn.Text = "YEM VER";
            this.tavukyembtn.UseVisualStyleBackColor = false;
            this.tavukyembtn.Click += new System.EventHandler(this.tavukyembtn_Click);
            // 
            // ordekyembtn
            // 
            this.ordekyembtn.BackColor = System.Drawing.Color.White;
            this.ordekyembtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ordekyembtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ordekyembtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordekyembtn.ForeColor = System.Drawing.Color.Red;
            this.ordekyembtn.Location = new System.Drawing.Point(208, 562);
            this.ordekyembtn.Name = "ordekyembtn";
            this.ordekyembtn.Size = new System.Drawing.Size(277, 37);
            this.ordekyembtn.TabIndex = 23;
            this.ordekyembtn.Text = "YEM VER";
            this.ordekyembtn.UseVisualStyleBackColor = false;
            this.ordekyembtn.Click += new System.EventHandler(this.ordekyembtn_Click);
            // 
            // inekyembtn
            // 
            this.inekyembtn.BackColor = System.Drawing.Color.White;
            this.inekyembtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.inekyembtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.inekyembtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inekyembtn.ForeColor = System.Drawing.Color.Red;
            this.inekyembtn.Location = new System.Drawing.Point(700, 403);
            this.inekyembtn.Name = "inekyembtn";
            this.inekyembtn.Size = new System.Drawing.Size(277, 37);
            this.inekyembtn.TabIndex = 24;
            this.inekyembtn.Text = "YEM VER";
            this.inekyembtn.UseVisualStyleBackColor = false;
            this.inekyembtn.Click += new System.EventHandler(this.inekyembtn_Click);
            // 
            // keciyembtn
            // 
            this.keciyembtn.BackColor = System.Drawing.Color.White;
            this.keciyembtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.keciyembtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.keciyembtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keciyembtn.ForeColor = System.Drawing.Color.Red;
            this.keciyembtn.Location = new System.Drawing.Point(700, 562);
            this.keciyembtn.Name = "keciyembtn";
            this.keciyembtn.Size = new System.Drawing.Size(277, 37);
            this.keciyembtn.TabIndex = 25;
            this.keciyembtn.Text = "YEM VER";
            this.keciyembtn.UseVisualStyleBackColor = false;
            this.keciyembtn.Click += new System.EventHandler(this.keciyembtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerlbl
            // 
            this.timerlbl.BackColor = System.Drawing.Color.Honeydew;
            this.timerlbl.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timerlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.timerlbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timerlbl.Location = new System.Drawing.Point(785, 61);
            this.timerlbl.Name = "timerlbl";
            this.timerlbl.Size = new System.Drawing.Size(167, 68);
            this.timerlbl.TabIndex = 26;
            this.timerlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Kasalbl
            // 
            this.Kasalbl.BackColor = System.Drawing.Color.Honeydew;
            this.Kasalbl.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kasalbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Kasalbl.Location = new System.Drawing.Point(785, 175);
            this.Kasalbl.Name = "Kasalbl";
            this.Kasalbl.Size = new System.Drawing.Size(167, 72);
            this.Kasalbl.TabIndex = 27;
            this.Kasalbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TavukDepolbl
            // 
            this.TavukDepolbl.BackColor = System.Drawing.Color.Honeydew;
            this.TavukDepolbl.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TavukDepolbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TavukDepolbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TavukDepolbl.Location = new System.Drawing.Point(26, 96);
            this.TavukDepolbl.Name = "TavukDepolbl";
            this.TavukDepolbl.Size = new System.Drawing.Size(217, 42);
            this.TavukDepolbl.TabIndex = 28;
            this.TavukDepolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.LightGray;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(25, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(218, 22);
            this.label12.TabIndex = 32;
            this.label12.Text = "TAVUK YUMURTASI";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.LightGray;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(267, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(218, 22);
            this.label13.TabIndex = 33;
            this.label13.Text = "İNEK SÜTÜ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.LightGray;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(267, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(218, 22);
            this.label14.TabIndex = 34;
            this.label14.Text = "KEÇİ SÜTÜ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.LightGray;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(26, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(218, 22);
            this.label15.TabIndex = 35;
            this.label15.Text = "ÖRDEK YUMURTASI";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrdekDepolbl
            // 
            this.OrdekDepolbl.BackColor = System.Drawing.Color.Honeydew;
            this.OrdekDepolbl.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OrdekDepolbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OrdekDepolbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.OrdekDepolbl.Location = new System.Drawing.Point(26, 201);
            this.OrdekDepolbl.Name = "OrdekDepolbl";
            this.OrdekDepolbl.Size = new System.Drawing.Size(217, 42);
            this.OrdekDepolbl.TabIndex = 36;
            this.OrdekDepolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeciDepolbl
            // 
            this.KeciDepolbl.BackColor = System.Drawing.Color.Honeydew;
            this.KeciDepolbl.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeciDepolbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.KeciDepolbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.KeciDepolbl.Location = new System.Drawing.Point(268, 201);
            this.KeciDepolbl.Name = "KeciDepolbl";
            this.KeciDepolbl.Size = new System.Drawing.Size(217, 42);
            this.KeciDepolbl.TabIndex = 37;
            this.KeciDepolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InekDepolbl
            // 
            this.InekDepolbl.BackColor = System.Drawing.Color.Honeydew;
            this.InekDepolbl.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InekDepolbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.InekDepolbl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.InekDepolbl.Location = new System.Drawing.Point(268, 99);
            this.InekDepolbl.Name = "InekDepolbl";
            this.InekDepolbl.Size = new System.Drawing.Size(217, 42);
            this.InekDepolbl.TabIndex = 38;
            this.InekDepolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1078, 626);
            this.Controls.Add(this.InekDepolbl);
            this.Controls.Add(this.KeciDepolbl);
            this.Controls.Add(this.OrdekDepolbl);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TavukDepolbl);
            this.Controls.Add(this.Kasalbl);
            this.Controls.Add(this.timerlbl);
            this.Controls.Add(this.keciyembtn);
            this.Controls.Add(this.inekyembtn);
            this.Controls.Add(this.ordekyembtn);
            this.Controls.Add(this.tavukyembtn);
            this.Controls.Add(this.ineklbl);
            this.Controls.Add(this.kecilbl);
            this.Controls.Add(this.ordeklbl);
            this.Controls.Add(this.tavuklbl);
            this.Controls.Add(this.KecıSutSatBtn);
            this.Controls.Add(this.InekSutSatBtn);
            this.Controls.Add(this.OrdekYumurtaSatBtn);
            this.Controls.Add(this.TavukYumurtaSatbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ordekbar);
            this.Controls.Add(this.kecibar);
            this.Controls.Add(this.inekbar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tavukbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HAYVAN ÇİFTLİĞİ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar tavukbar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar inekbar;
        private System.Windows.Forms.ProgressBar kecibar;
        private System.Windows.Forms.ProgressBar ordekbar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button TavukYumurtaSatbtn;
        private System.Windows.Forms.Button OrdekYumurtaSatBtn;
        private System.Windows.Forms.Button InekSutSatBtn;
        private System.Windows.Forms.Button KecıSutSatBtn;
        private System.Windows.Forms.Label tavuklbl;
        private System.Windows.Forms.Label ordeklbl;
        private System.Windows.Forms.Label kecilbl;
        private System.Windows.Forms.Label ineklbl;
        private System.Windows.Forms.Button tavukyembtn;
        private System.Windows.Forms.Button ordekyembtn;
        private System.Windows.Forms.Button inekyembtn;
        private System.Windows.Forms.Button keciyembtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerlbl;
        private System.Windows.Forms.Label Kasalbl;
        private System.Windows.Forms.Label TavukDepolbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label OrdekDepolbl;
        private System.Windows.Forms.Label KeciDepolbl;
        private System.Windows.Forms.Label InekDepolbl;
        private System.Windows.Forms.Timer timer2;
    }
}

