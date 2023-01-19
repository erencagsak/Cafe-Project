using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Cafe_Project
{
    public partial class manager_Workers_Change : DevExpress.XtraEditors.XtraForm
    {
        BaglantiSinif bgl = new BaglantiSinif();

        // SQL bağlantıları

        public manager_Workers_Change()
        {
            InitializeComponent();
        }
        private void manager_Workers_Change_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Ekran boyutunu ayarlamayı kapatır.
        }
        private void dataGridView_Manager_Workers_Change_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBox_Name.Text = dataGridView_Manager_Workers_Change.CurrentRow.Cells[1].Value.ToString();
            txtBox_SurName.Text = dataGridView_Manager_Workers_Change.CurrentRow.Cells[2].Value.ToString();
            txtBox_UserName.Text = dataGridView_Manager_Workers_Change.CurrentRow.Cells[3].Value.ToString();
            txtBox_Password.Text = dataGridView_Manager_Workers_Change.CurrentRow.Cells[4].Value.ToString();
            txtBox_PIN.Text = dataGridView_Manager_Workers_Change.CurrentRow.Cells[5].Value.ToString();
            txtBox_ID.Text = dataGridView_Manager_Workers_Change.CurrentRow.Cells[0].Value.ToString();

            // txtboxlara SQL verilerini gönder ve ekranda göster.
        }
        private void btn_Manager_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            txtBox_UserName.ReadOnly = false;
            txtBox_Password.ReadOnly = false;
            txtBox_PIN.ReadOnly = false;

            // belirtilen txtboxların readonly özelliğini false duruma getir.

            baglanti.Open();

            SqlDataAdapter adapterManager = new SqlDataAdapter("SELECT id,name,surname,username,password,pin FROM Manager_Account", baglanti);
            DataTable tableManager = new DataTable();
            adapterManager.Fill(tableManager);

            tableManager.Columns["id"].ColumnName = "ID";
            tableManager.Columns["name"].ColumnName = "İsim";
            tableManager.Columns["surname"].ColumnName = "Soyisim";
            tableManager.Columns["username"].ColumnName = "Kullanıcı Adı";
            tableManager.Columns["password"].ColumnName = "Şifre";
            tableManager.Columns["pin"].ColumnName = "Özel PIN Kodu";

            // Kolon isimlerini düzenle.

            dataGridView_Manager_Workers_Change.DataSource = tableManager;

            dataGridView_Manager_Workers_Change.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

            // Tablonun font ayarını düzenle.

            baglanti.Close();
        }
        private void btn_Chef_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            txtBox_UserName.ReadOnly = true;
            txtBox_Password.ReadOnly = true;
            txtBox_PIN.ReadOnly = true;

            // belirtilen txtboxların readonly özelliğini true duruma getir.

            baglanti.Open();

            SqlDataAdapter adapterEmployee = new SqlDataAdapter("SELECT id,name,surname,username,password,pin FROM Chef_Account", baglanti);
            DataTable tableEmployee = new DataTable();
            adapterEmployee.Fill(tableEmployee);

            tableEmployee.Columns["id"].ColumnName = "ID";
            tableEmployee.Columns["name"].ColumnName = "İsim";
            tableEmployee.Columns["surname"].ColumnName = "Soyisim";
            tableEmployee.Columns["username"].ColumnName = "Kullanıcı Adı";
            tableEmployee.Columns["password"].ColumnName = "Şifre";
            tableEmployee.Columns["pin"].ColumnName = "Özel PIN Kodu";

            // Kolon isimlerini düzenle.

            dataGridView_Manager_Workers_Change.DataSource = tableEmployee;

            dataGridView_Manager_Workers_Change.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

            // Tablonun font ayarını düzenle.

            baglanti.Close();
        }
        private void btn_AssistantChef_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            txtBox_UserName.ReadOnly = true;
            txtBox_Password.ReadOnly = true;
            txtBox_PIN.ReadOnly = true;

            // belirtilen txtboxların readonly özelliğini true duruma getir.

            baglanti.Open();

            SqlDataAdapter adapterEmployee = new SqlDataAdapter("SELECT id,name,surname,username,password,pin FROM Assistant_Chef_Account", baglanti);
            DataTable tableEmployee = new DataTable();
            adapterEmployee.Fill(tableEmployee);

            tableEmployee.Columns["id"].ColumnName = "ID";
            tableEmployee.Columns["name"].ColumnName = "İsim";
            tableEmployee.Columns["surname"].ColumnName = "Soyisim";
            tableEmployee.Columns["username"].ColumnName = "Kullanıcı Adı";
            tableEmployee.Columns["password"].ColumnName = "Şifre";
            tableEmployee.Columns["pin"].ColumnName = "Özel PIN Kodu";

            // Kolon isimlerini düzenle.

            dataGridView_Manager_Workers_Change.DataSource = tableEmployee;

            dataGridView_Manager_Workers_Change.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

            // Tablonun font ayarını düzenle.

            baglanti.Close();
        }
        private void btn_Waiter_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            txtBox_UserName.ReadOnly = false;
            txtBox_Password.ReadOnly = false;
            txtBox_PIN.ReadOnly = false;

            // belirtilen txtboxların readonly özelliğini false duruma getir.

            baglanti.Open();

            SqlDataAdapter adapterEmployee = new SqlDataAdapter("SELECT id,name,surname,username,password,pin FROM Waiter_Account", baglanti);
            DataTable tableEmployee = new DataTable();
            adapterEmployee.Fill(tableEmployee);

            tableEmployee.Columns["id"].ColumnName = "ID";
            tableEmployee.Columns["name"].ColumnName = "İsim";
            tableEmployee.Columns["surname"].ColumnName = "Soyisim";
            tableEmployee.Columns["username"].ColumnName = "Kullanıcı Adı";
            tableEmployee.Columns["password"].ColumnName = "Şifre";
            tableEmployee.Columns["pin"].ColumnName = "Özel PIN Kodu";

            // Kolon isimlerini düzenle.

            dataGridView_Manager_Workers_Change.DataSource = tableEmployee;

            dataGridView_Manager_Workers_Change.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

            // Tablonun font ayarını düzenle.

            baglanti.Close();
        }
        private void btn_changeAcc_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            if (btn_Manager.Checked == true)
            {
                baglanti.Open();
                string save = "UPDATE Manager_Account SET name = @name, surname = @surname, username = @username, password = @password, pin = @pin WHERE id = @id";

                SqlCommand cmd = new SqlCommand(save, baglanti);

                cmd.Parameters.AddWithValue("@name", txtBox_Name.Text);
                cmd.Parameters.AddWithValue("@surname", txtBox_SurName.Text);
                cmd.Parameters.AddWithValue("@username", txtBox_UserName.Text);
                cmd.Parameters.AddWithValue("@password", txtBox_Password.Text);
                cmd.Parameters.AddWithValue("@pin", txtBox_PIN.Text);
                cmd.Parameters.AddWithValue("id", txtBox_ID.Text);

                // txtboxlara girilen verileri SQL daki tablo sütunlarındaki verilerle değiştir.

                cmd.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Yönetici Bilgileri Güncellendi.");
            }
            if (btn_Chef.Checked == true)
            {
                baglanti.Open();
                string save = "UPDATE Chef_Account SET name = @name, surname = @surname, username = @username, password = @password, pin = @pin WHERE id = @id";

                SqlCommand cmd = new SqlCommand(save, baglanti);

                cmd.Parameters.AddWithValue("@name", txtBox_Name.Text);
                cmd.Parameters.AddWithValue("@surname", txtBox_SurName.Text);
                cmd.Parameters.AddWithValue("@username", txtBox_UserName.Text);
                cmd.Parameters.AddWithValue("@password", txtBox_Password.Text);
                cmd.Parameters.AddWithValue("@pin", txtBox_PIN.Text);
                cmd.Parameters.AddWithValue("id", txtBox_ID.Text);

                // txtboxlara girilen verileri SQL daki tablo sütunlarındaki verilerle değiştir.

                cmd.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Şef Bilgileri Güncellendi.");
            }
            if (btn_AssistantChef.Checked == true)
            {
                baglanti.Open();
                string save = "UPDATE Assistant_Chef_Account SET name = @name, surname = @surname, username = @username, password = @password, pin = @pin WHERE id = @id";

                SqlCommand cmd = new SqlCommand(save, baglanti);

                cmd.Parameters.AddWithValue("@name", txtBox_Name.Text);
                cmd.Parameters.AddWithValue("@surname", txtBox_SurName.Text);
                cmd.Parameters.AddWithValue("@username", txtBox_UserName.Text);
                cmd.Parameters.AddWithValue("@password", txtBox_Password.Text);
                cmd.Parameters.AddWithValue("@pin", txtBox_PIN.Text);
                cmd.Parameters.AddWithValue("id", txtBox_ID.Text);

                // txtboxlara girilen verileri SQL daki tablo sütunlarındaki verilerle değiştir.

                cmd.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Yardımcı Şef Bilgileri Güncellendi.");
            }
            if (btn_Waiter.Checked == true)
            {
                baglanti.Open();
                string save = "UPDATE Waiter_Account SET name = @name, surname = @surname, username = @username, password = @password, pin = @pin WHERE id = @id";

                SqlCommand cmd = new SqlCommand(save, baglanti);

                cmd.Parameters.AddWithValue("@name", txtBox_Name.Text);
                cmd.Parameters.AddWithValue("@surname", txtBox_SurName.Text);
                cmd.Parameters.AddWithValue("@username", txtBox_UserName.Text);
                cmd.Parameters.AddWithValue("@password", txtBox_Password.Text);
                cmd.Parameters.AddWithValue("@pin", txtBox_PIN.Text);
                cmd.Parameters.AddWithValue("id", txtBox_ID.Text);

                // txtboxlara girilen verileri SQL daki tablo sütunlarındaki verilerle değiştir.

                cmd.ExecuteNonQuery();

                baglanti.Close();

                MessageBox.Show("Garson Bilgileri Güncellendi.");
            }

            // radiobuttonları kontrol et eğer true değerini dönderiyorsa seçilen satırı SQL tablosunda düzenle.
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            if (btn_Manager.Checked == true)
            {
                baglanti.Open();

                SqlDataAdapter adapterManager = new SqlDataAdapter("SELECT id,name,surname,username,password,pin FROM Manager_Account", baglanti);
                DataTable tableManager = new DataTable();
                adapterManager.Fill(tableManager);

                tableManager.Columns["id"].ColumnName = "ID";
                tableManager.Columns["name"].ColumnName = "İsim";
                tableManager.Columns["surname"].ColumnName = "Soyisim";
                tableManager.Columns["username"].ColumnName = "Kullanıcı Adı";
                tableManager.Columns["password"].ColumnName = "Şifre";
                tableManager.Columns["pin"].ColumnName = "Özel PIN Kodu";

                // Kolon isimlerini düzenle.

                dataGridView_Manager_Workers_Change.DataSource = tableManager;

                dataGridView_Manager_Workers_Change.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

                // Tablonun font ayarını düzenle.

                baglanti.Close();
            }
            if (btn_Chef.Checked == true)
            {
                baglanti.Open();

                SqlDataAdapter adapterEmployee = new SqlDataAdapter("SELECT id,name,surname,username,password,pin FROM Chef_Account", baglanti);
                DataTable tableEmployee = new DataTable();
                adapterEmployee.Fill(tableEmployee);

                tableEmployee.Columns["id"].ColumnName = "ID";
                tableEmployee.Columns["name"].ColumnName = "İsim";
                tableEmployee.Columns["surname"].ColumnName = "Soyisim";
                tableEmployee.Columns["username"].ColumnName = "Kullanıcı Adı";
                tableEmployee.Columns["password"].ColumnName = "Şifre";
                tableEmployee.Columns["pin"].ColumnName = "Özel PIN Kodu";

                // Kolon isimlerini düzenle.

                dataGridView_Manager_Workers_Change.DataSource = tableEmployee;

                dataGridView_Manager_Workers_Change.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

                // Tablonun font ayarını düzenle.

                baglanti.Close();
            }
            if (btn_AssistantChef.Checked == true)
            {
                baglanti.Open();

                SqlDataAdapter adapterEmployee = new SqlDataAdapter("SELECT id,name,surname,username,password,pin FROM Assistant_Chef_Account", baglanti);
                DataTable tableEmployee = new DataTable();
                adapterEmployee.Fill(tableEmployee);

                tableEmployee.Columns["id"].ColumnName = "ID";
                tableEmployee.Columns["name"].ColumnName = "İsim";
                tableEmployee.Columns["surname"].ColumnName = "Soyisim";
                tableEmployee.Columns["username"].ColumnName = "Kullanıcı Adı";
                tableEmployee.Columns["password"].ColumnName = "Şifre";
                tableEmployee.Columns["pin"].ColumnName = "Özel PIN Kodu";

                // Kolon isimlerini düzenle.

                dataGridView_Manager_Workers_Change.DataSource = tableEmployee;

                dataGridView_Manager_Workers_Change.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

                // Tablonun font ayarını düzenle.

                baglanti.Close();
            }
            if (btn_Waiter.Checked == true)
            {
                baglanti.Open();

                SqlDataAdapter adapterEmployee = new SqlDataAdapter("SELECT id,name,surname,username,password,pin FROM Waiter_Account", baglanti);
                DataTable tableEmployee = new DataTable();
                adapterEmployee.Fill(tableEmployee);

                tableEmployee.Columns["id"].ColumnName = "ID";
                tableEmployee.Columns["name"].ColumnName = "İsim";
                tableEmployee.Columns["surname"].ColumnName = "Soyisim";
                tableEmployee.Columns["username"].ColumnName = "Kullanıcı Adı";
                tableEmployee.Columns["password"].ColumnName = "Şifre";
                tableEmployee.Columns["pin"].ColumnName = "Özel PIN Kodu";

                // Kolon isimlerini düzenle.

                dataGridView_Manager_Workers_Change.DataSource = tableEmployee;

                dataGridView_Manager_Workers_Change.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

                // Tablonun font ayarını düzenle.

                baglanti.Close();
            }
            // radiobuttonları kontrol et eğer true değerini dönderiyorsa seçilen butondaki tabloyu güncelle(refresh).
        }
        private void txtBox_PIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            //Kullanıcı PIN kısmına sadece rakam girebilir.
        }
    }
}