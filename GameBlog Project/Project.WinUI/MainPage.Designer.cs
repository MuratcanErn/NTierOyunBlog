namespace Project.WinUI
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblOyunKategori = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblStatu = new System.Windows.Forms.Label();
            this.btnYorumYap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYorum = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblComment3 = new System.Windows.Forms.Label();
            this.lblComment2 = new System.Windows.Forms.Label();
            this.lblComment1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSayfaYenile = new System.Windows.Forms.Button();
            this.btnLike3 = new System.Windows.Forms.Button();
            this.btnDissLike3 = new System.Windows.Forms.Button();
            this.btnLike1 = new System.Windows.Forms.Button();
            this.btnDissLike1 = new System.Windows.Forms.Button();
            this.btnLike2 = new System.Windows.Forms.Button();
            this.btnDissLike2 = new System.Windows.Forms.Button();
            this.lblBegeniSayi1 = new System.Windows.Forms.Label();
            this.lblBegenmeSayi1 = new System.Windows.Forms.Label();
            this.lblBegenSayi2 = new System.Windows.Forms.Label();
            this.lblBegenmeSayi2 = new System.Windows.Forms.Label();
            this.lblBegenmeSayi3 = new System.Windows.Forms.Label();
            this.lblBegenSayi3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctFoto
            // 
            this.pctFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctFoto.BackgroundImage")));
            this.pctFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctFoto.Location = new System.Drawing.Point(1393, 162);
            this.pctFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(147, 86);
            this.pctFoto.TabIndex = 27;
            this.pctFoto.TabStop = false;
            this.pctFoto.Visible = false;
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.Location = new System.Drawing.Point(16, 11);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(324, 41);
            this.lblBaslik.TabIndex = 25;
            this.lblBaslik.Text = "TakeBirGaming";
            // 
            // lblOyunKategori
            // 
            this.lblOyunKategori.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblOyunKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOyunKategori.Location = new System.Drawing.Point(1401, 95);
            this.lblOyunKategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOyunKategori.Name = "lblOyunKategori";
            this.lblOyunKategori.Size = new System.Drawing.Size(112, 30);
            this.lblOyunKategori.TabIndex = 23;
            this.lblOyunKategori.Text = "Oyunlar";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(1380, 129);
            this.cmbKategori.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(160, 24);
            this.cmbKategori.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kullanıcı Ayarları",
            "Çıkış Yap"});
            this.comboBox1.Location = new System.Drawing.Point(1532, -1);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1460, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 26);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.Location = new System.Drawing.Point(1307, -2);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(157, 27);
            this.lblUserName.TabIndex = 31;
            // 
            // lblStatu
            // 
            this.lblStatu.BackColor = System.Drawing.Color.Transparent;
            this.lblStatu.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStatu.Location = new System.Drawing.Point(1547, 774);
            this.lblStatu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatu.Name = "lblStatu";
            this.lblStatu.Size = new System.Drawing.Size(184, 47);
            this.lblStatu.TabIndex = 32;
            this.lblStatu.Text = "label1";
            // 
            // btnYorumYap
            // 
            this.btnYorumYap.Location = new System.Drawing.Point(127, 389);
            this.btnYorumYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnYorumYap.Name = "btnYorumYap";
            this.btnYorumYap.Size = new System.Drawing.Size(160, 41);
            this.btnYorumYap.TabIndex = 34;
            this.btnYorumYap.Text = "Yorum Yap";
            this.btnYorumYap.UseVisualStyleBackColor = true;
            this.btnYorumYap.Click += new System.EventHandler(this.btnYorumYap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtYorum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.btnYorumYap);
            this.groupBox1.Location = new System.Drawing.Point(1280, 256);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(451, 437);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yorum Giriş";
            this.groupBox1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Yorum:";
            // 
            // txtYorum
            // 
            this.txtYorum.Location = new System.Drawing.Point(16, 182);
            this.txtYorum.Margin = new System.Windows.Forms.Padding(4);
            this.txtYorum.Name = "txtYorum";
            this.txtYorum.Size = new System.Drawing.Size(433, 182);
            this.txtYorum.TabIndex = 37;
            this.txtYorum.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Başlık:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(67, 47);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(219, 22);
            this.txtTitle.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1549, 129);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 30);
            this.button2.TabIndex = 36;
            this.button2.Text = "Yorum Ekle:";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblComment3
            // 
            this.lblComment3.BackColor = System.Drawing.Color.Black;
            this.lblComment3.ForeColor = System.Drawing.Color.Snow;
            this.lblComment3.Location = new System.Drawing.Point(41, 582);
            this.lblComment3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComment3.Name = "lblComment3";
            this.lblComment3.Size = new System.Drawing.Size(908, 208);
            this.lblComment3.TabIndex = 33;
            this.lblComment3.Text = "label1";
            // 
            // lblComment2
            // 
            this.lblComment2.BackColor = System.Drawing.Color.Black;
            this.lblComment2.ForeColor = System.Drawing.Color.Snow;
            this.lblComment2.Location = new System.Drawing.Point(41, 368);
            this.lblComment2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComment2.Name = "lblComment2";
            this.lblComment2.Size = new System.Drawing.Size(908, 193);
            this.lblComment2.TabIndex = 33;
            this.lblComment2.Text = "label1";
            // 
            // lblComment1
            // 
            this.lblComment1.BackColor = System.Drawing.Color.Black;
            this.lblComment1.ForeColor = System.Drawing.Color.Snow;
            this.lblComment1.Location = new System.Drawing.Point(41, 129);
            this.lblComment1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComment1.Name = "lblComment1";
            this.lblComment1.Size = new System.Drawing.Size(908, 226);
            this.lblComment1.TabIndex = 33;
            this.lblComment1.Text = "label1";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(373, 11);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(777, 22);
            this.txtAra.TabIndex = 20;
            // 
            // btnAra
            // 
            this.btnAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAra.BackgroundImage")));
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAra.Location = new System.Drawing.Point(1153, 10);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(52, 26);
            this.btnAra.TabIndex = 21;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSayfaYenile
            // 
            this.btnSayfaYenile.Location = new System.Drawing.Point(81, 70);
            this.btnSayfaYenile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSayfaYenile.Name = "btnSayfaYenile";
            this.btnSayfaYenile.Size = new System.Drawing.Size(100, 28);
            this.btnSayfaYenile.TabIndex = 37;
            this.btnSayfaYenile.Text = "Yenile";
            this.btnSayfaYenile.UseVisualStyleBackColor = true;
            this.btnSayfaYenile.Click += new System.EventHandler(this.btnSayfaYenile_Click);
            // 
            // btnLike3
            // 
            this.btnLike3.Location = new System.Drawing.Point(956, 632);
            this.btnLike3.Name = "btnLike3";
            this.btnLike3.Size = new System.Drawing.Size(90, 33);
            this.btnLike3.TabIndex = 38;
            this.btnLike3.Text = "Beğen";
            this.btnLike3.UseVisualStyleBackColor = true;
            // 
            // btnDissLike3
            // 
            this.btnDissLike3.Location = new System.Drawing.Point(956, 705);
            this.btnDissLike3.Name = "btnDissLike3";
            this.btnDissLike3.Size = new System.Drawing.Size(90, 32);
            this.btnDissLike3.TabIndex = 38;
            this.btnDissLike3.Text = "Beğenme";
            this.btnDissLike3.UseVisualStyleBackColor = true;
            // 
            // btnLike1
            // 
            this.btnLike1.Location = new System.Drawing.Point(956, 162);
            this.btnLike1.Name = "btnLike1";
            this.btnLike1.Size = new System.Drawing.Size(90, 33);
            this.btnLike1.TabIndex = 38;
            this.btnLike1.Text = "Beğen";
            this.btnLike1.UseVisualStyleBackColor = true;
            // 
            // btnDissLike1
            // 
            this.btnDissLike1.Location = new System.Drawing.Point(956, 276);
            this.btnDissLike1.Name = "btnDissLike1";
            this.btnDissLike1.Size = new System.Drawing.Size(90, 32);
            this.btnDissLike1.TabIndex = 38;
            this.btnDissLike1.Text = "Beğenme";
            this.btnDissLike1.UseVisualStyleBackColor = true;
            // 
            // btnLike2
            // 
            this.btnLike2.Location = new System.Drawing.Point(956, 407);
            this.btnLike2.Name = "btnLike2";
            this.btnLike2.Size = new System.Drawing.Size(90, 33);
            this.btnLike2.TabIndex = 38;
            this.btnLike2.Text = "Beğen";
            this.btnLike2.UseVisualStyleBackColor = true;
            // 
            // btnDissLike2
            // 
            this.btnDissLike2.Location = new System.Drawing.Point(956, 480);
            this.btnDissLike2.Name = "btnDissLike2";
            this.btnDissLike2.Size = new System.Drawing.Size(90, 32);
            this.btnDissLike2.TabIndex = 38;
            this.btnDissLike2.Text = "Beğenme";
            this.btnDissLike2.UseVisualStyleBackColor = true;
            // 
            // lblBegeniSayi1
            // 
            this.lblBegeniSayi1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBegeniSayi1.Location = new System.Drawing.Point(971, 198);
            this.lblBegeniSayi1.Name = "lblBegeniSayi1";
            this.lblBegeniSayi1.Size = new System.Drawing.Size(64, 24);
            this.lblBegeniSayi1.TabIndex = 39;
            // 
            // lblBegenmeSayi1
            // 
            this.lblBegenmeSayi1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBegenmeSayi1.Location = new System.Drawing.Point(971, 311);
            this.lblBegenmeSayi1.Name = "lblBegenmeSayi1";
            this.lblBegenmeSayi1.Size = new System.Drawing.Size(64, 24);
            this.lblBegenmeSayi1.TabIndex = 39;
            // 
            // lblBegenSayi2
            // 
            this.lblBegenSayi2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBegenSayi2.Location = new System.Drawing.Point(971, 441);
            this.lblBegenSayi2.Name = "lblBegenSayi2";
            this.lblBegenSayi2.Size = new System.Drawing.Size(64, 24);
            this.lblBegenSayi2.TabIndex = 39;
            // 
            // lblBegenmeSayi2
            // 
            this.lblBegenmeSayi2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBegenmeSayi2.Location = new System.Drawing.Point(971, 515);
            this.lblBegenmeSayi2.Name = "lblBegenmeSayi2";
            this.lblBegenmeSayi2.Size = new System.Drawing.Size(64, 24);
            this.lblBegenmeSayi2.TabIndex = 39;
            // 
            // lblBegenmeSayi3
            // 
            this.lblBegenmeSayi3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBegenmeSayi3.Location = new System.Drawing.Point(971, 740);
            this.lblBegenmeSayi3.Name = "lblBegenmeSayi3";
            this.lblBegenmeSayi3.Size = new System.Drawing.Size(64, 24);
            this.lblBegenmeSayi3.TabIndex = 39;
            // 
            // lblBegenSayi3
            // 
            this.lblBegenSayi3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBegenSayi3.Location = new System.Drawing.Point(971, 668);
            this.lblBegenSayi3.Name = "lblBegenSayi3";
            this.lblBegenSayi3.Size = new System.Drawing.Size(64, 24);
            this.lblBegenSayi3.TabIndex = 39;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1741, 831);
            this.Controls.Add(this.lblBegenSayi3);
            this.Controls.Add(this.lblBegenmeSayi3);
            this.Controls.Add(this.lblBegenmeSayi2);
            this.Controls.Add(this.lblBegenSayi2);
            this.Controls.Add(this.lblBegenmeSayi1);
            this.Controls.Add(this.lblBegeniSayi1);
            this.Controls.Add(this.btnDissLike1);
            this.Controls.Add(this.btnDissLike2);
            this.Controls.Add(this.btnDissLike3);
            this.Controls.Add(this.btnLike2);
            this.Controls.Add(this.btnLike1);
            this.Controls.Add(this.btnLike3);
            this.Controls.Add(this.btnSayfaYenile);
            this.Controls.Add(this.lblComment1);
            this.Controls.Add(this.lblComment2);
            this.Controls.Add(this.lblComment3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStatu);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pctFoto);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblOyunKategori);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pctFoto;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblOyunKategori;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblStatu;
        private System.Windows.Forms.Button btnYorumYap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.RichTextBox txtYorum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblComment3;
        private System.Windows.Forms.Label lblComment2;
        private System.Windows.Forms.Label lblComment1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSayfaYenile;
        private System.Windows.Forms.Button btnLike3;
        private System.Windows.Forms.Button btnDissLike3;
        private System.Windows.Forms.Button btnLike1;
        private System.Windows.Forms.Button btnDissLike1;
        private System.Windows.Forms.Button btnLike2;
        private System.Windows.Forms.Button btnDissLike2;
        private System.Windows.Forms.Label lblBegeniSayi1;
        private System.Windows.Forms.Label lblBegenmeSayi1;
        private System.Windows.Forms.Label lblBegenSayi2;
        private System.Windows.Forms.Label lblBegenmeSayi2;
        private System.Windows.Forms.Label lblBegenmeSayi3;
        private System.Windows.Forms.Label lblBegenSayi3;
    }
}