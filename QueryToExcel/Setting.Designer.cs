
namespace QueryToExcel
{
    partial class Setting
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Server = new System.Windows.Forms.TextBox();
            this.txt_Database = new System.Windows.Forms.TextBox();
            this.txt_Uid = new System.Windows.Forms.TextBox();
            this.txt_PW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.gb_SQL = new System.Windows.Forms.GroupBox();
            this.rb_MSSQL = new System.Windows.Forms.RadioButton();
            this.rb_MYSQL = new System.Windows.Forms.RadioButton();
            this.gb_SaveMethod = new System.Windows.Forms.GroupBox();
            this.rb_Individual = new System.Windows.Forms.RadioButton();
            this.rb_Intergration = new System.Windows.Forms.RadioButton();
            this.gb_SQL.SuspendLayout();
            this.gb_SaveMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(111, 276);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(93, 25);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "저장";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Uid";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // txt_Server
            // 
            this.txt_Server.Location = new System.Drawing.Point(120, 122);
            this.txt_Server.Name = "txt_Server";
            this.txt_Server.Size = new System.Drawing.Size(163, 21);
            this.txt_Server.TabIndex = 2;
            // 
            // txt_Database
            // 
            this.txt_Database.Location = new System.Drawing.Point(120, 152);
            this.txt_Database.Name = "txt_Database";
            this.txt_Database.Size = new System.Drawing.Size(163, 21);
            this.txt_Database.TabIndex = 3;
            // 
            // txt_Uid
            // 
            this.txt_Uid.Location = new System.Drawing.Point(120, 182);
            this.txt_Uid.Name = "txt_Uid";
            this.txt_Uid.Size = new System.Drawing.Size(163, 21);
            this.txt_Uid.TabIndex = 4;
            // 
            // txt_PW
            // 
            this.txt_PW.Location = new System.Drawing.Point(120, 212);
            this.txt_PW.Name = "txt_PW";
            this.txt_PW.Size = new System.Drawing.Size(163, 21);
            this.txt_PW.TabIndex = 5;
            this.txt_PW.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Port";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(120, 242);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(163, 21);
            this.txt_Port.TabIndex = 6;
            // 
            // gb_SQL
            // 
            this.gb_SQL.Controls.Add(this.rb_MSSQL);
            this.gb_SQL.Controls.Add(this.rb_MYSQL);
            this.gb_SQL.Location = new System.Drawing.Point(30, 10);
            this.gb_SQL.Name = "gb_SQL";
            this.gb_SQL.Size = new System.Drawing.Size(253, 47);
            this.gb_SQL.TabIndex = 1;
            this.gb_SQL.TabStop = false;
            this.gb_SQL.Text = "SQL";
            // 
            // rb_MSSQL
            // 
            this.rb_MSSQL.AutoSize = true;
            this.rb_MSSQL.Location = new System.Drawing.Point(146, 20);
            this.rb_MSSQL.Name = "rb_MSSQL";
            this.rb_MSSQL.Size = new System.Drawing.Size(66, 16);
            this.rb_MSSQL.TabIndex = 2;
            this.rb_MSSQL.TabStop = true;
            this.rb_MSSQL.Text = "MSSQL";
            this.rb_MSSQL.UseVisualStyleBackColor = true;
            this.rb_MSSQL.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb_MYSQL
            // 
            this.rb_MYSQL.AutoSize = true;
            this.rb_MYSQL.Location = new System.Drawing.Point(25, 20);
            this.rb_MYSQL.Name = "rb_MYSQL";
            this.rb_MYSQL.Size = new System.Drawing.Size(66, 16);
            this.rb_MYSQL.TabIndex = 1;
            this.rb_MYSQL.TabStop = true;
            this.rb_MYSQL.Text = "MYSQL";
            this.rb_MYSQL.UseVisualStyleBackColor = true;
            this.rb_MYSQL.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // gb_SaveMethod
            // 
            this.gb_SaveMethod.Controls.Add(this.rb_Individual);
            this.gb_SaveMethod.Controls.Add(this.rb_Intergration);
            this.gb_SaveMethod.Location = new System.Drawing.Point(30, 62);
            this.gb_SaveMethod.Name = "gb_SaveMethod";
            this.gb_SaveMethod.Size = new System.Drawing.Size(253, 47);
            this.gb_SaveMethod.TabIndex = 3;
            this.gb_SaveMethod.TabStop = false;
            this.gb_SaveMethod.Text = "SQL";
            // 
            // rb_Individual
            // 
            this.rb_Individual.AutoSize = true;
            this.rb_Individual.Location = new System.Drawing.Point(146, 20);
            this.rb_Individual.Name = "rb_Individual";
            this.rb_Individual.Size = new System.Drawing.Size(75, 16);
            this.rb_Individual.TabIndex = 2;
            this.rb_Individual.TabStop = true;
            this.rb_Individual.Text = "개별 시트";
            this.rb_Individual.UseVisualStyleBackColor = true;
            // 
            // rb_Intergration
            // 
            this.rb_Intergration.AutoSize = true;
            this.rb_Intergration.Location = new System.Drawing.Point(25, 20);
            this.rb_Intergration.Name = "rb_Intergration";
            this.rb_Intergration.Size = new System.Drawing.Size(75, 16);
            this.rb_Intergration.TabIndex = 1;
            this.rb_Intergration.TabStop = true;
            this.rb_Intergration.Text = "통합 시트";
            this.rb_Intergration.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 311);
            this.Controls.Add(this.gb_SaveMethod);
            this.Controls.Add(this.gb_SQL);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_PW);
            this.Controls.Add(this.txt_Uid);
            this.Controls.Add(this.txt_Database);
            this.Controls.Add(this.txt_Server);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Setting";
            this.TopMost = true;
            this.gb_SQL.ResumeLayout(false);
            this.gb_SQL.PerformLayout();
            this.gb_SaveMethod.ResumeLayout(false);
            this.gb_SaveMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Server;
        private System.Windows.Forms.TextBox txt_Database;
        private System.Windows.Forms.TextBox txt_Uid;
        private System.Windows.Forms.TextBox txt_PW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.GroupBox gb_SQL;
        private System.Windows.Forms.RadioButton rb_MSSQL;
        private System.Windows.Forms.RadioButton rb_MYSQL;
        private System.Windows.Forms.GroupBox gb_SaveMethod;
        private System.Windows.Forms.RadioButton rb_Individual;
        private System.Windows.Forms.RadioButton rb_Intergration;
    }
}