namespace KutuphaneYonetimSistemi
{
    partial class FormGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            txtKullaniciAdi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSifre = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Blue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(274, 269);
            button1.Name = "button1";
            button1.Size = new Size(235, 39);
            button1.TabIndex = 0;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Cursor = Cursors.IBeam;
            txtKullaniciAdi.Font = new Font("Segoe UI", 9F);
            txtKullaniciAdi.Location = new Point(274, 101);
            txtKullaniciAdi.Margin = new Padding(3, 100, 3, 50);
            txtKullaniciAdi.Multiline = true;
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(233, 43);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 11F);
            label1.Location = new Point(91, 117);
            label1.Name = "label1";
            label1.Size = new Size(152, 27);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 11F);
            label2.Location = new Point(91, 195);
            label2.Name = "label2";
            label2.Size = new Size(71, 27);
            label2.TabIndex = 4;
            label2.Text = "Şifre :";
            // 
            // txtSifre
            // 
            txtSifre.Cursor = Cursors.IBeam;
            txtSifre.Location = new Point(274, 185);
            txtSifre.Margin = new Padding(3, 100, 3, 50);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(233, 43);
            txtSifre.TabIndex = 2;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(625, 475);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FormGiris";
            Text = "Kütüphane Yönetim Sistemi";
            Load += FormGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtKullaniciAdi;
        private Label label1;
        private Label label2;
        private TextBox txtSifre;
    }
}
