using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cafe_Project
{
    public partial class manager_List_Add : DevExpress.XtraEditors.XtraForm
    {
        BaglantiSinif bgl = new BaglantiSinif();

        // SQL bağlantısını açar.
        public manager_List_Add()
        {
            InitializeComponent();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            try
            {
                if (rdbtn_Coffe.Checked == true)
                {
                    if (txtBox_Name.Text == " " || txtBox_Price.Text == "")
                    {
                        MessageBox.Show("Lütfen boş bir değer girmeyiniz.", "UYARI !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                        }

                        using (SqlCommand add = new SqlCommand(@"INSERT INTO Coffe (name,price) VALUES (@name, @price)", baglanti))
                        {
                            add.Parameters.Add("@name", SqlDbType.VarChar).Value = txtBox_Name.Text;
                            decimal.TryParse(txtBox_Price.Text, out decimal price);
                            add.Parameters.Add("@price", SqlDbType.Decimal).Value = price;

                            int say = add.ExecuteNonQuery();

                            if (say > 0)
                            {
                                MessageBox.Show("Kayıt Başarıyla Eklendi", "Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        
                    }
                    baglanti.Close();
                }
                if (rdbtn_Drink.Checked == true)
                {
                    if (txtBox_Name.Text == " " || txtBox_Price.Text == "")
                    {
                        MessageBox.Show("Lütfen boş bir değer girmeyiniz.", "UYARI !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                        }

                        using (SqlCommand add = new SqlCommand(@"INSERT INTO Drinks (name,price) VALUES (@name, @price)", baglanti))
                        {
                            add.Parameters.Add("@name", SqlDbType.VarChar).Value = txtBox_Name.Text;
                            decimal.TryParse(txtBox_Price.Text, out decimal price);
                            add.Parameters.Add("@price", SqlDbType.Decimal).Value = price;

                            int say = add.ExecuteNonQuery();

                            if (say > 0)
                            {
                                MessageBox.Show("Kayıt Başarıyla Eklendi", "Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    baglanti.Close();
                }
                if (rdbtn_Sweet.Checked == true)
                {
                    if (txtBox_Name.Text == " " || txtBox_Price.Text == "")
                    {
                        MessageBox.Show("Lütfen boş bir değer girmeyiniz.", "UYARI !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                        }

                        using (SqlCommand add = new SqlCommand(@"INSERT INTO Sweets (name,price) VALUES (@name, @price)", baglanti))
                        {
                            add.Parameters.Add("@name", SqlDbType.VarChar).Value = txtBox_Name.Text;
                            decimal.TryParse(txtBox_Price.Text, out decimal price);
                            add.Parameters.Add("@price", SqlDbType.Decimal).Value = price;

                            int say = add.ExecuteNonQuery();

                            if (say > 0)
                            {
                                MessageBox.Show("Kayıt Başarıyla Eklendi", "Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    baglanti.Close();
                }
                // radiobuttonları kontrol et. true değerini dönderiyorsa girilen bilgileri SQL tablosuna kaydet.
            }
            catch (Exception)
            {
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
                // bağlantıyı kapat
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();

            // Formu kapat.
        }

        public Point mouseLocation;
        private void manager_List_Add_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void manager_List_Add_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;

                // Formun hareket edebilmesini sağlar.
            }
        }
        private void txtBox_Price_Click(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtBox_Price.Select(0, 0);
            });

            // txtBox_Date textboxına tıklandığında mouse en başa gelir.
        }
    }
}