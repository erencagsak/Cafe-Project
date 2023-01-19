using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Cafe_Project
{
    public partial class Lgin_Page : DevExpress.XtraEditors.XtraForm
    {
        BaglantiSinif bgl = new BaglantiSinif();

        // SQL bağlantısı

        public Lgin_Page()
        {
            InitializeComponent();
        }

        private void Lgin_Page_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Ekran boyutunu ayarlamayı kapatır.
        }

        public static string outgoingInformation = "";

        // manager_homePage formunda sağ üstte labela giriş bilgilerini yazdır.

        private void Lgin_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult warningLoginPage = MessageBox.Show("Programı kapatmak istediğinizden emin misiniz ? ", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warningLoginPage == DialogResult.No)
            {
                e.Cancel = true;
                return;

            }
            // X işaretiyle çıkarken uyarı geliyor ekranımıza(Kontrollü çıkış)
        }

        private void btn_LoginManager_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            baglanti.Open();

            string user = txtBox_Name.Text;
            string pass = txtBox_Password.Text;
            string pin = txtBox_PIN.Text;

            string komutCumlesi = "SELECT * FROM Manager_Account WHERE username='" + user + "' AND password='" + pass + "' AND pin='" + pin + "' ";

            SqlCommand cmdManager = new SqlCommand(komutCumlesi, baglanti); ;
            SqlDataReader readerManager;

            readerManager = cmdManager.ExecuteReader();

            // SQL tablolalarından verileri çeker.

            if (readerManager.Read())
            {
                outgoingInformation = txtBox_Name.Text;

                manager_homePage manager_homePage = new manager_homePage();

                manager_homePage.Show();
                this.Hide();
            }
            else
            {
                DialogResult errorPassUsername = MessageBox.Show("Kullanıcı adınız, şifreniz veya PIN kodunuz yanlış. Lütfen kontrol ediniz.", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            baglanti.Close();

            // Yönetici olarak giriş yap butonuna tıklandığında eğer kullanıcı adı, şifre ve pin SQL verilerindeki bilgilerle uyuşuyorsa giriş yapar uyuşmuyorsa ekrana hata kodu gönderir.
        }
        private void btn_LoginWaiter_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            baglanti.Open();

            string user = txtBox_Name.Text;
            string pass = txtBox_Password.Text;
            string pin = txtBox_PIN.Text;

            string komutCumlesi = "SELECT * FROM Waiter_Account WHERE username='" + user + "' AND password='" + pass + "' AND pin='" + pin + "' ";

            SqlCommand cmdEmployee = new SqlCommand(komutCumlesi, baglanti);
            SqlDataReader readerEmployee;

            readerEmployee = cmdEmployee.ExecuteReader();

            // SQL tablolalarından verileri çeker.

            if (readerEmployee.Read())
            {
                outgoingInformation = txtBox_Name.Text;

                employee_homePage employee_homePage = new employee_homePage();

                employee_homePage.Show();
                this.Hide();
            }
            else
            {
                DialogResult errorPassUsername = MessageBox.Show("Kullanıcı adınız, şifreniz veya PIN kodunuz yanlış. Lütfen kontrol ediniz.", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            baglanti.Close();

            // Garson olarak giriş yap butonuna tıklandığında eğer kullanıcı adı, şifre ve pin SQL verilerindeki bilgilerle uyuşuyorsa giriş yapar uyuşmuyorsa ekrana hata kodu gönderir.
        }

        private void txtBox_PIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            //Kullanıcı PIN kısmına sadece rakam girebilir.
        }
        private void pictureBox_Password_MouseDown(object sender, MouseEventArgs e)
        {
            txtBox_PIN.UseSystemPasswordChar = false;

            // şifreyi göster
        }
        private void pictureBox_Password_MouseUp(object sender, MouseEventArgs e)
        {
            txtBox_PIN.UseSystemPasswordChar = true;

            // şifreyi göster
        }
    }
}