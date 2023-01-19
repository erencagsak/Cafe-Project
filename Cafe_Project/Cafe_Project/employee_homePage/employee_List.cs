using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cafe_Project
{
    public partial class employee_List : DevExpress.XtraEditors.XtraForm
    {
        BaglantiSinif bgl = new BaglantiSinif();

        // SQL bağlantısı
        public employee_List()
        {
            InitializeComponent();
        }
        private void employee_List_Load(object sender, EventArgs e)
        {
            screenSettings();
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
        private void btn_Back_Click(object sender, EventArgs e)
        {
            employee_homePage employee_homePage = new employee_homePage();

            employee_homePage.Show();
            this.Close();

            // Geri dön tuşuyla Yönetici ana sayfasına dön.
        }
        private void btn_Coffe_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            } // Bağlantıyı aç

            SqlDataAdapter adapterSweetsANDDrinks = new SqlDataAdapter("SELECT id,name,price FROM Coffe", baglanti);
            DataTable tableSweetsANDDrinks = new DataTable();
            adapterSweetsANDDrinks.Fill(tableSweetsANDDrinks);

            tableSweetsANDDrinks.Columns["id"].ColumnName = "ID";
            tableSweetsANDDrinks.Columns["name"].ColumnName = "Kahveler";
            tableSweetsANDDrinks.Columns["price"].ColumnName = "Fiyat";

            // Kolon isimlerini düzenle.

            dataGriedView_Employee_List.DataSource = tableSweetsANDDrinks;

            dataGriedView_Employee_List.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
            dataGriedView_Employee_List.Columns[0].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
            dataGriedView_Employee_List.Columns[1].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
            dataGriedView_Employee_List.Columns[2].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);

            // Tablonun font ayarını düzenle.

            baglanti.Close(); // Bağlantıyı kapat
        }
        private void btn_Drink_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            } // Bağlantıyı aç

            SqlDataAdapter adapterSweetsANDDrinks = new SqlDataAdapter("SELECT id,name,price FROM Drinks", baglanti);
            DataTable tableSweetsANDDrinks = new DataTable();
            adapterSweetsANDDrinks.Fill(tableSweetsANDDrinks);

            tableSweetsANDDrinks.Columns["id"].ColumnName = "ID";
            tableSweetsANDDrinks.Columns["name"].ColumnName = "İçecekler";
            tableSweetsANDDrinks.Columns["price"].ColumnName = "Fiyat";

            // Kolon isimlerini düzenle.

            dataGriedView_Employee_List.DataSource = tableSweetsANDDrinks;

            dataGriedView_Employee_List.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
            dataGriedView_Employee_List.Columns[0].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
            dataGriedView_Employee_List.Columns[1].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
            dataGriedView_Employee_List.Columns[2].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);

            // Tablonun font ayarını düzenle.

            baglanti.Close(); // Bağlantıyı kapat
        }

        private void btn_Sweet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            } // Bağlantıyı aç

            SqlDataAdapter adapterSweetsANDDrinks = new SqlDataAdapter("SELECT id,name,price FROM Sweets", baglanti);
            DataTable tableSweetsANDDrinks = new DataTable();
            adapterSweetsANDDrinks.Fill(tableSweetsANDDrinks);

            tableSweetsANDDrinks.Columns["id"].ColumnName = "ID";
            tableSweetsANDDrinks.Columns["name"].ColumnName = "Tatlılar";
            tableSweetsANDDrinks.Columns["price"].ColumnName = "Fiyat";

            // Kolon isimlerini düzenle.

            dataGriedView_Employee_List.DataSource = tableSweetsANDDrinks;

            dataGriedView_Employee_List.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
            dataGriedView_Employee_List.Columns[0].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
            dataGriedView_Employee_List.Columns[1].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);
            dataGriedView_Employee_List.Columns[2].HeaderCell.Style.Font = new Font("Segoe UI Semibold", 13, FontStyle.Bold);

            // Tablonun font ayarını düzenle.

            baglanti.Close(); // Bağlantıyı kapat
        }
        private void dataGridView_Employee_List_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBox_ID.Text = dataGriedView_Employee_List.CurrentRow.Cells[0].Value.ToString();

            dataGriedView_Employee_List.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGriedView_Employee_List.EnableHeadersVisualStyles = false;
        }
    }
}