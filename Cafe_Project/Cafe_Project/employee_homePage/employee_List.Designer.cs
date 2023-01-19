namespace Cafe_Project
{
    partial class employee_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee_List));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            this.btn_Drinks = new System.Windows.Forms.RadioButton();
            this.btn_Sweets = new System.Windows.Forms.RadioButton();
            this.btn_Coffe = new System.Windows.Forms.RadioButton();
            this.btn_Back = new DevExpress.XtraEditors.SimpleButton();
            this.dataGriedView_Employee_List = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriedView_Employee_List)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1366, 768);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.BackColor = System.Drawing.Color.LightGray;
            this.txtBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_ID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBox_ID.ForeColor = System.Drawing.Color.Black;
            this.txtBox_ID.Location = new System.Drawing.Point(566, 364);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.ReadOnly = true;
            this.txtBox_ID.Size = new System.Drawing.Size(21, 17);
            this.txtBox_ID.TabIndex = 39;
            this.txtBox_ID.TabStop = false;
            // 
            // btn_Drinks
            // 
            this.btn_Drinks.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Drinks.AutoSize = true;
            this.btn_Drinks.BackColor = System.Drawing.Color.LightGray;
            this.btn_Drinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Drinks.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Drinks.Image = ((System.Drawing.Image)(resources.GetObject("btn_Drinks.Image")));
            this.btn_Drinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Drinks.Location = new System.Drawing.Point(316, 155);
            this.btn_Drinks.Name = "btn_Drinks";
            this.btn_Drinks.Size = new System.Drawing.Size(75, 40);
            this.btn_Drinks.TabIndex = 1;
            this.btn_Drinks.TabStop = true;
            this.btn_Drinks.Text = "    İçecekler";
            this.btn_Drinks.UseVisualStyleBackColor = false;
            this.btn_Drinks.Click += new System.EventHandler(this.btn_Drink_Click);
            // 
            // btn_Sweets
            // 
            this.btn_Sweets.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Sweets.AutoSize = true;
            this.btn_Sweets.BackColor = System.Drawing.Color.LightGray;
            this.btn_Sweets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sweets.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Sweets.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sweets.Image")));
            this.btn_Sweets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sweets.Location = new System.Drawing.Point(409, 155);
            this.btn_Sweets.Name = "btn_Sweets";
            this.btn_Sweets.Size = new System.Drawing.Size(68, 40);
            this.btn_Sweets.TabIndex = 2;
            this.btn_Sweets.TabStop = true;
            this.btn_Sweets.Text = "     Tatlılar";
            this.btn_Sweets.UseVisualStyleBackColor = false;
            this.btn_Sweets.Click += new System.EventHandler(this.btn_Sweet_Click);
            // 
            // btn_Coffe
            // 
            this.btn_Coffe.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Coffe.AutoSize = true;
            this.btn_Coffe.BackColor = System.Drawing.Color.LightGray;
            this.btn_Coffe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Coffe.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Coffe.Image = ((System.Drawing.Image)(resources.GetObject("btn_Coffe.Image")));
            this.btn_Coffe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Coffe.Location = new System.Drawing.Point(219, 155);
            this.btn_Coffe.Name = "btn_Coffe";
            this.btn_Coffe.Size = new System.Drawing.Size(75, 40);
            this.btn_Coffe.TabIndex = 0;
            this.btn_Coffe.TabStop = true;
            this.btn_Coffe.Text = "    Kahveler";
            this.btn_Coffe.UseVisualStyleBackColor = false;
            this.btn_Coffe.Click += new System.EventHandler(this.btn_Coffe_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btn_Back.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 5F, System.Drawing.FontStyle.Bold);
            this.btn_Back.Appearance.Options.UseBackColor = true;
            this.btn_Back.Appearance.Options.UseFont = true;
            this.btn_Back.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.ImageOptions.Image")));
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(87, 29);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Geri Dön";
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dataGriedView_Employee_List
            // 
            this.dataGriedView_Employee_List.AllowUserToAddRows = false;
            this.dataGriedView_Employee_List.AllowUserToDeleteRows = false;
            this.dataGriedView_Employee_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGriedView_Employee_List.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGriedView_Employee_List.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGriedView_Employee_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGriedView_Employee_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGriedView_Employee_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriedView_Employee_List.Location = new System.Drawing.Point(219, 187);
            this.dataGriedView_Employee_List.Name = "dataGriedView_Employee_List";
            this.dataGriedView_Employee_List.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGriedView_Employee_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGriedView_Employee_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGriedView_Employee_List.Size = new System.Drawing.Size(849, 481);
            this.dataGriedView_Employee_List.TabIndex = 40;
            this.dataGriedView_Employee_List.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Employee_List_CellEnter);
            // 
            // employee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.dataGriedView_Employee_List);
            this.Controls.Add(this.txtBox_ID);
            this.Controls.Add(this.btn_Drinks);
            this.Controls.Add(this.btn_Sweets);
            this.Controls.Add(this.btn_Coffe);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employee_List";
            this.Text = "employee_List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.employee_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriedView_Employee_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBox_ID;
        private System.Windows.Forms.RadioButton btn_Drinks;
        private System.Windows.Forms.RadioButton btn_Sweets;
        private System.Windows.Forms.RadioButton btn_Coffe;
        private DevExpress.XtraEditors.SimpleButton btn_Back;
        private System.Windows.Forms.DataGridView dataGriedView_Employee_List;
    }
}