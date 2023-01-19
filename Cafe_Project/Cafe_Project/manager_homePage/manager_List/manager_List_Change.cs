using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cafe_Project
{
    public partial class manager_List_Change : DevExpress.XtraEditors.XtraForm
    {
        BaglantiSinif bgl = new BaglantiSinif();

        // SQL bağlantıları

        public manager_List_Change()
        {
            InitializeComponent();
        }
        private void dataGridView_Manager_List_Change_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBox_Name.Text = dataGridView_Manager_List_Change.CurrentRow.Cells[1].Value.ToString();
            txtBox_Price.Text = dataGridView_Manager_List_Change.CurrentRow.Cells[2].Value.ToString();
            txtBox_ID.Text = dataGridView_Manager_List_Change.CurrentRow.Cells[0].Value.ToString();

            // txtboxlara SQL verilerini gönder ve ekranda göster.
        }

        private void btn_Coffe_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlDataAdapter adapterManager = new SqlDataAdapter("SELECT id,name,price FROM Coffe", baglanti);
            DataTable tableSweetsANDDrinks = new DataTable();
            adapterManager.Fill(tableSweetsANDDrinks);

            tableSweetsANDDrinks.Columns["id"].ColumnName = "ID";
            tableSweetsANDDrinks.Columns["name"].ColumnName = "İsim";
            tableSweetsANDDrinks.Columns["price"].ColumnName = "Fiyat";

            // Kolon isimlerini düzenle.

            dataGridView_Manager_List_Change.DataSource = tableSweetsANDDrinks;

            dataGridView_Manager_List_Change.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

            // Tablonun font ayarını düzenle.

            baglanti.Close();
        }

        private void btn_Drink_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlDataAdapter adapterManager = new SqlDataAdapter("SELECT id,name,price FROM Drinks", baglanti);
            DataTable tableSweetsANDDrinks = new DataTable();
            adapterManager.Fill(tableSweetsANDDrinks);

            tableSweetsANDDrinks.Columns["id"].ColumnName = "ID";
            tableSweetsANDDrinks.Columns["name"].ColumnName = "İsim";
            tableSweetsANDDrinks.Columns["price"].ColumnName = "Fiyat";

            // Kolon isimlerini düzenle.

            dataGridView_Manager_List_Change.DataSource = tableSweetsANDDrinks;

            dataGridView_Manager_List_Change.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

            // Tablonun font ayarını düzenle.

            baglanti.Close();
        }

        private void btn_Sweet_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlDataAdapter adapterManager = new SqlDataAdapter("SELECT id,name,price FROM Sweets", baglanti);
            DataTable tableSweetsANDDrinks = new DataTable();
            adapterManager.Fill(tableSweetsANDDrinks);

            tableSweetsANDDrinks.Columns["id"].ColumnName = "ID";
            tableSweetsANDDrinks.Columns["name"].ColumnName = "İsim";
            tableSweetsANDDrinks.Columns["price"].ColumnName = "Fiyat";

            // Kolon isimlerini düzenle.

            dataGridView_Manager_List_Change.DataSource = tableSweetsANDDrinks;

            dataGridView_Manager_List_Change.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

            // Tablonun font ayarını düzenle.

            baglanti.Close();
        }

        private void btn_changeList_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            try
            {
                if (btn_Coffe.Checked == true)
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    string save = "UPDATE Coffe SET name = @name, price = @price WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(save, baglanti);

                    cmd.Parameters.AddWithValue("@name", txtBox_Name.Text);
                    decimal.TryParse(txtBox_Price.Text, out decimal price);
                    cmd.Parameters.AddWithValue("@price", SqlDbType.Decimal).Value = price;
                    cmd.Parameters.AddWithValue("id", txtBox_ID.Text);

                    // txtboxlara girilen verileri SQL daki tablo sütunlarındaki verilerle değiştir.

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kahveler Tablosundaki Bilgiler Güncellendi.");

                    baglanti.Close();
                }
                if (btn_Drink.Checked == true)
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    string save = "UPDATE Drinks SET name = @name, price = @price WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(save, baglanti);

                    cmd.Parameters.AddWithValue("@name", txtBox_Name.Text);
                    decimal.TryParse(txtBox_Price.Text, out decimal price);
                    cmd.Parameters.AddWithValue("@price", SqlDbType.Decimal).Value = price;
                    cmd.Parameters.AddWithValue("id", txtBox_ID.Text);

                    // txtboxlara girilen verileri SQL daki tablo sütunlarındaki verilerle değiştir.

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("İçecekler Tablosundaki Bilgiler Güncellendi.");

                    baglanti.Close();
                }
                if (btn_Sweet.Checked == true)
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    string save = "UPDATE Sweets SET name = @name, price = @price WHERE id = @id";

                    SqlCommand cmd = new SqlCommand(save, baglanti);

                    cmd.Parameters.AddWithValue("@name", txtBox_Name.Text);
                    decimal.TryParse(txtBox_Price.Text, out decimal price);
                    cmd.Parameters.AddWithValue("@price", SqlDbType.Decimal).Value = price;
                    cmd.Parameters.AddWithValue("id", txtBox_ID.Text);

                    // txtboxlara girilen verileri SQL daki tablo sütunlarındaki verilerle değiştir.

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Tatlılar Tablosundaki Bilgiler Güncellendi.");

                    baglanti.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen sayı dışında bir değer girmeyiniz.(Virgül(,) istisnadır.");
            }
            

            // radiobuttonları kontrol et eğer true değerini dönderiyorsa seçilen satırı SQL tablosunda düzenle.
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            if (btn_Coffe.Checked == true)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlDataAdapter adapterManager = new SqlDataAdapter("SELECT id,name,price FROM Coffe", baglanti);
                DataTable tableSweetsANDDrinks = new DataTable();
                adapterManager.Fill(tableSweetsANDDrinks);

                tableSweetsANDDrinks.Columns["id"].ColumnName = "ID";
                tableSweetsANDDrinks.Columns["name"].ColumnName = "İsim";
                tableSweetsANDDrinks.Columns["price"].ColumnName = "Fiyat";

                // Kolon isimlerini düzenle.

                dataGridView_Manager_List_Change.DataSource = tableSweetsANDDrinks;

                dataGridView_Manager_List_Change.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

                // Tablonun font ayarını düzenle.

                baglanti.Close();
            }
            if (btn_Drink.Checked == true)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlDataAdapter adapterManager = new SqlDataAdapter("SELECT id,name,price FROM Drinks", baglanti);
                DataTable tableSweetsANDDrinks = new DataTable();
                adapterManager.Fill(tableSweetsANDDrinks);

                tableSweetsANDDrinks.Columns["id"].ColumnName = "ID";
                tableSweetsANDDrinks.Columns["name"].ColumnName = "İsim";
                tableSweetsANDDrinks.Columns["price"].ColumnName = "Fiyat";

                // Kolon isimlerini düzenle.

                dataGridView_Manager_List_Change.DataSource = tableSweetsANDDrinks;

                dataGridView_Manager_List_Change.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

                // Tablonun font ayarını düzenle.

                baglanti.Close();
            }
            if (btn_Sweet.Checked == true)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlDataAdapter adapterManager = new SqlDataAdapter("SELECT id,name,price FROM Sweets", baglanti);
                DataTable tableSweetsANDDrinks = new DataTable();
                adapterManager.Fill(tableSweetsANDDrinks);

                tableSweetsANDDrinks.Columns["id"].ColumnName = "ID";
                tableSweetsANDDrinks.Columns["name"].ColumnName = "İsim";
                tableSweetsANDDrinks.Columns["price"].ColumnName = "Fiyat";

                // Kolon isimlerini düzenle.

                dataGridView_Manager_List_Change.DataSource = tableSweetsANDDrinks;

                dataGridView_Manager_List_Change.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

                // Tablonun font ayarını düzenle.

                baglanti.Close();
            }
        }
        private void txtBox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Point mouseLocation;
        private void manager_List_Change_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);

            // Form hareket etmesini sağlar.
        }
        private void manager_List_Change_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }

            // Form hareket etmesini sağlar.
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