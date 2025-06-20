using System.Data.SqlClient;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace KutuphaneYonetimSistemi
{
    public partial class FormGiris : Form
    {
        FormKitaplar formKitaplar;
        public FormGiris()
        {

            InitializeComponent();

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifre = " ";
            using (SqlConnection sqlbaglanti = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = DbKutuphane; Integrated Security = True"))
            {
                try
                {

                    sqlbaglanti.Open();


                   
                    using (SqlCommand komut = new SqlCommand("Select Sifre From TableKutuphaneYoneticileri Where KullaniciAdi=@p1", sqlbaglanti))
                    {
                        komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                        using (SqlDataReader sqlDataReader = komut.ExecuteReader())

                        {
                            while (sqlDataReader.Read())
                            {
                                sifre = sqlDataReader["Sifre"].ToString();
                            }
                        }

                    }



                    if (sifre == txtSifre.Text)
                    {
                        // MessageBox.Show("Þifre Doðru.");
                        txtSifre.Text = "";
                        txtKullaniciAdi.Text = "";
                        formKitaplar=new FormKitaplar();  
                        formKitaplar.Show();
                        this.Hide();      // baþarýlý olduðunda bu formu sakla

                    }
                    else
                    {
                        MessageBox.Show("Kullanýcý Adý veya Þifre Hatalý.");
                        txtSifre.Text = "";
                        txtKullaniciAdi.Text = "";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Baðlantý Hatasý!" + ex.Message);
                }
                /*finally
                {
                    sqlbaglanti.Close();
                }*/

            }





        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
