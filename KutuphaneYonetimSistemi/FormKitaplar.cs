using System;    //
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;  // DataTable için gerekli
using System.Data.Common;
using Microsoft.Data.SqlClient;   // SQL kütüphanesi
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimSistemi
{
    public partial class FormKitaplar : Form
    {
        public FormKitaplar()
        {
            InitializeComponent();
        }


        private void verileriGoster()
        {

            try
            {
                using (SqlConnection sqlbaglanti = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = DbKutuphane; Integrated Security = True; Encrypt=True; TrustServerCertificate=True;"))
                {
                    //komut cümlesini yazıyoruz
                    string q = "SELECT * FROM Table_Kitaplar ";

                    // SqlDatapAdapter ile verileri çekiyoruz
                    SqlDataAdapter sqldataadapter = new SqlDataAdapter(q, sqlbaglanti);

                    // DateTable ile verileri Ram' de geçici olarak tutarız
                    DataTable dt = new DataTable();

                    // Adapter çalıştı ve datayı tabloya doldurdu,sql bağlantısı otomatik açılır,kapanır.
                    sqldataadapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {

                        //DataGridView' e tabloyu bağladık
                        dataGridViewKitaplar.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Veri bulunamadı!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void FormKitaplar_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }

        //KİTAP EKLEME 
        private void btnkitapekle_Click(object sender, EventArgs e)  
        {

            try
            {
                using (SqlConnection sqlbaglanti = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = DbKutuphane; Integrated Security = True; Encrypt=True; TrustServerCertificate=True;"))
                {
                    sqlbaglanti.Open();

                    string eklemeSorgusu = "INSERT INTO Table_Kitaplar(KitapAdi, YazarAdi, YazarSoyadi, ISBN, Durum, KitapTurKodu) VALUES (@P1, @P2, @P3, @P4, @P5, @P6)";
                    using (SqlCommand sqlCommand = new SqlCommand(eklemeSorgusu, sqlbaglanti))
                    {
                        sqlCommand.Parameters.AddWithValue("@P1", txtBoxKitapAd.Text);
                        sqlCommand.Parameters.AddWithValue("@P2", txtBoxYazarAd.Text);
                        sqlCommand.Parameters.AddWithValue("@P3", txtBoxYazarSoyad.Text);
                        sqlCommand.Parameters.AddWithValue("@P4", txtBoxIsbn.Text);
                        sqlCommand.Parameters.AddWithValue("@P5", "True");
                        sqlCommand.Parameters.AddWithValue("@P6", txtBoxKitapTurKodu.Text);

                        sqlCommand.ExecuteNonQuery();
                    }
                }

                verileriGoster();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Ekleme başarısız." + ex.Message);
            }

        }
        //ÖDÜNÇ VERME
        private void btnoduncver_Click(object sender, EventArgs e)
        {
            if (txtBoxKitapId.Text != " ")
            {

                    try
                    {
                        using (SqlConnection sqlbaglanti = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = DbKutuphane; Integrated Security = True; Encrypt=True; TrustServerCertificate=True;"))
                        {
                            sqlbaglanti.Open();

                            string sorgu = "UPDATE Table_Kitaplar SET Durum = @P1, OduncAlanNo = @P2, OduncAlmaTarihi= @P3 Where ID = @P4";
                            using (SqlCommand komut = new SqlCommand(sorgu, sqlbaglanti))
                            {
                                komut.Parameters.AddWithValue("@P1", "False");
                                komut.Parameters.AddWithValue("@P2", txtBoxOduncAlanNo.Text);
                                komut.Parameters.Add("@P3", SqlDbType.Date).Value = dateTimePickerOduncVermeTarihi.Value.Date;
                                komut.Parameters.AddWithValue("@P4", txtBoxKitapId.Text);
                                komut.ExecuteNonQuery();

                            }

                        }

                        verileriGoster();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu! " + ex.Message);
                    }

            }
            else
            {
                MessageBox.Show("Lütfen listeden kitap seçiniz!");
            }
        }

        private void dataGridViewKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // selectedcells bir koleksiyondur.Doğrudan bir hücreye erişmek için [0] kullanmalıyız.
            int secilenSatir = dataGridViewKitaplar.SelectedCells[0].RowIndex;
            txtBoxKitapId.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[0].Value.ToString();
            txtBoxKitapAd.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[1].Value.ToString();
            txtBoxYazarAd.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[2].Value.ToString();
            txtBoxYazarSoyad.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[3].Value.ToString();
            txtBoxIsbn.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[4].Value.ToString();
            txtBoxKitapTurKodu.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[8].Value.ToString();
            label10.Text = "";

            txtBoxOduncAlanNo.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[6].Value.ToString(); //null hatası vermez

            //OduncVermeTarihi null olan hücrelerde hatayı engellemek için if kullanıyoruz
            if (dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value != DBNull.Value)
                dateTimePickerOduncVermeTarihi.Value = (DateTime)dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value;


        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection sqlbaglanti = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = DbKutuphane; Integrated Security = True; Encrypt = True; TrustServerCertificate = True;"))
                {
                    sqlbaglanti.Open();

                    string guncellemeSorgusu = "UPDATE Table_Kitaplar SET KitapAdi =@P1, YazarAdi = @P2, YazarSoyadi = @P3, ISBN = @P4, Durum = @P5, KitapTurKodu = @P6 WHERE ID = @P7 ";
                    using (SqlCommand sqlCommand = new SqlCommand(guncellemeSorgusu, sqlbaglanti))
                    {

                        sqlCommand.Parameters.AddWithValue("@P1", txtBoxKitapAd.Text);
                        sqlCommand.Parameters.AddWithValue("@P2", txtBoxYazarAd.Text);
                        sqlCommand.Parameters.AddWithValue("@P3", txtBoxYazarSoyad.Text);
                        sqlCommand.Parameters.AddWithValue("@P4", txtBoxIsbn.Text);
                       // sqlCommand.Parameters.AddWithValue("@P5", );
                        sqlCommand.Parameters.AddWithValue("@P6", txtBoxKitapTurKodu.Text);
                        sqlCommand.Parameters.AddWithValue("@P7", txtBoxKitapId.Text);

                        if (string.IsNullOrWhiteSpace(txtBoxOduncAlanNo.Text))
                        {
                            sqlCommand.Parameters.AddWithValue("@P5", "True");
                        }

                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@P5", "False");

                        }

                        sqlCommand.ExecuteNonQuery();
                    }

                }

                verileriGoster();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme Hatası. " + ex.Message);
            }

        }
        //GECİKME BEDELİ HESAPLAMA
        private void btnhesapla_Click(object sender, EventArgs e)
        {

            if (txtBoxKitapId != null)
            {
                DateTime bugununTarihi = DateTime.Today;
                int gunFarki = (int)(bugununTarihi - dateTimePickerOduncVermeTarihi.Value.Date).TotalDays;

                if (gunFarki > 10)
                {
                    int gecikmeBedeli = (gunFarki - 10) * 5;
                    label10.Text = gecikmeBedeli.ToString();
                }
                else
                {
                    int gecikmeBedeli = 0;
                    label10.Text = gecikmeBedeli.ToString();
                }
            }
        }

        private void btniadeet_Click(object sender, EventArgs e)
        {
            if (txtBoxKitapId != null)
            {
                try
                {
                    using (SqlConnection sqlbaglanti = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = DbKutuphane; Integrated Security = True; Encrypt=True; TrustServerCertificate=True;"))
                    {
                        sqlbaglanti.Open();

                        string sorgu = "UPDATE Table_Kitaplar SET Durum = @P1, OduncAlanNo = @P2, OduncAlmaTarihi= @P3 Where ID = @P4";
                        using (SqlCommand komut = new SqlCommand(sorgu, sqlbaglanti))
                        {
                            komut.Parameters.AddWithValue("@P1", "True");
                            komut.Parameters.AddWithValue("@P2", DBNull.Value);
                            komut.Parameters.Add("@P3", SqlDbType.Date).Value = DBNull.Value;
                            komut.Parameters.AddWithValue("@P4", txtBoxKitapId.Text);
                            komut.ExecuteNonQuery();
                            //txtBoxOduncAlanNo.Text = "";

                        }

                    }

                    verileriGoster();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme Hatası. " + ex.Message);
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            txtBoxKitapId.Text = "";
            txtBoxKitapAd.Text = "";
            txtBoxYazarAd.Text = "";
            txtBoxYazarSoyad.Text = "";
            txtBoxIsbn.Text = "";
            txtBoxKitapTurKodu.Text = "";
            txtBoxOduncAlanNo.Text = "";
            verileriGoster();
        }



        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridViewKitaplar.DataSource = null;  // her yeni aramada datagridview temizlenerek arama başlatılır.
            aramaSonuclariniGoster();
        }

        private void aramaSonuclariniGoster()
        {
            try
            {
                using (SqlConnection sqlbaglanti = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = DbKutuphane; Integrated Security = True; Encrypt=True; TrustServerCertificate=True;"))

                {
                    string q = "SELECT * FROM Table_Kitaplar WHERE KitapAdi LIKE @a1" +
                                                                  " AND YazarAdi LIKE @a2" +
                                                                  " AND YazarSoyadi LIKE @a3" +
                                                                  " AND ISBN LIKE @a4" +
                                                                  " AND CAST(KitapTurKodu AS VARCHAR) LIKE @a6";
                    //  txtBoxOduncAlanNo boş bırakıldığında filtrelemeyi if e göre yapacak                         
                    if (string.IsNullOrWhiteSpace(txtBoxOduncAlanNo.Text))
                    {
                        q += " AND OduncAlanNo IS NULL OR OduncAlanNo IS NOT NULL";
                    }

                    // txtBoxOduncAlanNo boş değilse filtrelemeyi elseye göre yapacak
                    else
                    {
                        q += " AND CAST(OduncAlanNo AS VARCHAR) LIKE @a5";
                    }


                    SqlCommand komut = new SqlCommand(q, sqlbaglanti);
                    komut.Parameters.AddWithValue("@a1", txtBoxKitapAd.Text + "%");
                    komut.Parameters.AddWithValue("@a2", txtBoxYazarAd.Text + "%");
                    komut.Parameters.AddWithValue("@a3", txtBoxYazarSoyad.Text + "%");
                    komut.Parameters.AddWithValue("@a4", txtBoxIsbn.Text + "%");
                    komut.Parameters.AddWithValue("@a6", txtBoxKitapTurKodu.Text + "%");
                    if (!string.IsNullOrWhiteSpace(txtBoxOduncAlanNo.Text))
                    {
                        komut.Parameters.AddWithValue("@a5", txtBoxOduncAlanNo.Text + "%");
                    }

                    // SqlDatapAdapter ile verileri çekiyoruz
                    SqlDataAdapter sqldataadapter = new SqlDataAdapter(komut);


                    // DateTable ile verileri Ram' de geçici olarak tutarız
                    DataTable dt = new DataTable();

                    // Adapter çalıştı ve datayı tabloya doldurdu,sql bağlantısı otomatik açılır,kapanır.
                    sqldataadapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {

                        //DataGridView' e tabloyu bağladık
                        dataGridViewKitaplar.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Veri bulunamadı!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBoxKitapId.Text != "")
            {
                try
                {

                    using (SqlConnection sqlbaglanti = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = DbKutuphane; Integrated Security = True; Encrypt=True; TrustServerCertificate=True;"))

                    {
                        sqlbaglanti.Open();
                        string q = "DELETE FROM Table_Kitaplar WHERE ID= @d1 ";

                        SqlCommand komut = new SqlCommand(q, sqlbaglanti);

                        komut.Parameters.AddWithValue("@d1", txtBoxKitapId.Text);
                        komut.ExecuteNonQuery();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("HATA!" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kitap seçiniz!");
            }

            verileriGoster();
            Temizle();

        }

        private void FormKitaplar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePickerOduncVermeTarihi_ValueChanged(object sender, EventArgs e)
        {

        }
    }
} 
