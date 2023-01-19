using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cafe_Project
{
    public partial class manager_List : DevExpress.XtraEditors.XtraForm
    {
        BaglantiSinif bgl = new BaglantiSinif();

        // SQL bağlantısı
        public manager_List()
        {
            InitializeComponent();
        }
        private void manager_List_Load(object sender, EventArgs e)
        {
            screenSettings();

            change_Appearance_dataGridView_Manager_List();

            // Manager_List gridviewi özelleştir.
        }
        public void screenSettings()
        {
            Rectangle resolution = new Rectangle();
            resolution = Screen.GetBounds(resolution);
            float YWidth = ((float)resolution.Width / (float)1366);
            float YHeight = ((float)resolution.Height / (float)768);
            SizeF scale = new SizeF(YWidth, YHeight);
            this.Scale(scale);
            foreach (Control control in this.Controls)
            {
                control.Font = new Font("Segoe UI Semibold", control.Font.SizeInPoints * YHeight * YWidth);
            }
            // Ekran boyutunu otomatik ayarlama. 
        }
        private void btn_GeriDon_Click(object sender, EventArgs e)
        {
            manager_homePage manager_HomePage = new manager_homePage();

            manager_HomePage.Show();
            this.Close();

            // Geri dön tuşuyla Yönetici ana sayfasına dön.
        }
        private void btn_Coffe_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            baglanti.Open(); // Bağlantıyı aç

            SqlDataAdapter adapterSweetsANDDrinks = new SqlDataAdapter("SELECT id,name,price FROM Coffe", baglanti);
            DataTable tableSweetsANDDrinks = new DataTable();
            adapterSweetsANDDrinks.Fill(tableSweetsANDDrinks);

            tableSweetsANDDrinks.Columns["id"].ColumnName = "ID";
            tableSweetsANDDrinks.Columns["name"].ColumnName = "Kahveler";
            tableSweetsANDDrinks.Columns["price"].ColumnName = "Fiyat";

            // Kolon isimlerini düzenle.

            dataGridView_Manager_List.DataSource = tableSweetsANDDrinks;

            dataGridView_Manager_List.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
            dataGridView_Manager_List.Columns[0].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
            dataGridView_Manager_List.Columns[1].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
            dataGridView_Manager_List.Columns[2].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);

            // Tablonun font ayarını düzenle.

            baglanti.Close(); // Bağlantıyı kapat
        }
        private void btn_Drink_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            baglanti.Open(); // Bağlantıyı aç

            SqlDataAdapter adapterSweetsANDDrinks = new SqlDataAdapter("SELECT id,name,price FROM Drinks", baglanti);
            DataTable tableSweetsANDDrinks = new DataTable();
            adapterSweetsANDDrinks.Fill(tableSweetsANDDrinks);

            tableSweetsANDDrinks.Columns["id"].ColumnName = "ID";
            tableSweetsANDDrinks.Columns["name"].ColumnName = "İçecekler";
            tableSweetsANDDrinks.Columns["price"].ColumnName = "Fiyat";

            // Kolon isimlerini düzenle.

            dataGridView_Manager_List.DataSource = tableSweetsANDDrinks;

            dataGridView_Manager_List.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
            dataGridView_Manager_List.Columns[0].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
            dataGridView_Manager_List.Columns[1].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
            dataGridView_Manager_List.Columns[2].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);

            // Tablonun font ayarını düzenle.

            baglanti.Close(); // Bağlantıyı kapat
        }

        private void btn_Sweet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            baglanti.Open(); // Bağlantıyı aç

            SqlDataAdapter adapterSweetsANDDrinks = new SqlDataAdapter("SELECT id,name,price FROM Sweets", baglanti);
            DataTable tableSweetsANDDrinks = new DataTable();
            adapterSweetsANDDrinks.Fill(tableSweetsANDDrinks);

            tableSweetsANDDrinks.Columns["id"].ColumnName = "ID";
            tableSweetsANDDrinks.Columns["name"].ColumnName = "Tatlılar";
            tableSweetsANDDrinks.Columns["price"].ColumnName = "Fiyat";

            // Kolon isimlerini düzenle.

            dataGridView_Manager_List.DataSource = tableSweetsANDDrinks;

            dataGridView_Manager_List.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
            dataGridView_Manager_List.Columns[0].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
            dataGridView_Manager_List.Columns[1].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
            dataGridView_Manager_List.Columns[2].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);

            // Tablonun font ayarını düzenle.

            baglanti.Close(); // Bağlantıyı kapat
        }
        public void change_Appearance_dataGridView_Manager_List()
        {
            dataGridView_Manager_List.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(200,176,160);
            dataGridView_Manager_List.EnableHeadersVisualStyles = false;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            var addData = new manager_List_Add
            {
                ShowInTaskbar = false,
                MaximizeBox = false,
                MinimizeBox = false
            };
            addData.StartPosition = FormStartPosition.CenterParent;
            addData.ShowDialog(this);

            // manager_List_Add formunu manager_List içinde açmak için kullanıldı.
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            var changeList = new manager_List_Change
            {
                ShowInTaskbar = false,
                MaximizeBox = false,
                MinimizeBox = false

                // Formun üstündeki simgeleri, büyütmeyi, küçültmeyi kapatır.
            };
            changeList.StartPosition = FormStartPosition.CenterParent;
            changeList.ShowDialog(this);

            // manager_List_Change formunu manager_List formu içinde açmak için kullanıldı.

        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            baglanti.Open();

            if (btn_Coffe.Checked == true)
            {
                string coffe = "SELECT * FROM Coffe WHERE id=@id";

                SqlCommand cmdCoffe = new SqlCommand(coffe, baglanti);
                cmdCoffe.Parameters.AddWithValue("@id", txtBox_ID.Text);
                SqlDataReader readerCoffe = cmdCoffe.ExecuteReader();
                SqlDataAdapter coffeAdapter = new SqlDataAdapter(cmdCoffe);

                if (readerCoffe.Read())
                {
                    string coffeName = readerCoffe["name"].ToString();

                    readerCoffe.Close();

                    DialogResult durum = MessageBox.Show(coffeName + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DialogResult.Yes == durum)
                    {
                        string coffeDeleteSQL = "DELETE FROM Coffe WHERE id=@id";

                        SqlCommand deletecmd = new SqlCommand(coffeDeleteSQL, baglanti);
                        deletecmd.Parameters.AddWithValue("@id", txtBox_ID.Text);
                        deletecmd.ExecuteNonQuery();

                        MessageBox.Show("Kayıt Silindi...");
                    }
                }
                else
                    MessageBox.Show("Kayıt Bulunamadı.");

            }
            if (btn_Drinks.Checked == true)
            {
                string drinks = "SELECT * FROM Drinks WHERE id=@id";

                SqlCommand cmdDrinks = new SqlCommand(drinks, baglanti);
                cmdDrinks.Parameters.AddWithValue("@id", txtBox_ID.Text);
                SqlDataReader readerDrinks = cmdDrinks.ExecuteReader();
                SqlDataAdapter drinksAdapter = new SqlDataAdapter(cmdDrinks);

                if (readerDrinks.Read())
                {
                    string drinksName = readerDrinks["name"].ToString();

                    readerDrinks.Close();

                    DialogResult durum = MessageBox.Show(drinksName + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DialogResult.Yes == durum)
                    {
                        string drinksDeleteSQL = "DELETE FROM Drinks WHERE id=@id";

                        SqlCommand deletecmd = new SqlCommand(drinksDeleteSQL, baglanti);
                        deletecmd.Parameters.AddWithValue("@id", txtBox_ID.Text);
                        deletecmd.ExecuteNonQuery();

                        MessageBox.Show("Kayıt Silindi...");
                    }
                }
                else
                    MessageBox.Show("Kayıt Bulunamadı.");
            }
            if (btn_Sweets.Checked == true)
            {
                string sweets = "SELECT * FROM Sweets WHERE id=@id";

                SqlCommand cmdSweets = new SqlCommand(sweets, baglanti);
                cmdSweets.Parameters.AddWithValue("@id", txtBox_ID.Text);
                SqlDataReader readerSweets = cmdSweets.ExecuteReader();
                SqlDataAdapter sweetsAdapter = new SqlDataAdapter(cmdSweets);

                if (readerSweets.Read())
                {
                    string sweetsName = readerSweets["name"].ToString();

                    readerSweets.Close();

                    DialogResult durum = MessageBox.Show(sweetsName + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DialogResult.Yes == durum)
                    {
                        string sweetsDeleteSQL = "DELETE FROM Sweets WHERE id=@id";

                        SqlCommand deletecmd = new SqlCommand(sweetsDeleteSQL, baglanti);
                        deletecmd.Parameters.AddWithValue("@id", txtBox_ID.Text);
                        deletecmd.ExecuteNonQuery();

                        MessageBox.Show("Kayıt Silindi...");
                    }
                }
                else
                    MessageBox.Show("Kayıt Bulunamadı.");
            }
            baglanti.Close();
        }
        private void dataGridView_Manager_List_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBox_ID.Text = dataGridView_Manager_List.CurrentRow.Cells[0].Value.ToString();
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            if (btn_Coffe.Checked == true)
            {
                baglanti.Open();

                SqlDataAdapter adapterManager = new SqlDataAdapter("SELECT id,name,price FROM Coffe", baglanti);
                DataTable tableSweetsANDDrinks = new DataTable();
                adapterManager.Fill(tableSweetsANDDrinks);

                tableSweetsANDDrinks.Columns["id"].ColumnName = "ID";
                tableSweetsANDDrinks.Columns["name"].ColumnName = "Kahveler";
                tableSweetsANDDrinks.Columns["price"].ColumnName = "Fiyat";
                

                // Kolon isimlerini düzenle.

                dataGridView_Manager_List.DataSource = tableSweetsANDDrinks;

                dataGridView_Manager_List.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

                // Tablonun font ayarını düzenle.

                baglanti.Close();
            }
            if (btn_Drinks.Checked == true)
            {
                baglanti.Open();

                SqlDataAdapter adapterManager = new SqlDataAdapter("SELECT id,name,price FROM Drinks", baglanti);
                DataTable tableSweetsANDDrinks = new DataTable();
                adapterManager.Fill(tableSweetsANDDrinks);

                tableSweetsANDDrinks.Columns["id"].ColumnName = "ID";
                tableSweetsANDDrinks.Columns["name"].ColumnName = "İçecekler";
                tableSweetsANDDrinks.Columns["price"].ColumnName = "Fiyat";


                // Kolon isimlerini düzenle.

                dataGridView_Manager_List.DataSource = tableSweetsANDDrinks;

                dataGridView_Manager_List.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

                // Tablonun font ayarını düzenle.

                baglanti.Close();
            }
            if (btn_Sweets.Checked == true)
            {
                baglanti.Open();

                SqlDataAdapter adapterManager = new SqlDataAdapter("SELECT id,name,price FROM Sweets", baglanti);
                DataTable tableSweetsANDDrinks = new DataTable();
                adapterManager.Fill(tableSweetsANDDrinks);

                tableSweetsANDDrinks.Columns["id"].ColumnName = "ID";
                tableSweetsANDDrinks.Columns["name"].ColumnName = "Tatlılar";
                tableSweetsANDDrinks.Columns["price"].ColumnName = "Fiyat";


                // Kolon isimlerini düzenle.

                dataGridView_Manager_List.DataSource = tableSweetsANDDrinks;

                dataGridView_Manager_List.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

                // Tablonun font ayarını düzenle.

                baglanti.Close();
            }
        }
    }
}