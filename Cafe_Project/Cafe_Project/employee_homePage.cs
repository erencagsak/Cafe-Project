using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cafe_Project
{
    public partial class employee_homePage : DevExpress.XtraEditors.XtraForm
    {
        BaglantiSinif bgl = new BaglantiSinif();

        SqlCommand cmdEmployee = new SqlCommand();
        public employee_homePage()
        {
            InitializeComponent();
        }
        private void employee_homePage_Load(object sender, EventArgs e)
        {
            screenSettings();

            // Ekran boyutunu otomatik ayarlama.

            writeScreen();

            // Ekranın sağ üst köşesine lbl içerisine o an giriş yapan kullanıcının bilgilerini yazdırır.
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
        public void writeScreen()
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adress);

            string name = "";
            string surname = "";

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            cmdEmployee = new SqlCommand("SELECT * FROM Waiter_Account WHERE username = @value", baglanti);

            cmdEmployee.Parameters.AddWithValue("@value", Lgin_Page.outgoingInformation);

            SqlDataReader readerManager = cmdEmployee.ExecuteReader();

            while (readerManager.Read())
            {
                name = readerManager["name"].ToString();
                surname = readerManager["surname"].ToString();
            }

            readerManager.Close();
            cmdEmployee.Dispose();
            baglanti.Close();

            lbl_Name_Surname.Text = name + " " + surname;

            // Ekranın sağ üst köşesine lbl içerisine o an giriş yapan kullanıcının bilgilerini yazdırır.
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

            // Exit butonuna basıldığında uygulamadan çık.
        }
        private void btn_Tables_Click(object sender, EventArgs e)
        {
            employee_Table employee_Table = new employee_Table();

            employee_Table.Show();

            this.Close();
        }
        private void btn_List_Click(object sender, EventArgs e)
        {
            employee_List employee_List = new employee_List();

            employee_List.Show();

            this.Close();
        }

        private void btn_Endorsement_Click(object sender, EventArgs e)
        {
            employee_Sale employee_Sale = new employee_Sale();

            employee_Sale.Show();

            this.Close();
        }
    }
}