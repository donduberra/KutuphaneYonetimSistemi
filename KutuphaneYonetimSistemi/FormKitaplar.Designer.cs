namespace KutuphaneYonetimSistemi
{
    partial class FormKitaplar
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
            groupBox1 = new GroupBox();
            btnSil = new Button();
            btnAra = new Button();
            btnTemizle = new Button();
            txtBoxKitapId = new TextBox();
            btnkitapekle = new Button();
            btnguncelle = new Button();
            txtBoxYazarAd = new TextBox();
            txtBoxYazarSoyad = new TextBox();
            txtBoxKitapTurKodu = new TextBox();
            txtBoxIsbn = new TextBox();
            txtBoxKitapAd = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnoduncver = new Button();
            dateTimePickerOduncVermeTarihi = new DateTimePicker();
            txtBoxOduncAlanNo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            btniadeet = new Button();
            btnhesapla = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            dataGridViewKitaplar = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnAra);
            groupBox1.Controls.Add(btnTemizle);
            groupBox1.Controls.Add(txtBoxKitapId);
            groupBox1.Controls.Add(btnkitapekle);
            groupBox1.Controls.Add(btnguncelle);
            groupBox1.Controls.Add(txtBoxYazarAd);
            groupBox1.Controls.Add(txtBoxYazarSoyad);
            groupBox1.Controls.Add(txtBoxKitapTurKodu);
            groupBox1.Controls.Add(txtBoxIsbn);
            groupBox1.Controls.Add(txtBoxKitapAd);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(678, 444);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Kayıt ve Güncelleme";
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.Control;
            btnSil.Location = new Point(580, 359);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(72, 58);
            btnSil.TabIndex = 19;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += button1_Click;
            // 
            // btnAra
            // 
            btnAra.BackColor = SystemColors.Control;
            btnAra.Location = new Point(502, 359);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(72, 58);
            btnAra.TabIndex = 18;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(344, 359);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(142, 58);
            btnTemizle.TabIndex = 17;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // txtBoxKitapId
            // 
            txtBoxKitapId.Location = new Point(214, 54);
            txtBoxKitapId.Name = "txtBoxKitapId";
            txtBoxKitapId.Size = new Size(360, 31);
            txtBoxKitapId.TabIndex = 16;
            // 
            // btnkitapekle
            // 
            btnkitapekle.Location = new Point(185, 359);
            btnkitapekle.Name = "btnkitapekle";
            btnkitapekle.Size = new Size(142, 58);
            btnkitapekle.TabIndex = 15;
            btnkitapekle.Text = "Yeni Kitap Ekle";
            btnkitapekle.UseVisualStyleBackColor = true;
            btnkitapekle.Click += btnkitapekle_Click;
            // 
            // btnguncelle
            // 
            btnguncelle.Location = new Point(26, 359);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(144, 58);
            btnguncelle.TabIndex = 14;
            btnguncelle.Text = "Kitap Bilgilerini Güncelle";
            btnguncelle.UseVisualStyleBackColor = true;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // txtBoxYazarAd
            // 
            txtBoxYazarAd.Location = new Point(214, 145);
            txtBoxYazarAd.Name = "txtBoxYazarAd";
            txtBoxYazarAd.Size = new Size(360, 31);
            txtBoxYazarAd.TabIndex = 13;
            // 
            // txtBoxYazarSoyad
            // 
            txtBoxYazarSoyad.Location = new Point(214, 190);
            txtBoxYazarSoyad.Name = "txtBoxYazarSoyad";
            txtBoxYazarSoyad.Size = new Size(360, 31);
            txtBoxYazarSoyad.TabIndex = 12;
            // 
            // txtBoxKitapTurKodu
            // 
            txtBoxKitapTurKodu.Location = new Point(214, 283);
            txtBoxKitapTurKodu.Name = "txtBoxKitapTurKodu";
            txtBoxKitapTurKodu.Size = new Size(360, 31);
            txtBoxKitapTurKodu.TabIndex = 11;
            // 
            // txtBoxIsbn
            // 
            txtBoxIsbn.Location = new Point(214, 236);
            txtBoxIsbn.Name = "txtBoxIsbn";
            txtBoxIsbn.Size = new Size(360, 31);
            txtBoxIsbn.TabIndex = 9;
            // 
            // txtBoxKitapAd
            // 
            txtBoxKitapAd.Location = new Point(214, 99);
            txtBoxKitapAd.Name = "txtBoxKitapAd";
            txtBoxKitapAd.Size = new Size(360, 31);
            txtBoxKitapAd.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(26, 284);
            label6.Name = "label6";
            label6.Size = new Size(179, 30);
            label6.TabIndex = 7;
            label6.Text = "Kitap Tür Kodu :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(26, 237);
            label5.Name = "label5";
            label5.Size = new Size(75, 30);
            label5.TabIndex = 6;
            label5.Text = "ISBN :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(26, 191);
            label4.Name = "label4";
            label4.Size = new Size(149, 30);
            label4.TabIndex = 5;
            label4.Text = "Yazar Soyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(26, 146);
            label3.Name = "label3";
            label3.Size = new Size(115, 30);
            label3.TabIndex = 4;
            label3.Text = "Yazar Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(26, 100);
            label2.Name = "label2";
            label2.Size = new Size(121, 30);
            label2.TabIndex = 3;
            label2.Text = "Kitap Ad : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(26, 56);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 2;
            label1.Text = "Kitap ID :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnoduncver);
            groupBox2.Controls.Add(dateTimePickerOduncVermeTarihi);
            groupBox2.Controls.Add(txtBoxOduncAlanNo);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(671, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 444);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap Ödünç Alma";
            // 
            // btnoduncver
            // 
            btnoduncver.Location = new Point(106, 359);
            btnoduncver.Name = "btnoduncver";
            btnoduncver.Size = new Size(136, 58);
            btnoduncver.TabIndex = 16;
            btnoduncver.Text = "Ödünç Ver";
            btnoduncver.UseVisualStyleBackColor = true;
            btnoduncver.Click += btnoduncver_Click;
            // 
            // dateTimePickerOduncVermeTarihi
            // 
            dateTimePickerOduncVermeTarihi.Location = new Point(165, 100);
            dateTimePickerOduncVermeTarihi.Name = "dateTimePickerOduncVermeTarihi";
            dateTimePickerOduncVermeTarihi.Size = new Size(165, 31);
            dateTimePickerOduncVermeTarihi.TabIndex = 11;
            dateTimePickerOduncVermeTarihi.ValueChanged += dateTimePickerOduncVermeTarihi_ValueChanged;
            // 
            // txtBoxOduncAlanNo
            // 
            txtBoxOduncAlanNo.Location = new Point(165, 55);
            txtBoxOduncAlanNo.Name = "txtBoxOduncAlanNo";
            txtBoxOduncAlanNo.Size = new Size(183, 31);
            txtBoxOduncAlanNo.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.Location = new Point(13, 98);
            label8.Name = "label8";
            label8.Size = new Size(82, 30);
            label8.TabIndex = 5;
            label8.Text = "Tarih : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(13, 56);
            label7.Name = "label7";
            label7.Size = new Size(157, 30);
            label7.TabIndex = 4;
            label7.Text = "Ödünç Alan :  ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btniadeet);
            groupBox3.Controls.Add(btnhesapla);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(1044, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(351, 444);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kitap İade";
            // 
            // btniadeet
            // 
            btniadeet.Location = new Point(190, 359);
            btniadeet.Name = "btniadeet";
            btniadeet.Size = new Size(136, 58);
            btniadeet.TabIndex = 17;
            btniadeet.Text = "Kitabı İade Et";
            btniadeet.UseVisualStyleBackColor = true;
            btniadeet.Click += btniadeet_Click;
            // 
            // btnhesapla
            // 
            btnhesapla.Location = new Point(34, 359);
            btnhesapla.Name = "btnhesapla";
            btnhesapla.Size = new Size(136, 58);
            btnhesapla.TabIndex = 16;
            btnhesapla.Text = "Gecikme Bedeli Hesapla";
            btnhesapla.UseVisualStyleBackColor = true;
            btnhesapla.Click += btnhesapla_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label11.Location = new Point(289, 55);
            label11.Name = "label11";
            label11.Size = new Size(37, 30);
            label11.TabIndex = 14;
            label11.Text = "TL";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.Location = new Point(208, 56);
            label10.Name = "label10";
            label10.Size = new Size(26, 30);
            label10.TabIndex = 13;
            label10.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.Location = new Point(6, 56);
            label9.Name = "label9";
            label9.Size = new Size(196, 30);
            label9.TabIndex = 12;
            label9.Text = "Gecikme Bedeli :  ";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewKitaplar);
            groupBox4.Location = new Point(4, 450);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1180, 254);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kitap Listesi";
            // 
            // dataGridViewKitaplar
            // 
            dataGridViewKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKitaplar.Dock = DockStyle.Fill;
            dataGridViewKitaplar.Location = new Point(3, 27);
            dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            dataGridViewKitaplar.RowHeadersWidth = 62;
            dataGridViewKitaplar.Size = new Size(1174, 224);
            dataGridViewKitaplar.TabIndex = 3;
            dataGridViewKitaplar.CellClick += dataGridViewKitaplar_CellClick;
            // 
            // FormKitaplar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 706);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormKitaplar";
            Text = "Kütüphane Yönetim Sistemi";
            FormClosed += FormKitaplar_FormClosed;
            Load += FormKitaplar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBoxYazarAd;
        private TextBox txtBoxYazarSoyad;
        private TextBox txtBoxKitapTurKodu;
        private TextBox txtBoxIsbn;
        private TextBox txtBoxKitapAd;
        private Button btnguncelle;
        private GroupBox groupBox4;
        private DataGridView dataGridViewKitaplar;
        private Button btnkitapekle;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimePickerOduncVermeTarihi;
        private TextBox txtBoxOduncAlanNo;
        private Label label10;
        private Label label9;
        private Button btniadeet;
        private Button btnhesapla;
        private Label label11;
        private Button btnoduncver;
        private TextBox txtBoxKitapId;
        private Button btnTemizle;
        private Button btnAra;
        private Button btnSil;
    }
}