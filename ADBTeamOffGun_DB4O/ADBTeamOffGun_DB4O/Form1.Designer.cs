namespace ADBTeamOffGun_DB4O
{
    partial class Form1
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
            this.Name_com = new System.Windows.Forms.Label();
            this.Street = new System.Windows.Forms.Label();
            this.Id_home = new System.Windows.Forms.Label();
            this.Manager = new System.Windows.Forms.Label();
            this.District = new System.Windows.Forms.Label();
            this.Id_Thue = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_home = new System.Windows.Forms.TextBox();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.txt_idthue = new System.Windows.Forms.TextBox();
            this.txt_district = new System.Windows.Forms.TextBox();
            this.displaycom = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.listNV = new System.Windows.Forms.ComboBox();
            this.btn_addem = new System.Windows.Forms.Button();
            this.Id_com = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displaycom)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_com
            // 
            this.Name_com.AutoSize = true;
            this.Name_com.Location = new System.Drawing.Point(15, 88);
            this.Name_com.Name = "Name_com";
            this.Name_com.Size = new System.Drawing.Size(73, 20);
            this.Name_com.TabIndex = 1;
            this.Name_com.Text = "company";
            // 
            // Street
            // 
            this.Street.AutoSize = true;
            this.Street.Location = new System.Drawing.Point(15, 191);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(50, 20);
            this.Street.TabIndex = 2;
            this.Street.Text = "street";
            this.Street.Click += new System.EventHandler(this.Street_Click);
            // 
            // Id_home
            // 
            this.Id_home.AutoSize = true;
            this.Id_home.Location = new System.Drawing.Point(15, 144);
            this.Id_home.Name = "Id_home";
            this.Id_home.Size = new System.Drawing.Size(61, 20);
            this.Id_home.TabIndex = 3;
            this.Id_home.Text = "idhome";
            this.Id_home.Click += new System.EventHandler(this.Id_home_Click);
            // 
            // Manager
            // 
            this.Manager.AutoSize = true;
            this.Manager.Location = new System.Drawing.Point(459, 140);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(35, 20);
            this.Manager.TabIndex = 4;
            this.Manager.Text = "ceo";
            // 
            // District
            // 
            this.District.AutoSize = true;
            this.District.Location = new System.Drawing.Point(423, 88);
            this.District.Name = "District";
            this.District.Size = new System.Drawing.Size(93, 20);
            this.District.TabIndex = 5;
            this.District.Text = "district/town";
            // 
            // Id_Thue
            // 
            this.Id_Thue.AutoSize = true;
            this.Id_Thue.Location = new System.Drawing.Point(423, 38);
            this.Id_Thue.Name = "Id_Thue";
            this.Id_Thue.Size = new System.Drawing.Size(49, 20);
            this.Id_Thue.TabIndex = 6;
            this.Id_Thue.Text = "idrent";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(148, 38);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(240, 26);
            this.txt_id.TabIndex = 7;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(148, 88);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(240, 26);
            this.txt_name.TabIndex = 8;
            // 
            // txt_home
            // 
            this.txt_home.Location = new System.Drawing.Point(148, 144);
            this.txt_home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_home.Name = "txt_home";
            this.txt_home.Size = new System.Drawing.Size(240, 26);
            this.txt_home.TabIndex = 9;
            // 
            // txt_street
            // 
            this.txt_street.Location = new System.Drawing.Point(148, 191);
            this.txt_street.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(240, 26);
            this.txt_street.TabIndex = 10;
            // 
            // txt_idthue
            // 
            this.txt_idthue.Location = new System.Drawing.Point(538, 38);
            this.txt_idthue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_idthue.Name = "txt_idthue";
            this.txt_idthue.Size = new System.Drawing.Size(240, 26);
            this.txt_idthue.TabIndex = 11;
            // 
            // txt_district
            // 
            this.txt_district.Location = new System.Drawing.Point(538, 88);
            this.txt_district.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_district.Name = "txt_district";
            this.txt_district.Size = new System.Drawing.Size(240, 26);
            this.txt_district.TabIndex = 12;
            // 
            // displaycom
            // 
            this.displaycom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displaycom.Location = new System.Drawing.Point(14, 380);
            this.displaycom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.displaycom.Name = "displaycom";
            this.displaycom.RowHeadersWidth = 51;
            this.displaycom.RowTemplate.Height = 24;
            this.displaycom.Size = new System.Drawing.Size(872, 261);
            this.displaycom.TabIndex = 14;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(148, 276);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(84, 29);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(340, 276);
            this.btn_show.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(84, 29);
            this.btn_show.TabIndex = 16;
            this.btn_show.Text = "show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.Btn_show_Click);
            // 
            // listNV
            // 
            this.listNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listNV.FormattingEnabled = true;
            this.listNV.Location = new System.Drawing.Point(538, 132);
            this.listNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listNV.Name = "listNV";
            this.listNV.Size = new System.Drawing.Size(240, 28);
            this.listNV.TabIndex = 17;
            this.listNV.SelectedIndexChanged += new System.EventHandler(this.ListNV_SelectedIndexChanged);
            // 
            // btn_addem
            // 
            this.btn_addem.Location = new System.Drawing.Point(538, 276);
            this.btn_addem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addem.Name = "btn_addem";
            this.btn_addem.Size = new System.Drawing.Size(155, 39);
            this.btn_addem.TabIndex = 18;
            this.btn_addem.Text = "addmanager";
            this.btn_addem.UseVisualStyleBackColor = true;
            this.btn_addem.Click += new System.EventHandler(this.Btn_addem_Click);
            // 
            // Id_com
            // 
            this.Id_com.AutoSize = true;
            this.Id_com.Location = new System.Drawing.Point(15, 38);
            this.Id_com.Name = "Id_com";
            this.Id_com.Size = new System.Drawing.Size(85, 20);
            this.Id_com.TabIndex = 0;
            this.Id_com.Text = "idcompany";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 656);
            this.Controls.Add(this.btn_addem);
            this.Controls.Add(this.listNV);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.displaycom);
            this.Controls.Add(this.txt_district);
            this.Controls.Add(this.txt_idthue);
            this.Controls.Add(this.txt_street);
            this.Controls.Add(this.txt_home);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.Id_Thue);
            this.Controls.Add(this.District);
            this.Controls.Add(this.Manager);
            this.Controls.Add(this.Id_home);
            this.Controls.Add(this.Street);
            this.Controls.Add(this.Name_com);
            this.Controls.Add(this.Id_com);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displaycom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Name_com;
        private System.Windows.Forms.Label Street;
        private System.Windows.Forms.Label Id_home;
        private System.Windows.Forms.Label Manager;
        private System.Windows.Forms.Label District;
        private System.Windows.Forms.Label Id_Thue;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_home;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.TextBox txt_idthue;
        private System.Windows.Forms.TextBox txt_district;
        private System.Windows.Forms.DataGridView displaycom;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.ComboBox listNV;
        private System.Windows.Forms.Button btn_addem;
        private System.Windows.Forms.Label Id_com;
    }
}

