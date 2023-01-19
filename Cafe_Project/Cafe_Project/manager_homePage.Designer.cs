namespace Cafe_Project
{
    partial class manager_homePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_homePage));
            this.btn_ManagerList = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ManagerProfit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ManagerTables = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ManagerWorkers = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_Name_Surname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ManagerList
            // 
            this.btn_ManagerList.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.btn_ManagerList.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.btn_ManagerList.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 7F);
            this.btn_ManagerList.Appearance.Options.UseBackColor = true;
            this.btn_ManagerList.Appearance.Options.UseFont = true;
            this.btn_ManagerList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ManagerList.ImageOptions.Image")));
            this.btn_ManagerList.Location = new System.Drawing.Point(983, 450);
            this.btn_ManagerList.Name = "btn_ManagerList";
            this.btn_ManagerList.Size = new System.Drawing.Size(170, 68);
            this.btn_ManagerList.TabIndex = 3;
            this.btn_ManagerList.Text = "İçecekler, Tatlılar\r\nListele";
            this.btn_ManagerList.Click += new System.EventHandler(this.btn_ManagerList_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.btn_Exit.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 7F);
            this.btn_Exit.Appearance.Options.UseBackColor = true;
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.ImageOptions.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(627, 602);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(117, 42);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Çıkış";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_ManagerProfit
            // 
            this.btn_ManagerProfit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.btn_ManagerProfit.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 7F);
            this.btn_ManagerProfit.Appearance.Options.UseBackColor = true;
            this.btn_ManagerProfit.Appearance.Options.UseFont = true;
            this.btn_ManagerProfit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_ManagerProfit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_ManagerProfit.ImageOptions.SvgImage")));
            this.btn_ManagerProfit.Location = new System.Drawing.Point(225, 450);
            this.btn_ManagerProfit.Name = "btn_ManagerProfit";
            this.btn_ManagerProfit.Size = new System.Drawing.Size(170, 68);
            this.btn_ManagerProfit.TabIndex = 2;
            this.btn_ManagerProfit.Text = "Günlük, Aylık\r\nCiro";
            this.btn_ManagerProfit.Click += new System.EventHandler(this.btn_ManagerProfit_Click);
            // 
            // btn_ManagerTables
            // 
            this.btn_ManagerTables.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.btn_ManagerTables.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 7F);
            this.btn_ManagerTables.Appearance.Options.UseBackColor = true;
            this.btn_ManagerTables.Appearance.Options.UseFont = true;
            this.btn_ManagerTables.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ManagerTables.ImageOptions.Image")));
            this.btn_ManagerTables.Location = new System.Drawing.Point(983, 134);
            this.btn_ManagerTables.Name = "btn_ManagerTables";
            this.btn_ManagerTables.Size = new System.Drawing.Size(170, 68);
            this.btn_ManagerTables.TabIndex = 1;
            this.btn_ManagerTables.Text = "Masalar";
            this.btn_ManagerTables.Click += new System.EventHandler(this.btn_ManagerTables_Click);
            // 
            // btn_ManagerWorkers
            // 
            this.btn_ManagerWorkers.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.btn_ManagerWorkers.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 7F);
            this.btn_ManagerWorkers.Appearance.Options.UseBackColor = true;
            this.btn_ManagerWorkers.Appearance.Options.UseFont = true;
            this.btn_ManagerWorkers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ManagerWorkers.ImageOptions.Image")));
            this.btn_ManagerWorkers.Location = new System.Drawing.Point(225, 134);
            this.btn_ManagerWorkers.Name = "btn_ManagerWorkers";
            this.btn_ManagerWorkers.Size = new System.Drawing.Size(170, 68);
            this.btn_ManagerWorkers.TabIndex = 0;
            this.btn_ManagerWorkers.Text = "Çalışanlar";
            this.btn_ManagerWorkers.Click += new System.EventHandler(this.btn_ManagerWorkers_Click);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Welcome.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Welcome.Location = new System.Drawing.Point(17, 9);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(100, 18);
            this.lbl_Welcome.TabIndex = 7;
            this.lbl_Welcome.Text = "Hoş Geldiniz";
            // 
            // lbl_Name_Surname
            // 
            this.lbl_Name_Surname.AutoSize = true;
            this.lbl_Name_Surname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name_Surname.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Name_Surname.Location = new System.Drawing.Point(2, 38);
            this.lbl_Name_Surname.Name = "lbl_Name_Surname";
            this.lbl_Name_Surname.Size = new System.Drawing.Size(153, 18);
            this.lbl_Name_Surname.TabIndex = 8;
            this.lbl_Name_Surname.Text = "lbl_Name_Surname";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_Welcome);
            this.panel1.Controls.Add(this.lbl_Name_Surname);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(1227, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 65);
            this.panel1.TabIndex = 9;
            // 
            // manager_homePage
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ManagerWorkers);
            this.Controls.Add(this.btn_ManagerTables);
            this.Controls.Add(this.btn_ManagerProfit);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ManagerList);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("manager_homePage.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "manager_homePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NONAME | Yönetici Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.manager_homePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_ManagerList;
        private DevExpress.XtraEditors.SimpleButton btn_Exit;
        private DevExpress.XtraEditors.SimpleButton btn_ManagerProfit;
        private DevExpress.XtraEditors.SimpleButton btn_ManagerTables;
        private DevExpress.XtraEditors.SimpleButton btn_ManagerWorkers;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label lbl_Name_Surname;
        private System.Windows.Forms.Panel panel1;
    }
}