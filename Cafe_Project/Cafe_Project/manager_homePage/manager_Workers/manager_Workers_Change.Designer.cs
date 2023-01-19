namespace Cafe_Project
{
    partial class manager_Workers_Change
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_Workers_Change));
            this.dataGridView_Manager_Workers_Change = new System.Windows.Forms.DataGridView();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_SurName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_PIN = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_SurName = new System.Windows.Forms.TextBox();
            this.txtBox_UserName = new System.Windows.Forms.TextBox();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.txtBox_PIN = new System.Windows.Forms.TextBox();
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            this.btn_Waiter = new System.Windows.Forms.RadioButton();
            this.btn_Chef = new System.Windows.Forms.RadioButton();
            this.btn_AssistantChef = new System.Windows.Forms.RadioButton();
            this.btn_Manager = new System.Windows.Forms.RadioButton();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_changeAcc = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Manager_Workers_Change)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Manager_Workers_Change
            // 
            this.dataGridView_Manager_Workers_Change.AllowUserToAddRows = false;
            this.dataGridView_Manager_Workers_Change.AllowUserToDeleteRows = false;
            this.dataGridView_Manager_Workers_Change.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Manager_Workers_Change.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Manager_Workers_Change.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataGridView_Manager_Workers_Change.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView_Manager_Workers_Change.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Manager_Workers_Change.Location = new System.Drawing.Point(445, 61);
            this.dataGridView_Manager_Workers_Change.Name = "dataGridView_Manager_Workers_Change";
            this.dataGridView_Manager_Workers_Change.ReadOnly = true;
            this.dataGridView_Manager_Workers_Change.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Manager_Workers_Change.Size = new System.Drawing.Size(736, 355);
            this.dataGridView_Manager_Workers_Change.TabIndex = 11;
            this.dataGridView_Manager_Workers_Change.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Manager_Workers_Change_CellEnter);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Moccasin;
            this.lbl_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Name.Location = new System.Drawing.Point(12, 19);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(50, 23);
            this.lbl_Name.TabIndex = 17;
            this.lbl_Name.Text = "İsim :";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.BackColor = System.Drawing.Color.Moccasin;
            this.lbl_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_UserName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_UserName.Location = new System.Drawing.Point(12, 165);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(109, 23);
            this.lbl_UserName.TabIndex = 19;
            this.lbl_UserName.Text = "Kullanıcı Adı :";
            // 
            // lbl_SurName
            // 
            this.lbl_SurName.AutoSize = true;
            this.lbl_SurName.BackColor = System.Drawing.Color.Moccasin;
            this.lbl_SurName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_SurName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_SurName.Location = new System.Drawing.Point(12, 92);
            this.lbl_SurName.Name = "lbl_SurName";
            this.lbl_SurName.Size = new System.Drawing.Size(76, 23);
            this.lbl_SurName.TabIndex = 20;
            this.lbl_SurName.Text = "Soyisim :";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Moccasin;
            this.lbl_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Password.Location = new System.Drawing.Point(12, 238);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(54, 23);
            this.lbl_Password.TabIndex = 21;
            this.lbl_Password.Text = "Şifre :";
            // 
            // lbl_PIN
            // 
            this.lbl_PIN.AutoSize = true;
            this.lbl_PIN.BackColor = System.Drawing.Color.Moccasin;
            this.lbl_PIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_PIN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_PIN.Location = new System.Drawing.Point(12, 311);
            this.lbl_PIN.Name = "lbl_PIN";
            this.lbl_PIN.Size = new System.Drawing.Size(50, 23);
            this.lbl_PIN.TabIndex = 22;
            this.lbl_PIN.Text = "PIN : ";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.txtBox_Name.Location = new System.Drawing.Point(161, 19);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(247, 27);
            this.txtBox_Name.TabIndex = 0;
            // 
            // txtBox_SurName
            // 
            this.txtBox_SurName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.txtBox_SurName.Location = new System.Drawing.Point(161, 90);
            this.txtBox_SurName.Name = "txtBox_SurName";
            this.txtBox_SurName.Size = new System.Drawing.Size(247, 27);
            this.txtBox_SurName.TabIndex = 1;
            // 
            // txtBox_UserName
            // 
            this.txtBox_UserName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.txtBox_UserName.Location = new System.Drawing.Point(161, 163);
            this.txtBox_UserName.Name = "txtBox_UserName";
            this.txtBox_UserName.Size = new System.Drawing.Size(247, 27);
            this.txtBox_UserName.TabIndex = 2;
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.txtBox_Password.Location = new System.Drawing.Point(161, 236);
            this.txtBox_Password.MaxLength = 11;
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(247, 27);
            this.txtBox_Password.TabIndex = 3;
            // 
            // txtBox_PIN
            // 
            this.txtBox_PIN.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.txtBox_PIN.Location = new System.Drawing.Point(161, 309);
            this.txtBox_PIN.MaxLength = 11;
            this.txtBox_PIN.Name = "txtBox_PIN";
            this.txtBox_PIN.Size = new System.Drawing.Size(247, 27);
            this.txtBox_PIN.TabIndex = 4;
            this.txtBox_PIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_PIN_KeyPress);
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold);
            this.txtBox_ID.Location = new System.Drawing.Point(115, 378);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.ReadOnly = true;
            this.txtBox_ID.Size = new System.Drawing.Size(48, 38);
            this.txtBox_ID.TabIndex = 11;
            this.txtBox_ID.TabStop = false;
            // 
            // btn_Waiter
            // 
            this.btn_Waiter.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Waiter.AutoSize = true;
            this.btn_Waiter.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Waiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Waiter.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.btn_Waiter.Image = ((System.Drawing.Image)(resources.GetObject("btn_Waiter.Image")));
            this.btn_Waiter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Waiter.Location = new System.Drawing.Point(826, 19);
            this.btn_Waiter.Name = "btn_Waiter";
            this.btn_Waiter.Size = new System.Drawing.Size(119, 40);
            this.btn_Waiter.TabIndex = 8;
            this.btn_Waiter.TabStop = true;
            this.btn_Waiter.Text = "       Garsonlar";
            this.btn_Waiter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Waiter.UseVisualStyleBackColor = false;
            this.btn_Waiter.CheckedChanged += new System.EventHandler(this.btn_Waiter_CheckedChanged);
            // 
            // btn_Chef
            // 
            this.btn_Chef.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Chef.AutoSize = true;
            this.btn_Chef.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Chef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Chef.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.btn_Chef.Image = ((System.Drawing.Image)(resources.GetObject("btn_Chef.Image")));
            this.btn_Chef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Chef.Location = new System.Drawing.Point(574, 19);
            this.btn_Chef.Name = "btn_Chef";
            this.btn_Chef.Size = new System.Drawing.Size(93, 40);
            this.btn_Chef.TabIndex = 6;
            this.btn_Chef.TabStop = true;
            this.btn_Chef.Text = "       Şefler";
            this.btn_Chef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Chef.UseVisualStyleBackColor = false;
            this.btn_Chef.CheckedChanged += new System.EventHandler(this.btn_Chef_CheckedChanged);
            // 
            // btn_AssistantChef
            // 
            this.btn_AssistantChef.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_AssistantChef.AutoSize = true;
            this.btn_AssistantChef.BackColor = System.Drawing.Color.Moccasin;
            this.btn_AssistantChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AssistantChef.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.btn_AssistantChef.Image = ((System.Drawing.Image)(resources.GetObject("btn_AssistantChef.Image")));
            this.btn_AssistantChef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AssistantChef.Location = new System.Drawing.Point(673, 19);
            this.btn_AssistantChef.Name = "btn_AssistantChef";
            this.btn_AssistantChef.Size = new System.Drawing.Size(147, 40);
            this.btn_AssistantChef.TabIndex = 7;
            this.btn_AssistantChef.TabStop = true;
            this.btn_AssistantChef.Text = "       Şef Yardımcıları";
            this.btn_AssistantChef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AssistantChef.UseVisualStyleBackColor = false;
            this.btn_AssistantChef.CheckedChanged += new System.EventHandler(this.btn_AssistantChef_CheckedChanged);
            // 
            // btn_Manager
            // 
            this.btn_Manager.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Manager.AutoSize = true;
            this.btn_Manager.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Manager.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.btn_Manager.Image = ((System.Drawing.Image)(resources.GetObject("btn_Manager.Image")));
            this.btn_Manager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Manager.Location = new System.Drawing.Point(445, 19);
            this.btn_Manager.Name = "btn_Manager";
            this.btn_Manager.Size = new System.Drawing.Size(123, 40);
            this.btn_Manager.TabIndex = 5;
            this.btn_Manager.TabStop = true;
            this.btn_Manager.Text = "      Yöneticiler";
            this.btn_Manager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Manager.UseVisualStyleBackColor = false;
            this.btn_Manager.CheckedChanged += new System.EventHandler(this.btn_Manager_CheckedChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Appearance.BackColor = System.Drawing.Color.Moccasin;
            this.btn_Refresh.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.Appearance.Options.UseBackColor = true;
            this.btn_Refresh.Appearance.Options.UseFont = true;
            this.btn_Refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.ImageOptions.Image")));
            this.btn_Refresh.Location = new System.Drawing.Point(12, 389);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(76, 27);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "YENİLE";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_changeAcc
            // 
            this.btn_changeAcc.Appearance.BackColor = System.Drawing.Color.Moccasin;
            this.btn_changeAcc.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btn_changeAcc.Appearance.Options.UseBackColor = true;
            this.btn_changeAcc.Appearance.Options.UseFont = true;
            this.btn_changeAcc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_changeAcc.ImageOptions.Image")));
            this.btn_changeAcc.Location = new System.Drawing.Point(300, 378);
            this.btn_changeAcc.Name = "btn_changeAcc";
            this.btn_changeAcc.Size = new System.Drawing.Size(108, 38);
            this.btn_changeAcc.TabIndex = 10;
            this.btn_changeAcc.Text = "DÜZENLE";
            this.btn_changeAcc.Click += new System.EventHandler(this.btn_changeAcc_Click);
            // 
            // manager_Workers_Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Center;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1200, 436);
            this.Controls.Add(this.btn_changeAcc);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Manager);
            this.Controls.Add(this.btn_AssistantChef);
            this.Controls.Add(this.btn_Chef);
            this.Controls.Add(this.btn_Waiter);
            this.Controls.Add(this.txtBox_ID);
            this.Controls.Add(this.txtBox_PIN);
            this.Controls.Add(this.txtBox_Password);
            this.Controls.Add(this.txtBox_UserName);
            this.Controls.Add(this.txtBox_SurName);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.lbl_PIN);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_SurName);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.dataGridView_Manager_Workers_Change);
            this.DoubleBuffered = true;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("manager_Workers_Change.IconOptions.Image")));
            this.IconOptions.ShowIcon = false;
            this.Name = "manager_Workers_Change";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.manager_Workers_Change_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Manager_Workers_Change)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Manager_Workers_Change;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_SurName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_PIN;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.TextBox txtBox_SurName;
        private System.Windows.Forms.TextBox txtBox_UserName;
        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.TextBox txtBox_PIN;
        private System.Windows.Forms.TextBox txtBox_ID;
        private System.Windows.Forms.RadioButton btn_Waiter;
        private System.Windows.Forms.RadioButton btn_Chef;
        private System.Windows.Forms.RadioButton btn_AssistantChef;
        private System.Windows.Forms.RadioButton btn_Manager;
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
        private DevExpress.XtraEditors.SimpleButton btn_changeAcc;
    }
}