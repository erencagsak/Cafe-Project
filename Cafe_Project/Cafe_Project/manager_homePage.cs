using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cafe_Project
{
    public partial class manager_homePage : DevExpress.XtraEditors.XtraForm
    {
        BaglantiSinif bgl = new BaglantiSinif();

        SqlCommand cmdManager = new SqlCommand();

        // SQL bağlantısı , komut
        public manager_homePage()
        {
            InitializeComponent();
        }

        private void manager_homePage_Load(object sender, EventArgs e)
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

            cmdManager = new SqlCommand("SELECT * FROM Manager_Account WHERE username = @value", baglanti);

            cmdManager.Parameters.AddWithValue("@value", Lgin_Page.outgoingInformation);

            SqlDataReader readerManager = cmdManager.ExecuteReader();

            while (readerManager.Read())
            {
                name = readerManager["name"].ToString();
                surname = readerManager["surname"].ToString();
            }

            readerManager.Close();
            cmdManager.Dispose();
            baglanti.Close();

            lbl_Name_Surname.Text = name + " " + surname;

            // Ekranın sağ üst köşesine lbl içerisine o an giriş yapan kullanıcının bilgilerini yazdırır.
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

            // Exit butonuna basıldığında uygulamadan çık.
        }
        private void btn_ManagerWorkers_Click(object sender, EventArgs e)
        {
            manager_Workers manager_Workers = new manager_Workers();
            manager_Workers.Show();
            this.Close();

            // Bu ekranı kapat ve manager_Workers ekranını aç.
        }

        private void btn_ManagerTables_Click(object sender, EventArgs e)
        {
            manager_Tables manager_Tables = new manager_Tables();

            manager_Tables.Show();
            this.Close();

            // Bu ekranı kapat ve manager_Tables ekranını aç.
        }

        private void btn_ManagerList_Click(object sender, EventArgs e)
        {
            manager_List manager_List = new manager_List();

            manager_List.Show();
            this.Close();

            // Bu ekranı kapat ve manager_List ekranını aç.
        }

        private void btn_ManagerProfit_Click(object sender, EventArgs e)
        {
            manager_Sale manager_Sale = new manager_Sale();

            manager_Sale.Show();
            this.Close();

            // Bu ekranı kapat ve manager_Sale ekranını aç.
        }
    }
}