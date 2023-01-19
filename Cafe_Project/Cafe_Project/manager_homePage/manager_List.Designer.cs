namespace Cafe_Project
{
    partial class manager_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_List));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            this.btn_Coffe = new System.Windows.Forms.RadioButton();
            this.btn_Drinks = new System.Windows.Forms.RadioButton();
            this.btn_Sweets = new System.Windows.Forms.RadioButton();
            this.btn_GeriDon = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Change = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView_Manager_List = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Manager_List)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.txtBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Italic);
            this.txtBox_ID.Location = new System.Drawing.Point(973, 202);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.ReadOnly = true;
            this.txtBox_ID.Size = new System.Drawing.Size(13, 18);
            this.txtBox_ID.TabIndex = 34;
            this.txtBox_ID.TabStop = false;
            // 
            // btn_Coffe
            // 
            this.btn_Coffe.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Coffe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.btn_Coffe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Coffe.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Coffe.ForeColor = System.Drawing.Color.Black;
            this.btn_Coffe.Image = ((System.Drawing.Image)(resources.GetObject("btn_Coffe.Image")));
            this.btn_Coffe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Coffe.Location = new System.Drawing.Point(804, 58);
            this.btn_Coffe.Name = "btn_Coffe";
            this.btn_Coffe.Size = new System.Drawing.Size(135, 39);
            this.btn_Coffe.TabIndex = 0;
            this.btn_Coffe.TabStop = true;
            this.btn_Coffe.Text = "    Kahveler";
            this.btn_Coffe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Coffe.UseVisualStyleBackColor = false;
            this.btn_Coffe.Click += new System.EventHandler(this.btn_Coffe_Click);
            // 
            // btn_Drinks
            // 
            this.btn_Drinks.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Drinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.btn_Drinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Drinks.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Drinks.ForeColor = System.Drawing.Color.Black;
            this.btn_Drinks.Image = ((System.Drawing.Image)(resources.GetObject("btn_Drinks.Image")));
            this.btn_Drinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Drinks.Location = new System.Drawing.Point(945, 57);
            this.btn_Drinks.Name = "btn_Drinks";
            this.btn_Drinks.Size = new System.Drawing.Size(136, 40);
            this.btn_Drinks.TabIndex = 1;
            this.btn_Drinks.TabStop = true;
            this.btn_Drinks.Text = "    İçecekler";
            this.btn_Drinks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Drinks.UseVisualStyleBackColor = false;
            this.btn_Drinks.Click += new System.EventHandler(this.btn_Drink_Click);
            // 
            // btn_Sweets
            // 
            this.btn_Sweets.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Sweets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.btn_Sweets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sweets.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Sweets.ForeColor = System.Drawing.Color.Black;
            this.btn_Sweets.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sweets.Image")));
            this.btn_Sweets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sweets.Location = new System.Drawing.Point(1087, 57);
            this.btn_Sweets.Name = "btn_Sweets";
            this.btn_Sweets.Size = new System.Drawing.Size(136, 40);
            this.btn_Sweets.TabIndex = 2;
            this.btn_Sweets.TabStop = true;
            this.btn_Sweets.Text = "    Tatlılar";
            this.btn_Sweets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Sweets.UseVisualStyleBackColor = false;
            this.btn_Sweets.Click += new System.EventHandler(this.btn_Sweet_Click);
            // 
            // btn_GeriDon
            // 
            this.btn_GeriDon.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.btn_GeriDon.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 6F, System.Drawing.FontStyle.Bold);
            this.btn_GeriDon.Appearance.Options.UseBackColor = true;
            this.btn_GeriDon.Appearance.Options.UseFont = true;
            this.btn_GeriDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_GeriDon.ImageOptions.Image")));
            this.btn_GeriDon.Location = new System.Drawing.Point(0, 1);
            this.btn_GeriDon.Name = "btn_GeriDon";
            this.btn_GeriDon.Size = new System.Drawing.Size(87, 29);
            this.btn_GeriDon.TabIndex = 7;
            this.btn_GeriDon.Text = "Geri Dön";
            this.btn_GeriDon.Click += new System.EventHandler(this.btn_GeriDon_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.btn_Refresh.Appearance.Font = new System.Drawing.Font("Century Gothic", 5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Refresh.Appearance.Options.UseBackColor = true;
            this.btn_Refresh.Appearance.Options.UseFont = true;
            this.btn_Refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.ImageOptions.Image")));
            this.btn_Refresh.Location = new System.Drawing.Point(354, 552);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(87, 48);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Yenile";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Century Gothic", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Delete.Appearance.Options.UseBackColor = true;
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(264, 455);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(177, 64);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Kayıt Sil";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.btn_Change.Appearance.Font = new System.Drawing.Font("Century Gothic", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Change.Appearance.Options.UseBackColor = true;
            this.btn_Change.Appearance.Options.UseFont = true;
            this.btn_Change.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Change.ImageOptions.Image")));
            this.btn_Change.Location = new System.Drawing.Point(264, 328);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(177, 63);
            this.btn_Change.TabIndex = 4;
            this.btn_Change.Text = "Kayıt Düzenle";
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.btn_Add.Appearance.Font = new System.Drawing.Font("Century Gothic", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Add.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.Appearance.Options.UseBackColor = true;
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.Appearance.Options.UseForeColor = true;
            this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.Image")));
            this.btn_Add.Location = new System.Drawing.Point(264, 202);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(177, 61);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Yeni Kayıt Ekle";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dataGridView_Manager_List
            // 
            this.dataGridView_Manager_List.AllowUserToAddRows = false;
            this.dataGridView_Manager_List.AllowUserToDeleteRows = false;
            this.dataGridView_Manager_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Manager_List.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Manager_List.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.dataGridView_Manager_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView_Manager_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Manager_List.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Manager_List.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(212)))), ((int)(((byte)(188)))));
            this.dataGridView_Manager_List.Location = new System.Drawing.Point(804, 103);
            this.dataGridView_Manager_List.Name = "dataGridView_Manager_List";
            this.dataGridView_Manager_List.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Manager_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Manager_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Manager_List.Size = new System.Drawing.Size(475, 568);
            this.dataGridView_Manager_List.TabIndex = 39;
            this.dataGridView_Manager_List.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Manager_List_CellEnter);
            // 
            // manager_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1364, 736);
            this.Controls.Add(this.dataGridView_Manager_List);
            this.Controls.Add(this.btn_GeriDon);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.txtBox_ID);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.btn_Sweets);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Drinks);
            this.Controls.Add(this.btn_Coffe);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ShowIcon = false;
            this.Name = "manager_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NONAME | Yönetici Ekranı | Listele";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.manager_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Manager_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBox_ID;
        private System.Windows.Forms.RadioButton btn_Coffe;
        private System.Windows.Forms.RadioButton btn_Drinks;
        private System.Windows.Forms.RadioButton btn_Sweets;
        private DevExpress.XtraEditors.SimpleButton btn_GeriDon;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Change;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private System.Windows.Forms.DataGridView dataGridView_Manager_List;
    }
}