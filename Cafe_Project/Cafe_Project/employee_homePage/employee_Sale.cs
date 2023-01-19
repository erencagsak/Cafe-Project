using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cafe_Project
{
    public partial class employee_Sale : DevExpress.XtraEditors.XtraForm
    {
        BaglantiSinif bgl = new BaglantiSinif();
        public employee_Sale()
        {
            InitializeComponent();
        }
        private void manager_Sale_Load(object sender, EventArgs e)
        {
            screenSettings();

            // Ekran boyutunu otomatik ayarlama. 

            change_dataGriedView_DayPrice();

            // dataGriedView_DayPrice kısmına sqlden çektiği verileri yazdır. Fontu ayarla ve kolon isimlerini düzenle.

            change_txtBox_TotalDayPrice();

            // txtBox_TotalDayPrice textboxına sqldeki verileri toplayıp yazdır.
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
                control.Font = new Font("Microsoft Sans Serif", control.Font.SizeInPoints * YHeight * YWidth);
            }
            // Ekran boyutunu otomatik ayarlama. 
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            employee_homePage employee_homePage = new employee_homePage();

            employee_homePage.Show();
            this.Close();

            // Geri dön tuşuyla Ana Sayfaya dön.
        }
        public void change_dataGriedView_DayPrice()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlDataAdapter adapterDayPrice = new SqlDataAdapter("SELECT id,table_Name,table_Price FROM day_TotalPrice_Tables", baglanti);
            DataTable tableDayPrice = new DataTable();
            adapterDayPrice.Fill(tableDayPrice);

            tableDayPrice.Columns["id"].ColumnName = "ID";
            tableDayPrice.Columns["table_Name"].ColumnName = "Masa İsmi";
            tableDayPrice.Columns["table_Price"].ColumnName = "Masalardan Gelen Para";

            // Kolon isimlerini düzenle.

            dataGriedView_DayPrice.DataSource = tableDayPrice;

            dataGriedView_DayPrice.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

            // Tablonun font ayarını düzenle.

            dataGriedView_DayPrice.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(237, 233, 234);
            dataGriedView_DayPrice.EnableHeadersVisualStyles = false;

            // Tablonun rengini düzenle.

            baglanti.Close();
        }
        public void change_txtBox_TotalDayPrice()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            decimal sayiTopla = 0;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            try
            {
                SqlCommand cmdTopla = new SqlCommand("SELECT table_Price FROM day_TotalPrice_Tables", baglanti);
                SqlDataReader reader = cmdTopla.ExecuteReader();

                while (reader.Read())
                {
                    sayiTopla += Convert.ToDecimal(reader["table_Price"]);
                }
                txtBox_TotalDayPrice.Text = sayiTopla.ToString();
                cmdTopla.Dispose();
                reader.Close();
            }
            catch (Exception)
            {
            }
            baglanti.Close();
        }
        private void btn_ResetTotalDayPrice_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            if (txtBox_Date.MaskFull)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand cmdTotalPrice = new SqlCommand("INSERT INTO month_TotalPrice_Tables (date,price) VALUES ('" + txtBox_Date.Text + "','" + txtBox_TotalDayPrice.Text + "')", baglanti);

                cmdTotalPrice.ExecuteNonQuery();

                SqlCommand deleteDayTotalPrice = new SqlCommand("TRUNCATE TABLE day_TotalPrice_Tables", baglanti);

                deleteDayTotalPrice.ExecuteNonQuery();

                DialogResult result = MessageBox.Show("Günü Kapatmak istiyor musunuz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Gün kapatıldı. Toplam ciro aylık tablosuna aktarıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Tarih kısmı boş bırakılamaz. Lütfen doldurunuz.", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglanti.Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            change_txtBox_TotalDayPrice();

            change_dataGriedView_DayPrice();

            // btn_Refresh butonuna tıklandığında txtboxları ve datagriedviewları yenile.
        }

        private void txtBox_Date_Click(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtBox_Date.Select(0, 0);
            });

            // txtBox_Date textboxına tıklandığında mouse en başa gelir.
        }
    }
}