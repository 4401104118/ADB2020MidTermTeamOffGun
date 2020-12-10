namespace ADBTeamOffGun_DB4O
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listcom = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_skill = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.num_salary = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_salary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usename";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Skill";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Homebase";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // listcom
            // 
            this.listcom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listcom.FormattingEnabled = true;
            this.listcom.Location = new System.Drawing.Point(120, 138);
            this.listcom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listcom.Name = "listcom";
            this.listcom.Size = new System.Drawing.Size(198, 28);
            this.listcom.TabIndex = 5;
            this.listcom.SelectedIndexChanged += new System.EventHandler(this.Listcom_SelectedIndexChanged);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(120, 16);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(216, 26);
            this.txt_id.TabIndex = 6;
            this.txt_id.TextChanged += new System.EventHandler(this.Txt_id_TextChanged);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(120, 74);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(216, 26);
            this.txt_name.TabIndex = 7;
            // 
            // txt_skill
            // 
            this.txt_skill.Location = new System.Drawing.Point(541, 16);
            this.txt_skill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_skill.Name = "txt_skill";
            this.txt_skill.Size = new System.Drawing.Size(216, 26);
            this.txt_skill.TabIndex = 8;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(120, 236);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(84, 29);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // num_salary
            // 
            this.num_salary.Location = new System.Drawing.Point(541, 72);
            this.num_salary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num_salary.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.num_salary.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.num_salary.Name = "num_salary";
            this.num_salary.Size = new System.Drawing.Size(216, 26);
            this.num_salary.TabIndex = 11;
            this.num_salary.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.num_salary);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_skill);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.listcom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_salary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox listcom;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_skill;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.NumericUpDown num_salary;
    }
}