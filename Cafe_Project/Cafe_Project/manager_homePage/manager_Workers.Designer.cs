namespace Cafe_Project
{
    partial class manager_Workers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_Workers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Back = new DevExpress.XtraEditors.SimpleButton();
            this.dataGriedView_Manager_Worker = new System.Windows.Forms.DataGridView();
            this.btn_addNewAcc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_deleteAcc = new DevExpress.XtraEditors.SimpleButton();
            this.workersInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managerAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_changeAcc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Manager = new System.Windows.Forms.RadioButton();
            this.btn_AssistantChef = new System.Windows.Forms.RadioButton();
            this.btn_Chef = new System.Windows.Forms.RadioButton();
            this.btn_Waiter = new System.Windows.Forms.RadioButton();
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriedView_Manager_Worker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerAccountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Appearance.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Back.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 5F, System.Drawing.FontStyle.Bold);
            this.btn_Back.Appearance.Options.UseBackColor = true;
            this.btn_Back.Appearance.Options.UseFont = true;
            this.btn_Back.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.ImageOptions.Image")));
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(87, 29);
            this.btn_Back.TabIndex = 8;
            this.btn_Back.Text = "Geri Dön";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dataGriedView_Manager_Worker
            // 
            this.dataGriedView_Manager_Worker.AllowUserToAddRows = false;
            this.dataGriedView_Manager_Worker.AllowUserToDeleteRows = false;
            this.dataGriedView_Manager_Worker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGriedView_Manager_Worker.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGriedView_Manager_Worker.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataGriedView_Manager_Worker.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGriedView_Manager_Worker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGriedView_Manager_Worker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriedView_Manager_Worker.Location = new System.Drawing.Point(217, 131);
            this.dataGriedView_Manager_Worker.Name = "dataGriedView_Manager_Worker";
            this.dataGriedView_Manager_Worker.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGriedView_Manager_Worker.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGriedView_Manager_Worker.Size = new System.Drawing.Size(849, 481);
            this.dataGriedView_Manager_Worker.TabIndex = 1;
            this.dataGriedView_Manager_Worker.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGriedView_Manager_Worker_CellEnter);
            // 
            // btn_addNewAcc
            // 
            this.btn_addNewAcc.Appearance.BackColor = System.Drawing.Color.Moccasin;
            this.btn_addNewAcc.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.btn_addNewAcc.Appearance.Options.UseBackColor = true;
            this.btn_addNewAcc.Appearance.Options.UseFont = true;
            this.btn_addNewAcc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_addNewAcc.ImageOptions.Image")));
            this.btn_addNewAcc.Location = new System.Drawing.Point(1072, 131);
            this.btn_addNewAcc.Name = "btn_addNewAcc";
            this.btn_addNewAcc.Size = new System.Drawing.Size(143, 68);
            this.btn_addNewAcc.TabIndex = 4;
            this.btn_addNewAcc.Text = "YENİ KAYIT EKLE";
            this.btn_addNewAcc.Click += new System.EventHandler(this.btn_addNewAcc_Click);
            // 
            // btn_deleteAcc
            // 
            this.btn_deleteAcc.Appearance.BackColor = System.Drawing.Color.Moccasin;
            this.btn_deleteAcc.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.btn_deleteAcc.Appearance.Options.UseBackColor = true;
            this.btn_deleteAcc.Appearance.Options.UseFont = true;
            this.btn_deleteAcc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteAcc.ImageOptions.Image")));
            this.btn_deleteAcc.Location = new System.Drawing.Point(1072, 279);
            this.btn_deleteAcc.Name = "btn_deleteAcc";
            this.btn_deleteAcc.Size = new System.Drawing.Size(143, 68);
            this.btn_deleteAcc.TabIndex = 6;
            this.btn_deleteAcc.Text = "KAYIT SİL ";
            this.btn_deleteAcc.Click += new System.EventHandler(this.btn_deleteAcc_Click);
            // 
            // workersInformationBindingSource
            // 
            this.workersInformationBindingSource.DataMember = "Workers_Information";
            // 
            // btn_changeAcc
            // 
            this.btn_changeAcc.Appearance.BackColor = System.Drawing.Color.Moccasin;
            this.btn_changeAcc.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.btn_changeAcc.Appearance.Options.UseBackColor = true;
            this.btn_changeAcc.Appearance.Options.UseFont = true;
            this.btn_changeAcc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_changeAcc.ImageOptions.Image")));
            this.btn_changeAcc.Location = new System.Drawing.Point(1072, 205);
            this.btn_changeAcc.Name = "btn_changeAcc";
            this.btn_changeAcc.Size = new System.Drawing.Size(143, 68);
            this.btn_changeAcc.TabIndex = 5;
            this.btn_changeAcc.Text = "KAYIT DÜZENLE";
            this.btn_changeAcc.Click += new System.EventHandler(this.btn_changeAcc_Click);
            // 
            // btn_Manager
            // 
            this.btn_Manager.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Manager.AutoSize = true;
            this.btn_Manager.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Manager.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btn_Manager.Image = ((System.Drawing.Image)(resources.GetObject("btn_Manager.Image")));
            this.btn_Manager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Manager.Location = new System.Drawing.Point(217, 94);
            this.btn_Manager.Name = "btn_Manager";
            this.btn_Manager.Size = new System.Drawing.Size(109, 40);
            this.btn_Manager.TabIndex = 0;
            this.btn_Manager.TabStop = true;
            this.btn_Manager.Text = "    Yöneticiler";
            this.btn_Manager.UseVisualStyleBackColor = false;
            this.btn_Manager.CheckedChanged += new System.EventHandler(this.btn_Manager_CheckedChanged);
            // 
            // btn_AssistantChef
            // 
            this.btn_AssistantChef.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_AssistantChef.AutoSize = true;
            this.btn_AssistantChef.BackColor = System.Drawing.Color.Moccasin;
            this.btn_AssistantChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AssistantChef.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btn_AssistantChef.Image = ((System.Drawing.Image)(resources.GetObject("btn_AssistantChef.Image")));
            this.btn_AssistantChef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AssistantChef.Location = new System.Drawing.Point(458, 94);
            this.btn_AssistantChef.Name = "btn_AssistantChef";
            this.btn_AssistantChef.Size = new System.Drawing.Size(147, 40);
            this.btn_AssistantChef.TabIndex = 2;
            this.btn_AssistantChef.TabStop = true;
            this.btn_AssistantChef.Text = "     Şef Yardımcıları";
            this.btn_AssistantChef.UseVisualStyleBackColor = false;
            this.btn_AssistantChef.CheckedChanged += new System.EventHandler(this.btn_AssistantChef_CheckedChanged);
            // 
            // btn_Chef
            // 
            this.btn_Chef.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Chef.AutoSize = true;
            this.btn_Chef.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Chef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Chef.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btn_Chef.Image = ((System.Drawing.Image)(resources.GetObject("btn_Chef.Image")));
            this.btn_Chef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Chef.Location = new System.Drawing.Point(360, 94);
            this.btn_Chef.Name = "btn_Chef";
            this.btn_Chef.Size = new System.Drawing.Size(76, 40);
            this.btn_Chef.TabIndex = 1;
            this.btn_Chef.TabStop = true;
            this.btn_Chef.Text = "    Şefler";
            this.btn_Chef.UseVisualStyleBackColor = false;
            this.btn_Chef.CheckedChanged += new System.EventHandler(this.btn_Chef_CheckedChanged);
            // 
            // btn_Waiter
            // 
            this.btn_Waiter.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Waiter.AutoSize = true;
            this.btn_Waiter.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Waiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Waiter.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btn_Waiter.Image = ((System.Drawing.Image)(resources.GetObject("btn_Waiter.Image")));
            this.btn_Waiter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Waiter.Location = new System.Drawing.Point(656, 94);
            this.btn_Waiter.Name = "btn_Waiter";
            this.btn_Waiter.Size = new System.Drawing.Size(99, 40);
            this.btn_Waiter.TabIndex = 3;
            this.btn_Waiter.TabStop = true;
            this.btn_Waiter.Text = "   Garsonlar";
            this.btn_Waiter.UseVisualStyleBackColor = false;
            this.btn_Waiter.CheckedChanged += new System.EventHandler(this.btn_Waiter_CheckedChanged);
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.BackColor = System.Drawing.Color.Moccasin;
            this.txtBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_ID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_ID.Location = new System.Drawing.Point(222, 135);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.ReadOnly = true;
            this.txtBox_ID.Size = new System.Drawing.Size(10, 14);
            this.txtBox_ID.TabIndex = 16;
            this.txtBox_ID.TabStop = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Appearance.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Refresh.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 6F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.Appearance.Options.UseBackColor = true;
            this.btn_Refresh.Appearance.Options.UseFont = true;
            this.btn_Refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.ImageOptions.Image")));
            this.btn_Refresh.Location = new System.Drawing.Point(1072, 574);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(76, 38);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "YENİLE";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // manager_Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::Cafe_Project.Properties.Resources.managerPages_Background1;
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.txtBox_ID);
            this.Controls.Add(this.btn_Waiter);
            this.Controls.Add(this.btn_Chef);
            this.Controls.Add(this.btn_AssistantChef);
            this.Controls.Add(this.btn_Manager);
            this.Controls.Add(this.btn_changeAcc);
            this.Controls.Add(this.btn_deleteAcc);
            this.Controls.Add(this.btn_addNewAcc);
            this.Controls.Add(this.dataGriedView_Manager_Worker);
            this.Controls.Add(this.btn_Back);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("manager_Workers.IconOptions.LargeImage")));
            this.Name = "manager_Workers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NONAME | Yönetici Ekranı | Çalışanlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.manager_Workers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGriedView_Manager_Worker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerAccountsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Back;
        private System.Windows.Forms.BindingSource workersInformationBindingSource;
        private System.Windows.Forms.DataGridView dataGriedView_Manager_Worker;
        private System.Windows.Forms.BindingSource managerAccountsBindingSource;
        private DevExpress.XtraEditors.SimpleButton btn_addNewAcc;
        private DevExpress.XtraEditors.SimpleButton btn_deleteAcc;
        private DevExpress.XtraEditors.SimpleButton btn_changeAcc;
        private System.Windows.Forms.RadioButton btn_Manager;
        private System.Windows.Forms.RadioButton btn_AssistantChef;
        private System.Windows.Forms.RadioButton btn_Chef;
        private System.Windows.Forms.RadioButton btn_Waiter;
        private System.Windows.Forms.TextBox txtBox_ID;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
    }
}