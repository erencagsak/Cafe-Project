using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cafe_Project
{
    public partial class employee_Tables_Table10 : DevExpress.XtraEditors.XtraForm
    {
        BaglantiSinif bgl = new BaglantiSinif();
        public employee_Tables_Table10()
        {
            InitializeComponent();
        }
        private void employee_Tables_Table10_Load(object sender, EventArgs e)
        {
            screenSettings();
            // Ekranı ayarla.

            call_Price_For_txtbox_Paid();
            // Ödenecek Fiyatı txtbox içine yazdır.

            change_Appearance_data_GriedView_Menu();
            // Menu datagridview özelleştir

            change_Appearance_data_GriedView_Order();
            // Order datagridview özelleştir

            data_GriedView_Order_Timer.Start();
            // Timeri başlat.
        }
        private void btn_Coffe_Click(object sender, EventArgs e)
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

            dataGriedView_Menu.DataSource = tableSweetsANDDrinks;

            dataGriedView_Menu.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

            // Tablonun font ayarını düzenle.

            baglanti.Close();

            // Coffe tablosundaki verileri getir.
        }
        private void btn_Drinks_Click(object sender, EventArgs e)
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

            dataGriedView_Menu.DataSource = tableSweetsANDDrinks;

            dataGriedView_Menu.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

            // Tablonun font ayarını düzenle.

            baglanti.Close();

            // Drinks tablosundaki verileri getir.
        }
        private void btn_Sweets_Click(object sender, EventArgs e)
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

            dataGriedView_Menu.DataSource = tableSweetsANDDrinks;

            dataGriedView_Menu.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

            // Tablonun font ayarını düzenle.

            baglanti.Close();

            // Sweets tablosundaki verileri getir.
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            try
            {
                if (dataGriedView_Menu.SelectedRows.Count > 0)
                {
                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }

                    using (SqlCommand ekle = new SqlCommand(@"insert into Table10 (name, number, price) values (@name, @number, @price)", baglanti))
                    {
                        ekle.Parameters.Add("@name", SqlDbType.VarChar).Value = txtBox_Name.Text;
                        ekle.Parameters.Add("@number", SqlDbType.VarChar).Value = txtBox_Number.Text;
                        decimal.TryParse(txtBox_Price.Text, out decimal price);
                        ekle.Parameters.Add("@price", SqlDbType.Decimal).Value = price;

                        int say = ekle.ExecuteNonQuery();

                        if (say > 0)
                        {
                            MessageBox.Show("Sipariş Başarıyla Eklendi", "Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Menü kısmından herhangi bir sipariş seçilmedi. Lütfen seçip seçmediğinizi kontrol ediniz...", "Uyarı !");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sipariş eklenemedi. Lütfen tekrar deneyiniz.");
            }
            finally
            {
                baglanti.Close();

                // bağlantıyı kapat
            }

            // Siparişler kısmına seçili kısmı ekle
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            string sqlTable = "SELECT * FROM Table10 WHERE id=@id";

            SqlCommand cmdTable = new SqlCommand(sqlTable, baglanti);
            cmdTable.Parameters.AddWithValue("@id", txtBox_OrderID.Text);
            SqlDataReader readerTable = cmdTable.ExecuteReader();
            SqlDataAdapter tableAdapter = new SqlDataAdapter(cmdTable);

            try
            {
                if (readerTable.Read())
                {
                    string tableName = readerTable["name"].ToString();

                    readerTable.Close();

                    DialogResult situation = MessageBox.Show(tableName + " siparişi kaldırmak istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DialogResult.Yes == situation)
                    {
                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                        }

                        string tableDeleteSQL = "DELETE FROM Table10 WHERE id=@id";

                        SqlCommand deleteTableSQL = new SqlCommand(tableDeleteSQL, baglanti);
                        deleteTableSQL.Parameters.AddWithValue("@id", txtBox_OrderID.Text);
                        deleteTableSQL.ExecuteNonQuery();

                        MessageBox.Show("Sipariş Silindi...");

                        baglanti.Close();
                    }
                }
                else
                    MessageBox.Show("Sipariş Bulunamadı.");
            }
            catch (Exception)
            {
            }
            // Siparişler kısmında seçili veriyi sil.

            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                DialogResult situation = MessageBox.Show("Siparişi Tamamlamak istiyor musunuz?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == situation)
                {
                    if (dataGriedView_Order.Rows.Count > 0)
                    {
                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                        }

                        SqlCommand cmdTotalPrice = new SqlCommand("INSERT INTO day_TotalPrice_Tables (table_Name,table_Price) VALUES ('Masa 10','" + txtBox_Paid.Text + "')", baglanti);

                        cmdTotalPrice.ExecuteNonQuery();

                        string truncateTable = "TRUNCATE TABLE Table10";
                        SqlCommand cmdDeleteTable = new SqlCommand(truncateTable, baglanti);
                        cmdDeleteTable.ExecuteNonQuery();

                        MessageBox.Show("Sipariş Tamamlandı.");
                    }
                    else
                    {
                        MessageBox.Show("Sipariş kısmında ürün bulunmamakta. Lütfen ürün ekleyiniz.");
                    }

                }
                else
                {
                }

                baglanti.Close();

                // Siparişi tamamla.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();

            }
        }
        private void dataGriedView_Menu_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (txtNumber.Text == "")
            {
                txtNumber.Text = "1";
            }

            txtBox_MenuID.Text = dataGriedView_Menu.CurrentRow.Cells[0].Value.ToString();
            txtBox_Name.Text = dataGriedView_Menu.CurrentRow.Cells[1].Value.ToString();
            txtBox_Number.Text = txtNumber.Text;
            txtBox_Price.Text = (Convert.ToDecimal(dataGriedView_Menu.CurrentRow.Cells[2].Value) * Convert.ToDecimal(txtNumber.Text)).ToString();
            // txtboxlara SQL verilerini gönder ve ekranda göster.
        }
        private void dataGriedView_Order_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBox_OrderID.Text = dataGriedView_Order.CurrentRow.Cells[0].Value.ToString();
        }
        public void change_Appearance_data_GriedView_Order()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            SqlDataAdapter adapterOrder = new SqlDataAdapter("SELECT id,name,number,price FROM Table10", baglanti);
            DataTable tableOrder = new DataTable();
            adapterOrder.Fill(tableOrder);

            tableOrder.Columns["id"].ColumnName = "ID";
            tableOrder.Columns["name"].ColumnName = "Ürün İsim";
            tableOrder.Columns["number"].ColumnName = "Ürün Adet";
            tableOrder.Columns["price"].ColumnName = "Toplam Fiyat";

            // Kolon isimlerini düzenle.
            dataGriedView_Order.DataSource = tableOrder;
            dataGriedView_Order.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
        }
        public void change_Appearance_data_GriedView_Menu()
        {
            dataGriedView_Menu.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGriedView_Menu.EnableHeadersVisualStyles = false;
        }
        public void refresh_DataGriedView_Order()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            string selectSQL = "SELECT * FROM Table10";
            SqlDataAdapter tableAdapter = new SqlDataAdapter(selectSQL, baglanti);
            DataSet tableSet = new System.Data.DataSet();
            tableAdapter.Fill(tableSet);
            dataGriedView_Order.DataSource = tableSet.Tables[0];
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
        public void call_Price_For_txtbox_Paid()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            decimal sayiTopla = 0;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            try
            {
                SqlCommand cmdTopla = new SqlCommand("SELECT price FROM Table10", baglanti);
                SqlDataReader reader = cmdTopla.ExecuteReader();

                while (reader.Read())
                {
                    sayiTopla += Convert.ToDecimal(reader["price"]);
                }
                txtBox_Paid.Text = sayiTopla.ToString();
                cmdTopla.Dispose();
                reader.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            baglanti.Close();
        }
        public void call_txtBox_Remainder()
        {
            decimal paid = Convert.ToDecimal(txtBox_Paid.Text);
            decimal given_Amount = Convert.ToDecimal(txtBox_GivenAmount.Text);
            decimal remainder = 0;

            if (remainder == 0)
            {
                remainder = Convert.ToDecimal(txtBox_Remainder.Text);
                remainder = given_Amount - paid;

                txtBox_Remainder.Text = remainder.ToString();
            }

            // Para üstünü txtboxa yazdır.
        }
        private void data_GriedView_Order_Timer_Tick(object sender, EventArgs e)
        {
            refresh_DataGriedView_Order();
            call_Price_For_txtbox_Paid();
            call_txtBox_Remainder();
            data_GriedView_Order_Timer.Start();
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            employee_Table employee_Table = new employee_Table();

            employee_Table.Show();
            this.Hide();

            // Geri dön tuşuyla Masalar ana sayfasına dön.
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0" && txtNumber.Text == null)
            {
                txtNumber.Text = "1";
            }
            else
            {
                txtNumber.Text = txtNumber.Text + "1";
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0" && txtNumber.Text == null)
            {
                txtNumber.Text = "2";
            }
            else
            {
                txtNumber.Text = txtNumber.Text + "2";
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0" && txtNumber.Text == null)
            {
                txtNumber.Text = "3";
            }
            else
            {
                txtNumber.Text = txtNumber.Text + "3";
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0" && txtNumber.Text == null)
            {
                txtNumber.Text = "4";
            }
            else
            {
                txtNumber.Text = txtNumber.Text + "4";
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0" && txtNumber.Text == null)
            {
                txtNumber.Text = "5";
            }
            else
            {
                txtNumber.Text = txtNumber.Text + "5";
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0" && txtNumber.Text == null)
            {
                txtNumber.Text = "6";
            }
            else
            {
                txtNumber.Text = txtNumber.Text + "6";
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0" && txtNumber.Text == null)
            {
                txtNumber.Text = "7";
            }
            else
            {
                txtNumber.Text = txtNumber.Text + "7";
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0" && txtNumber.Text == null)
            {
                txtNumber.Text = "8";
            }
            else
            {
                txtNumber.Text = txtNumber.Text + "8";
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0" && txtNumber.Text == null)
            {
                txtNumber.Text = "9";
            }
            else
            {
                txtNumber.Text = txtNumber.Text + "9";
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0" && txtNumber.Text == null)
            {
                txtNumber.Text = "0";
            }
            else
            {
                txtNumber.Text = txtNumber.Text + "0";
            }
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            txtNumber.Text = null;
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
