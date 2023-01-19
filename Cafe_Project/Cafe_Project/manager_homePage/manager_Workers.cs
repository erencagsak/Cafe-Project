using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Cafe_Project
{
    public partial class manager_Workers : DevExpress.XtraEditors.XtraForm
    {
        BaglantiSinif bgl = new BaglantiSinif();

        // SQL Bağlantıları
        public manager_Workers()
        {
            InitializeComponent();
        }
        private void manager_Workers_Load(object sender, EventArgs e)
        {
            screenSettings();

            // Ekran boyutunu otomatik ayarlama.

            change_Apperance_datadataGriedView_Manager_Worker();

            // datadataGriedView_Manager_Worker'un kolonların rengini düzenle.
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
        public void change_Apperance_datadataGriedView_Manager_Worker()
        {
            dataGriedView_Manager_Worker.ColumnHeadersDefaultCellStyle.BackColor = Color.Moccasin;
            dataGriedView_Manager_Worker.EnableHeadersVisualStyles = false;
        }
        private void btn_Manager_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlDataAdapter adapterManager = new SqlDataAdapter("SELECT id,name,surname,username,password,pin FROM Manager_Account", baglanti);
            DataTable tableManager = new DataTable();
            adapterManager.Fill(tableManager);

            tableManager.Columns["id"].ColumnName = "ID";
            tableManager.Columns["name"].ColumnName = "İsim";
            tableManager.Columns["surname"].ColumnName = "Soyisim";
            tableManager.Columns["username"].ColumnName = "Kullanıcı Adı";
            tableManager.Columns["password"].ColumnName = "Şifre";
            tableManager.Columns["pin"].ColumnName = "Özel PIN Kodu";

            // Çağrılan tablonun sütun isimlerini değiştir.

            dataGriedView_Manager_Worker.DataSource = tableManager;

            dataGriedView_Manager_Worker.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

            // Tablonun yazı fontunu değiştir.

            baglanti.Close();
        }
        private void btn_Chef_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlDataAdapter adapterEmployee = new SqlDataAdapter("SELECT id,name,surname,username,password,pin FROM Chef_Account", baglanti);
            DataTable tableEmployee = new DataTable();
            adapterEmployee.Fill(tableEmployee);

            tableEmployee.Columns["id"].ColumnName = "ID";
            tableEmployee.Columns["name"].ColumnName = "İsim";
            tableEmployee.Columns["surname"].ColumnName = "Soyisim";
            tableEmployee.Columns["username"].ColumnName = "Kullanıcı Adı";
            tableEmployee.Columns["password"].ColumnName = "Şifre";
            tableEmployee.Columns["pin"].ColumnName = "Özel PIN Kodu";

            // Çağrılan tablonun sütun isimlerini değiştir.

            dataGriedView_Manager_Worker.DataSource = tableEmployee;

            dataGriedView_Manager_Worker.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

            // Tablonun yazı fontunu değiştir.

            baglanti.Close();
        }
        private void btn_AssistantChef_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlDataAdapter adapterEmployee = new SqlDataAdapter("SELECT id,name,surname,username,password,pin FROM Assistant_Chef_Account", baglanti);
            DataTable tableEmployee = new DataTable();
            adapterEmployee.Fill(tableEmployee);

            tableEmployee.Columns["id"].ColumnName = "ID";
            tableEmployee.Columns["name"].ColumnName = "İsim";
            tableEmployee.Columns["surname"].ColumnName = "Soyisim";
            tableEmployee.Columns["username"].ColumnName = "Kullanıcı Adı";
            tableEmployee.Columns["password"].ColumnName = "Şifre";
            tableEmployee.Columns["pin"].ColumnName = "Özel PIN Kodu";

            // Çağrılan tablonun sütun isimlerini değiştir.

            dataGriedView_Manager_Worker.DataSource = tableEmployee;

            dataGriedView_Manager_Worker.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

            // Tablonun yazı fontunu değiştir.

            baglanti.Close();
        }
        private void btn_Waiter_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlDataAdapter adapterEmployee = new SqlDataAdapter("SELECT id,name,surname,username,password,pin FROM Waiter_Account", baglanti);
            DataTable tableEmployee = new DataTable();
            adapterEmployee.Fill(tableEmployee);

            tableEmployee.Columns["id"].ColumnName = "ID";
            tableEmployee.Columns["name"].ColumnName = "İsim";
            tableEmployee.Columns["surname"].ColumnName = "Soyisim";
            tableEmployee.Columns["username"].ColumnName = "Kullanıcı Adı";
            tableEmployee.Columns["password"].ColumnName = "Şifre";
            tableEmployee.Columns["pin"].ColumnName = "Özel PIN Kodu";

            // Çağrılan tablonun sütun isimlerini değiştir.

            dataGriedView_Manager_Worker.DataSource = tableEmployee;

            dataGriedView_Manager_Worker.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

            // Tablonun yazı fontunu değiştir.

            baglanti.Close();
        }
        private void btn_deleteAcc_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            if (btn_Manager.Checked == true)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string managerSQL = "SELECT * FROM Manager_Account WHERE id=@id";

                SqlCommand cmdManager = new SqlCommand(managerSQL, baglanti);
                cmdManager.Parameters.AddWithValue("@id", txtBox_ID.Text);
                SqlDataReader readerManager = cmdManager.ExecuteReader();
                SqlDataAdapter managerAdapter = new SqlDataAdapter(cmdManager);

                if (readerManager.Read())
                {
                    string managerName = readerManager["name"].ToString() + " " + readerManager["surname"].ToString();

                    readerManager.Close();

                    DialogResult durum = MessageBox.Show(managerName + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DialogResult.Yes == durum)
                    {
                        string managerDeleteSQL = "DELETE FROM Manager_Account WHERE id=@id";

                        SqlCommand deletecmd = new SqlCommand(managerDeleteSQL, baglanti);
                        deletecmd.Parameters.AddWithValue("@id", txtBox_ID.Text);
                        deletecmd.ExecuteNonQuery();

                        MessageBox.Show("Kayıt Silindi...");
                    }
                }
                else
                    MessageBox.Show("Müşteri Bulunamadı.");

                baglanti.Close();
            }
            if (btn_Chef.Checked == true)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string ChefSQL = "SELECT * FROM Chef_Account WHERE id=@id";

                SqlCommand cmdChef = new SqlCommand(ChefSQL, baglanti);
                cmdChef.Parameters.AddWithValue("@id", txtBox_ID.Text);
                SqlDataReader readerChef = cmdChef.ExecuteReader();
                SqlDataAdapter chefAdapter = new SqlDataAdapter(cmdChef);

                if (readerChef.Read())
                {
                    string chefName = readerChef["name"].ToString() + " " + readerChef["surname"].ToString();

                    readerChef.Close();

                    DialogResult durum = MessageBox.Show(chefName + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DialogResult.Yes == durum)
                    {
                        string chefDeleteSQL = "DELETE FROM Chef_Account WHERE id=@id";

                        SqlCommand deletecmd = new SqlCommand(chefDeleteSQL, baglanti);
                        deletecmd.Parameters.AddWithValue("@id", txtBox_ID.Text);
                        deletecmd.ExecuteNonQuery();

                        MessageBox.Show("Kayıt Silindi...");
                    }
                }
                else
                    MessageBox.Show("Müşteri Bulunamadı.");

                baglanti.Close();
            }
            if (btn_AssistantChef.Checked == true)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string AssistantChefSQL = "SELECT * FROM Assistant_Chef_Account WHERE id=@id";

                SqlCommand cmdAssistantChef = new SqlCommand(AssistantChefSQL, baglanti);
                cmdAssistantChef.Parameters.AddWithValue("@id", txtBox_ID.Text);
                SqlDataReader readerAssistantChef = cmdAssistantChef.ExecuteReader();
                SqlDataAdapter assistantChefAdapter = new SqlDataAdapter(cmdAssistantChef);

                if (readerAssistantChef.Read())
                {
                    string assistantChefName = readerAssistantChef["name"].ToString() + " " + readerAssistantChef["surname"].ToString();

                    readerAssistantChef.Close();

                    DialogResult durum = MessageBox.Show(assistantChefName + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DialogResult.Yes == durum)
                    {
                        string assistantChefDeleteSQL = "DELETE FROM Assistant_Chef_Account WHERE id=@id";

                        SqlCommand deletecmd = new SqlCommand(assistantChefDeleteSQL, baglanti);
                        deletecmd.Parameters.AddWithValue("@id", txtBox_ID.Text);
                        deletecmd.ExecuteNonQuery();

                        MessageBox.Show("Kayıt Silindi...");
                    }
                }
                else
                    MessageBox.Show("Müşteri Bulunamadı.");

                baglanti.Close();
            }
            if (btn_Waiter.Checked == true)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                string waiterSQL = "SELECT * FROM Waiter_Account WHERE id=@id";
                SqlCommand cmdWaiter = new SqlCommand(waiterSQL, baglanti);
                cmdWaiter.Parameters.AddWithValue("@id", txtBox_ID.Text);
                SqlDataReader readerWaiter = cmdWaiter.ExecuteReader();
                SqlDataAdapter waiterAdapter = new SqlDataAdapter(cmdWaiter);

                if (readerWaiter.Read())
                {
                    string waiterName = readerWaiter["name"].ToString() + " " + readerWaiter["surname"].ToString();
                    readerWaiter.Close();

                    DialogResult durum = MessageBox.Show(waiterName + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DialogResult.Yes == durum)
                    {
                        string waiterDeleteSQL = "DELETE FROM Waiter_Account WHERE id=@id";
                        SqlCommand deletecmd = new SqlCommand(waiterDeleteSQL, baglanti);

                        deletecmd.Parameters.AddWithValue("@id", txtBox_ID.Text);

                        deletecmd.ExecuteNonQuery();

                        MessageBox.Show("Kayıt Silindi...");
                    }
                }
                else
                    MessageBox.Show("Müşteri Bulunamadı.");

                baglanti.Close();
            }
            // radiobuttonları kontrol et eğer true değerini dönderiyorsa seçilen satırı SQL tablosundan sil.
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            manager_homePage manager_HomePage = new manager_homePage();

            manager_HomePage.Show();
            this.Close();

            // Geri dön tuşuyla Yönetici ana sayfasına dön.
        }
        private void dataGriedView_Manager_Worker_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBox_ID.Text = dataGriedView_Manager_Worker.CurrentRow.Cells[0].Value.ToString();

            // txtBox_ID kısmına datagriedviewın seçilen satırındaki 0. kolonundaki verileri yazdır.
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            if (btn_Manager.Checked == true)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

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

                dataGriedView_Manager_Worker.DataSource = tableManager;

                dataGriedView_Manager_Worker.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

                // Tablonun font ayarını düzenle.

                baglanti.Close();
            }
            if (btn_Chef.Checked == true)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

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

                dataGriedView_Manager_Worker.DataSource = tableEmployee;

                dataGriedView_Manager_Worker.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

                // Tablonun font ayarını düzenle.

                baglanti.Close();
            }
            if (btn_AssistantChef.Checked == true)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

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

                dataGriedView_Manager_Worker.DataSource = tableEmployee;

                dataGriedView_Manager_Worker.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

                // Tablonun font ayarını düzenle.

                baglanti.Close();
            }
            if (btn_Waiter.Checked == true)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

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

                dataGriedView_Manager_Worker.DataSource = tableEmployee;

                dataGriedView_Manager_Worker.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

                // Tablonun font ayarını düzenle.

                baglanti.Close();
            }
            // radiobuttonları kontrol et eğer true değerini dönderiyorsa seçilen butondaki tabloyu güncelle(refresh).
        }
        private void btn_addNewAcc_Click(object sender, EventArgs e)
        {
            var addAcc = new manager_Workers_addNewAcc
            {
                ShowInTaskbar = false,
                MaximizeBox = false,
                MinimizeBox = false

                // Formun üstündeki simgeleri, büyütmeyi, küçültmeyi kapatır.
            };
            addAcc.StartPosition = FormStartPosition.CenterParent;
            addAcc.ShowDialog(this);

            // manager_Workers_addNewAcc formunu manager_Workers formu içinde açmak için kullanıldı.
        }
            private void btn_changeAcc_Click(object sender, EventArgs e)
        {
            var changeAcc = new manager_Workers_Change
            {
                ShowInTaskbar = false,
                MaximizeBox = false,
                MinimizeBox = false

                // Formun üstündeki simgeleri, büyütmeyi, küçültmeyi kapatır.
            };
            changeAcc.StartPosition = FormStartPosition.CenterParent;
            changeAcc.ShowDialog(this);

            // manager_Workers_addNewAcc formunu manager_Workers formu içinde açmak için kullanıldı.
        }
    }
}