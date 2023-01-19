using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Cafe_Project
{
    public partial class manager_Workers_addNewAcc : DevExpress.XtraEditors.XtraForm
    {
        BaglantiSinif bgl = new BaglantiSinif();

        // SQL bağlantıları
        public manager_Workers_addNewAcc()
        {
            InitializeComponent();
        }
        private void manager_Workers_addNewAcc_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Ekran boyutunu ayarlamayı kapatır.
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            try
            {
                if (rdbtn_Manager.Checked == true)
                {
                    if (txtBox_Name.Text == " " || txtBox_SurName.Text == "" || txtBox_Username.Text == "" || txtBox_password.Text == "" || txtBox_PIN.Text == "")
                    {
                        MessageBox.Show("Lütfen boş bir değer girmeyiniz.", "UYARI !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        baglanti.Open();

                        SqlCommand cmd = new SqlCommand("INSERT INTO Manager_Account (name,surname,username,password,pin) VALUES ('" + txtBox_Name.Text + "','" + txtBox_SurName.Text + "', '" + txtBox_Username.Text + "', '" + txtBox_password.Text + "', '" + txtBox_PIN.Text + "')", baglanti);

                        int say = cmd.ExecuteNonQuery();

                        if (say > 0)
                        {
                            MessageBox.Show("Kayıt Başarıyla Eklendi", "Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                if (rdbtn_Chef.Checked == true)
                {
                    baglanti.Open();

                    if (txtBox_Name.Text == " " || txtBox_SurName.Text == "")
                    {
                        MessageBox.Show("Lütfen boş bir değer girmeyiniz.", "UYARI !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Chef_Account (name,surname) VALUES ('" + txtBox_Name.Text + "','" + txtBox_SurName.Text + "')", baglanti);

                        int say = cmd.ExecuteNonQuery();

                        if (say > 0)
                        {
                            MessageBox.Show("Kayıt Başarıyla Eklendi", "Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (rdbtn_AssistantChef.Checked == true)
                {
                    if (txtBox_Name.Text == " " || txtBox_SurName.Text == "")
                    {
                        MessageBox.Show("Lütfen boş bir değer girmeyiniz.", "UYARI !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        baglanti.Open();

                        SqlCommand cmd = new SqlCommand("INSERT INTO Assistant_Chef_Account (name,surname) VALUES ('" + txtBox_Name.Text + "','" + txtBox_SurName.Text + "')", baglanti);

                        int say = cmd.ExecuteNonQuery();

                        if (say > 0)
                        {
                            MessageBox.Show("Kayıt Başarıyla Eklendi", "Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                if (rdbtn_Waiter.Checked == true)
                {
                    if (txtBox_Name.Text == " " || txtBox_SurName.Text == "" || txtBox_Username.Text == "" || txtBox_password.Text == "" || txtBox_PIN.Text == "")
                    {
                        MessageBox.Show("Lütfen boş bir değer girmeyiniz.", "UYARI !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        baglanti.Open();

                        SqlCommand cmd = new SqlCommand("INSERT INTO Waiter_Account(name,surname,username,password,pin) VALUES ('" + txtBox_Name.Text + "','" + txtBox_SurName.Text + "', '" + txtBox_Username.Text + "', '" + txtBox_password.Text + "', '" + txtBox_PIN.Text + "')", baglanti);

                        int say = cmd.ExecuteNonQuery();

                        if (say > 0)
                        {
                            MessageBox.Show("Kayıt Başarıyla Eklendi", "Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                // radiobuttonları kontrol et. true değerini dönderiyorsa girilen bilgileri SQL tablosuna kaydet.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();

                // bağlantıları kapat
            }
        }
        private void rdbtn_Chef_CheckedChanged(object sender, EventArgs e)
        {
            btn_CreatePassword.Hide();
            btn_CreatePIN.Hide();
            txtBox_Username.Hide();
            txtBox_PIN.Hide();
            txtBox_password.Hide();
            lbl_UserName.Hide();
            lbl_Password.Hide();
            lbl_PIN.Hide();

            // textboxları , labelleri , butonları gizle
        }
        private void rdbtn_Manager_CheckedChanged(object sender, EventArgs e)
        {
            btn_CreatePassword.Show();
            btn_CreatePIN.Show();
            txtBox_Username.Show();
            txtBox_PIN.Show();
            txtBox_password.Show();
            lbl_UserName.Show();
            lbl_Password.Show();
            lbl_PIN.Show();

            // textboxları , labelleri , butonları göster
        }
        private void rdbtn_AssitantChef_CheckedChanged(object sender, EventArgs e)
        {
            btn_CreatePassword.Hide();
            btn_CreatePIN.Hide();
            txtBox_Username.Hide();
            txtBox_PIN.Hide();
            txtBox_password.Hide();
            lbl_UserName.Hide();
            lbl_Password.Hide();
            lbl_PIN.Hide();

            // textboxları , labelleri , butonları gizle
        }
        private void rdbtn_Waiter_CheckedChanged(object sender, EventArgs e)
        {
            btn_CreatePassword.Show();
            btn_CreatePIN.Show();
            txtBox_Username.Show();
            txtBox_PIN.Show();
            txtBox_password.Show();
            lbl_UserName.Show();
            lbl_Password.Show();
            lbl_PIN.Show();

            // textboxları , labelleri , butonları göster
        }
        private void btn_CreatePassword_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string karakterler = "*-_<@>qwertyuıopasdfghjklşizxcvbnm.1234567890";
            string sonuc = "";

            for (int i = 0; i < 11; i++)
            {
                sonuc += karakterler[random.Next(karakterler.Length)];
            }

            txtBox_password.Text = sonuc;

            // Şifre oluşturma butonuna tıkladındığında rastgele 11 haneli şifre oluştur.
        }
        private void btn_CreatePIN_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string karakterler = "1234567890";
            string sonuc = "";

            for (int i = 0; i < 11; i++)
            {
                sonuc += karakterler[random.Next(karakterler.Length)];
            }

            txtBox_PIN.Text = sonuc;

            // PIN oluşturma butonuna tıkladındığında rastgele 11 haneli pin oluştur.
        }
    }
}