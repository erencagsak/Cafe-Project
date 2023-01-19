namespace Cafe_Project
{
    partial class manager_List_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_List_Add));
            this.rdbtn_Coffe = new System.Windows.Forms.RadioButton();
            this.groupBox_RadioButtons = new System.Windows.Forms.GroupBox();
            this.rdbtn_Sweet = new System.Windows.Forms.RadioButton();
            this.rdbtn_Drink = new System.Windows.Forms.RadioButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.panel_RadioButtons = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Price = new System.Windows.Forms.TextBox();
            this.groupBox_RadioButtons.SuspendLayout();
            this.panel_Header.SuspendLayout();
            this.panel_RadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbtn_Coffe
            // 
            this.rdbtn_Coffe.AutoSize = true;
            this.rdbtn_Coffe.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.rdbtn_Coffe.Location = new System.Drawing.Point(50, 31);
            this.rdbtn_Coffe.Name = "rdbtn_Coffe";
            this.rdbtn_Coffe.Size = new System.Drawing.Size(81, 23);
            this.rdbtn_Coffe.TabIndex = 0;
            this.rdbtn_Coffe.TabStop = true;
            this.rdbtn_Coffe.Text = "Kahveler";
            this.rdbtn_Coffe.UseVisualStyleBackColor = true;
            // 
            // groupBox_RadioButtons
            // 
            this.groupBox_RadioButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.groupBox_RadioButtons.Controls.Add(this.rdbtn_Sweet);
            this.groupBox_RadioButtons.Controls.Add(this.rdbtn_Drink);
            this.groupBox_RadioButtons.Controls.Add(this.rdbtn_Coffe);
            this.groupBox_RadioButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_RadioButtons.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox_RadioButtons.Location = new System.Drawing.Point(-1, -1);
            this.groupBox_RadioButtons.Name = "groupBox_RadioButtons";
            this.groupBox_RadioButtons.Size = new System.Drawing.Size(372, 114);
            this.groupBox_RadioButtons.TabIndex = 2;
            this.groupBox_RadioButtons.TabStop = false;
            this.groupBox_RadioButtons.Text = "          Yeni Kayıt Hangi Tabloya Eklensin?";
            // 
            // rdbtn_Sweet
            // 
            this.rdbtn_Sweet.AutoSize = true;
            this.rdbtn_Sweet.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.rdbtn_Sweet.Location = new System.Drawing.Point(140, 70);
            this.rdbtn_Sweet.Name = "rdbtn_Sweet";
            this.rdbtn_Sweet.Size = new System.Drawing.Size(70, 23);
            this.rdbtn_Sweet.TabIndex = 2;
            this.rdbtn_Sweet.TabStop = true;
            this.rdbtn_Sweet.Text = "Tatlılar";
            this.rdbtn_Sweet.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Drink
            // 
            this.rdbtn_Drink.AutoSize = true;
            this.rdbtn_Drink.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.rdbtn_Drink.Location = new System.Drawing.Point(222, 31);
            this.rdbtn_Drink.Name = "rdbtn_Drink";
            this.rdbtn_Drink.Size = new System.Drawing.Size(82, 23);
            this.rdbtn_Drink.TabIndex = 1;
            this.rdbtn_Drink.TabStop = true;
            this.rdbtn_Drink.Text = "İçecekler";
            this.rdbtn_Drink.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.btn_Add.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Add.Appearance.Options.UseBackColor = true;
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.Location = new System.Drawing.Point(129, 289);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(103, 39);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "EKLE";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.lbl_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Name.Location = new System.Drawing.Point(48, 199);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(50, 23);
            this.lbl_Name.TabIndex = 4;
            this.lbl_Name.Text = "İsim :";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.lbl_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Price.Location = new System.Drawing.Point(48, 249);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(54, 23);
            this.lbl_Price.TabIndex = 5;
            this.lbl_Price.Text = "Fiyat :";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtBox_Name.Location = new System.Drawing.Point(129, 193);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(291, 29);
            this.txtBox_Name.TabIndex = 3;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(435, -1);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(36, 34);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Header.Controls.Add(this.lbl_Header);
            this.panel_Header.Controls.Add(this.btn_Exit);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(472, 34);
            this.panel_Header.TabIndex = 12;
            this.panel_Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.manager_List_Add_MouseDown);
            this.panel_Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.manager_List_Add_MouseMove);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Header.Location = new System.Drawing.Point(3, 8);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(119, 18);
            this.lbl_Header.TabIndex = 13;
            this.lbl_Header.Text = "YENİ KAYIT EKLE";
            // 
            // panel_RadioButtons
            // 
            this.panel_RadioButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_RadioButtons.Controls.Add(this.groupBox_RadioButtons);
            this.panel_RadioButtons.Location = new System.Drawing.Point(48, 60);
            this.panel_RadioButtons.Name = "panel_RadioButtons";
            this.panel_RadioButtons.Size = new System.Drawing.Size(372, 114);
            this.panel_RadioButtons.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(266, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "TL";
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtBox_Price.Location = new System.Drawing.Point(129, 246);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.Size = new System.Drawing.Size(167, 29);
            this.txtBox_Price.TabIndex = 4;
            this.txtBox_Price.Click += new System.EventHandler(this.txtBox_Price_Click);
            // 
            // manager_List_Add
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(472, 340);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_Price);
            this.Controls.Add(this.panel_RadioButtons);
            this.Controls.Add(this.panel_Header);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "manager_List_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.manager_List_Add_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.manager_List_Add_MouseMove);
            this.groupBox_RadioButtons.ResumeLayout(false);
            this.groupBox_RadioButtons.PerformLayout();
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.panel_RadioButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtn_Coffe;
        private System.Windows.Forms.GroupBox groupBox_RadioButtons;
        private System.Windows.Forms.RadioButton rdbtn_Sweet;
        private System.Windows.Forms.RadioButton rdbtn_Drink;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Panel panel_RadioButtons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Price;
    }
}