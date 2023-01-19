using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cafe_Project
{
    public partial class employee_Table : DevExpress.XtraEditors.XtraForm
    {
        BaglantiSinif bgl = new BaglantiSinif();
        public employee_Table()
        {
            InitializeComponent();
        }
        private void employee_Table_Load(object sender, EventArgs e)
        {
            screenSettings();

            // Ekran boyutunu otomatik ayarlama. 

            change_Color_Table1();
            change_Color_Table2();
            change_Color_Table3();
            change_Color_Table4();
            change_Color_Table5();
            change_Color_Table6();
            change_Color_Table7();
            change_Color_Table8();
            change_Color_Table9();
            change_Color_Table10();
            change_Color_Table11();
            change_Color_Table12();

            // // Masalardan herhangi biri doluysa masanın rengini kırmızı, eğer boşsa yeşil olarak değiştir.
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

        private void btn_Table1_Click(object sender, EventArgs e)
        {
            employee_Tables_Table1 employee_Tables_Table1 = new employee_Tables_Table1();

            employee_Tables_Table1.Show();

            this.Close();

            // Bu formu kapat Masa1 formunu aç
        }
        private void btn_Table2_Click(object sender, EventArgs e)
        {
            employee_Tables_Table2 employee_Tables_Table2 = new employee_Tables_Table2();

            employee_Tables_Table2.Show();

            this.Close();

            // Bu formu kapat Masa2 formunu aç
        }
        private void btn_Table3_Click(object sender, EventArgs e)
        {
            employee_Tables_Table3 employee_Tables_Table3 = new employee_Tables_Table3();

            employee_Tables_Table3.Show();

            this.Close();

            // Bu formu kapat Masa3 formunu aç
        }
        private void btn_Table4_Click(object sender, EventArgs e)
        {
            employee_Tables_Table4 employee_Tables_Table4 = new employee_Tables_Table4();

            employee_Tables_Table4.Show();

            this.Close();

            // Bu formu kapat Masa4 formunu aç
        }
        private void btn_Table5_Click(object sender, EventArgs e)
        {
            employee_Tables_Table5 employee_Tables_Table5 = new employee_Tables_Table5();

            employee_Tables_Table5.Show();

            this.Close();

            // Bu formu kapat Masa5 formunu aç
        }
        private void btn_Table6_Click(object sender, EventArgs e)
        {
            employee_Tables_Table6 employee_Tables_Table6 = new employee_Tables_Table6();

            employee_Tables_Table6.Show();

            this.Close();

            // Bu formu kapat Masa6 formunu aç
        }
        private void btn_Table7_Click(object sender, EventArgs e)
        {
            employee_Tables_Table7 employee_Tables_Table7 = new employee_Tables_Table7();

            employee_Tables_Table7.Show();

            this.Close();

            // Bu formu kapat Masa7 formunu aç
        }
        private void btn_Table8_Click(object sender, EventArgs e)
        {
            employee_Tables_Table8 employee_Tables_Table8 = new employee_Tables_Table8();

            employee_Tables_Table8.Show();

            this.Close();

            // Bu formu kapat Masa8 formunu aç
        }
        private void btn_Table9_Click(object sender, EventArgs e)
        {
            employee_Tables_Table9 employee_Tables_Table9 = new employee_Tables_Table9();

            employee_Tables_Table9.Show();

            this.Close();

            // Bu formu kapat Masa9 formunu aç
        }
        private void btn_Table10_Click(object sender, EventArgs e)
        {
            employee_Tables_Table10 employee_Tables_Table10 = new employee_Tables_Table10();

            employee_Tables_Table10.Show();

            this.Close();

            // Bu formu kapat Masa10 formunu aç
        }
        private void btn_Table11_Click(object sender, EventArgs e)
        {
            employee_Tables_Table11 employee_Tables_Table11 = new employee_Tables_Table11();

            employee_Tables_Table11.Show();

            this.Close();

            // Bu formu kapat Masa11 formunu aç
        }
        private void btn_Table12_Click(object sender, EventArgs e)
        {
            employee_Tables_Table12 employee_Tables_Table12 = new employee_Tables_Table12();

            employee_Tables_Table12.Show();

            this.Close();

            // Bu formu kapat Masa12 formunu aç
        }

        public void change_Color_Table1()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            int recordsNumber = -1;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand cmdTable1 = new SqlCommand("SELECT COUNT(*) FROM Table1", baglanti);

            recordsNumber = Convert.ToInt32(cmdTable1.ExecuteScalar());

            if (recordsNumber > 0)
            {
                btn_Table1.Appearance.BackColor = Color.Red;
            }

            baglanti.Close();

            // Masa 1 doluysa masa1in rengini kırmızı, eğer boşsa yeşil olarak değiştir.
        }
        public void change_Color_Table2()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            int recordsNumber = -1;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand cmdTable2 = new SqlCommand("SELECT COUNT(*) FROM Table2", baglanti);

            recordsNumber = Convert.ToInt32(cmdTable2.ExecuteScalar());

            if (recordsNumber > 0)
            {
                btn_Table2.Appearance.BackColor = Color.Red;
            }

            baglanti.Close();

            // Masa 2 doluysa masa1in rengini kırmızı, eğer boşsa yeşil olarak değiştir.
        }
        public void change_Color_Table3()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            int recordsNumber = -1;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand cmdTable3 = new SqlCommand("SELECT COUNT(*) FROM Table3", baglanti);

            recordsNumber = Convert.ToInt32(cmdTable3.ExecuteScalar());

            if (recordsNumber > 0)
            {
                btn_Table3.Appearance.BackColor = Color.Red;
            }

            baglanti.Close();

            // Masa 3 doluysa masa1in rengini kırmızı, eğer boşsa yeşil olarak değiştir.
        }
        public void change_Color_Table4()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            int recordsNumber = -1;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand cmdTable4 = new SqlCommand("SELECT COUNT(*) FROM Table4", baglanti);

            recordsNumber = Convert.ToInt32(cmdTable4.ExecuteScalar());

            if (recordsNumber > 0)
            {
                btn_Table4.Appearance.BackColor = Color.Red;
            }

            baglanti.Close();

            // Masa 4 doluysa masanın rengini kırmızı, eğer boşsa yeşil olarak değiştir.
        }
        public void change_Color_Table5()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            int recordsNumber = -1;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand cmdTable5 = new SqlCommand("SELECT COUNT(*) FROM Table5", baglanti);

            recordsNumber = Convert.ToInt32(cmdTable5.ExecuteScalar());

            if (recordsNumber > 0)
            {
                btn_Table5.Appearance.BackColor = Color.Red;
            }

            baglanti.Close();

            // Masa 5 doluysa masa1in rengini kırmızı, eğer boşsa yeşil olarak değiştir.
        }
        public void change_Color_Table6()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            int recordsNumber = -1;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand cmdTable6 = new SqlCommand("SELECT COUNT(*) FROM Table6", baglanti);

            recordsNumber = Convert.ToInt32(cmdTable6.ExecuteScalar());

            if (recordsNumber > 0)
            {
                btn_Table6.Appearance.BackColor = Color.Red;
            }

            baglanti.Close();

            // Masa 6 doluysa masa1in rengini kırmızı, eğer boşsa yeşil olarak değiştir.
        }
        public void change_Color_Table7()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            int recordsNumber = -1;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand cmdTable7 = new SqlCommand("SELECT COUNT(*) FROM Table7", baglanti);

            recordsNumber = Convert.ToInt32(cmdTable7.ExecuteScalar());

            if (recordsNumber > 0)
            {
                btn_Table7.Appearance.BackColor = Color.Red;
            }

            baglanti.Close();

            // Masa 7 doluysa masa1in rengini kırmızı, eğer boşsa yeşil olarak değiştir.
        }
        public void change_Color_Table8()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            int recordsNumber = -1;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand cmdTable8 = new SqlCommand("SELECT COUNT(*) FROM Table8", baglanti);

            recordsNumber = Convert.ToInt32(cmdTable8.ExecuteScalar());

            if (recordsNumber > 0)
            {
                btn_Table8.Appearance.BackColor = Color.Red;
            }

            baglanti.Close();

            // Masa 8 doluysa masa1in rengini kırmızı, eğer boşsa yeşil olarak değiştir.
        }
        public void change_Color_Table9()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            int recordsNumber = -1;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand cmdTable9 = new SqlCommand("SELECT COUNT(*) FROM Table9", baglanti);

            recordsNumber = Convert.ToInt32(cmdTable9.ExecuteScalar());

            if (recordsNumber > 0)
            {
                btn_Table9.Appearance.BackColor = Color.Red;
            }

            baglanti.Close();

            // Masa 9 doluysa masa1in rengini kırmızı, eğer boşsa yeşil olarak değiştir.
        }
        public void change_Color_Table10()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            int recordsNumber = -1;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand cmdTable10 = new SqlCommand("SELECT COUNT(*) FROM Table10", baglanti);

            recordsNumber = Convert.ToInt32(cmdTable10.ExecuteScalar());

            if (recordsNumber > 0)
            {
                btn_Table10.Appearance.BackColor = Color.Red;
            }

            baglanti.Close();

            // Masa 10 doluysa masa1in rengini kırmızı, eğer boşsa yeşil olarak değiştir.
        }
        public void change_Color_Table11()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            int recordsNumber = -1;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand cmdTable11 = new SqlCommand("SELECT COUNT(*) FROM Table11", baglanti);

            recordsNumber = Convert.ToInt32(cmdTable11.ExecuteScalar());

            if (recordsNumber > 0)
            {
                btn_Table11.Appearance.BackColor = Color.Red;
            }

            baglanti.Close();

            // Masa 11 doluysa masa1in rengini kırmızı, eğer boşsa yeşil olarak değiştir.
        }
        public void change_Color_Table12()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            int recordsNumber = -1;

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand cmdTable12 = new SqlCommand("SELECT COUNT(*) FROM Table12", baglanti);

            recordsNumber = Convert.ToInt32(cmdTable12.ExecuteScalar());

            if (recordsNumber > 0)
            {
                btn_Table12.Appearance.BackColor = Color.Red;
            }

            baglanti.Close();

            // Masa 12 doluysa masa1in rengini kırmızı, eğer boşsa yeşil olarak değiştir.
        }
    }
}