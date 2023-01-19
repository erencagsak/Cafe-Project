namespace Cafe_Project
{
    partial class manager_List_Change
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_List_Change));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Refresh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Coffe = new System.Windows.Forms.RadioButton();
            this.btn_Sweet = new System.Windows.Forms.RadioButton();
            this.btn_Drink = new System.Windows.Forms.RadioButton();
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.dataGridView_Manager_List_Change = new System.Windows.Forms.DataGridView();
            this.btn_changeList = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txtBox_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Manager_List_Change)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.btn_Refresh.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.Appearance.Options.UseBackColor = true;
            this.btn_Refresh.Appearance.Options.UseFont = true;
            this.btn_Refresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.ImageOptions.Image")));
            this.btn_Refresh.Location = new System.Drawing.Point(12, 318);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(76, 27);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Yenile";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Coffe
            // 
            this.btn_Coffe.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Coffe.AutoSize = true;
            this.btn_Coffe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.btn_Coffe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Coffe.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, System.Drawing.FontStyle.Bold);
            this.btn_Coffe.Image = ((System.Drawing.Image)(resources.GetObject("btn_Coffe.Image")));
            this.btn_Coffe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Coffe.Location = new System.Drawing.Point(337, 47);
            this.btn_Coffe.Name = "btn_Coffe";
            this.btn_Coffe.Size = new System.Drawing.Size(94, 40);
            this.btn_Coffe.TabIndex = 0;
            this.btn_Coffe.TabStop = true;
            this.btn_Coffe.Text = "          Kahveler";
            this.btn_Coffe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Coffe.UseVisualStyleBackColor = false;
            this.btn_Coffe.CheckedChanged += new System.EventHandler(this.btn_Coffe_CheckedChanged);
            // 
            // btn_Sweet
            // 
            this.btn_Sweet.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Sweet.AutoSize = true;
            this.btn_Sweet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.btn_Sweet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sweet.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, System.Drawing.FontStyle.Bold);
            this.btn_Sweet.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sweet.Image")));
            this.btn_Sweet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sweet.Location = new System.Drawing.Point(539, 47);
            this.btn_Sweet.Name = "btn_Sweet";
            this.btn_Sweet.Size = new System.Drawing.Size(81, 40);
            this.btn_Sweet.TabIndex = 2;
            this.btn_Sweet.TabStop = true;
            this.btn_Sweet.Text = "         Tatlılar";
            this.btn_Sweet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sweet.UseVisualStyleBackColor = false;
            this.btn_Sweet.CheckedChanged += new System.EventHandler(this.btn_Sweet_CheckedChanged);
            // 
            // btn_Drink
            // 
            this.btn_Drink.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Drink.AutoSize = true;
            this.btn_Drink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.btn_Drink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Drink.Font = new System.Drawing.Font("Segoe UI Semibold", 8.75F, System.Drawing.FontStyle.Bold);
            this.btn_Drink.Image = ((System.Drawing.Image)(resources.GetObject("btn_Drink.Image")));
            this.btn_Drink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Drink.Location = new System.Drawing.Point(437, 47);
            this.btn_Drink.Name = "btn_Drink";
            this.btn_Drink.Size = new System.Drawing.Size(96, 40);
            this.btn_Drink.TabIndex = 1;
            this.btn_Drink.TabStop = true;
            this.btn_Drink.Text = "          İçecekler";
            this.btn_Drink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Drink.UseVisualStyleBackColor = false;
            this.btn_Drink.CheckedChanged += new System.EventHandler(this.btn_Drink_CheckedChanged);
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold);
            this.txtBox_ID.Location = new System.Drawing.Point(94, 307);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.ReadOnly = true;
            this.txtBox_ID.Size = new System.Drawing.Size(48, 38);
            this.txtBox_ID.TabIndex = 33;
            this.txtBox_ID.TabStop = false;
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtBox_Name.Location = new System.Drawing.Point(72, 112);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(247, 29);
            this.txtBox_Name.TabIndex = 3;
            this.txtBox_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Name_KeyPress);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.lbl_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Price.Location = new System.Drawing.Point(12, 171);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(54, 23);
            this.lbl_Price.TabIndex = 38;
            this.lbl_Price.Text = "Fiyat :";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.lbl_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Name.Location = new System.Drawing.Point(12, 115);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(50, 23);
            this.lbl_Name.TabIndex = 36;
            this.lbl_Name.Text = "İsim :";
            // 
            // dataGridView_Manager_List_Change
            // 
            this.dataGridView_Manager_List_Change.AllowUserToAddRows = false;
            this.dataGridView_Manager_List_Change.AllowUserToDeleteRows = false;
            this.dataGridView_Manager_List_Change.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Manager_List_Change.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Manager_List_Change.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.dataGridView_Manager_List_Change.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView_Manager_List_Change.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(212)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Manager_List_Change.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Manager_List_Change.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.dataGridView_Manager_List_Change.Location = new System.Drawing.Point(337, 89);
            this.dataGridView_Manager_List_Change.Name = "dataGridView_Manager_List_Change";
            this.dataGridView_Manager_List_Change.ReadOnly = true;
            this.dataGridView_Manager_List_Change.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Manager_List_Change.Size = new System.Drawing.Size(530, 256);
            this.dataGridView_Manager_List_Change.TabIndex = 35;
            this.dataGridView_Manager_List_Change.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Manager_List_Change_CellEnter);
            // 
            // btn_changeList
            // 
            this.btn_changeList.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.btn_changeList.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btn_changeList.Appearance.Options.UseBackColor = true;
            this.btn_changeList.Appearance.Options.UseFont = true;
            this.btn_changeList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_changeList.ImageOptions.Image")));
            this.btn_changeList.Location = new System.Drawing.Point(211, 307);
            this.btn_changeList.Name = "btn_changeList";
            this.btn_changeList.Size = new System.Drawing.Size(108, 38);
            this.btn_changeList.TabIndex = 5;
            this.btn_changeList.Text = "DÜZENLE";
            this.btn_changeList.Click += new System.EventHandler(this.btn_changeList_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(212)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 34);
            this.panel1.TabIndex = 40;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.manager_List_Change_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.manager_List_Change_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "KAYITLARI DÜZENLE";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(861, -1);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(27, 34);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtBox_Price.Location = new System.Drawing.Point(72, 168);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.Size = new System.Drawing.Size(137, 29);
            this.txtBox_Price.TabIndex = 4;
            this.txtBox_Price.Click += new System.EventHandler(this.txtBox_Price_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(175, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "TL";
            // 
            // manager_List_Change
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(176)))), ((int)(((byte)(160)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 366);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_Price);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_changeList);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Coffe);
            this.Controls.Add(this.btn_Sweet);
            this.Controls.Add(this.btn_Drink);
            this.Controls.Add(this.txtBox_ID);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.dataGridView_Manager_List_Change);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "manager_List_Change";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.manager_List_Change_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.manager_List_Change_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Manager_List_Change)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_Refresh;
        private System.Windows.Forms.RadioButton btn_Coffe;
        private System.Windows.Forms.RadioButton btn_Sweet;
        private System.Windows.Forms.RadioButton btn_Drink;
        private System.Windows.Forms.TextBox txtBox_ID;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.DataGridView dataGridView_Manager_List_Change;
        private DevExpress.XtraEditors.SimpleButton btn_changeList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txtBox_Price;
        private System.Windows.Forms.Label label1;
    }
}