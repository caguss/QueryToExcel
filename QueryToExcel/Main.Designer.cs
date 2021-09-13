
namespace QueryToExcel
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_Excute = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Query = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Server = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Database = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_RowCount = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_QuerySave = new System.Windows.Forms.Button();
            this.btn_OpenQuery = new System.Windows.Forms.Button();
            this.pgb_Loading = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Excute
            // 
            this.btn_Excute.Location = new System.Drawing.Point(459, 225);
            this.btn_Excute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Excute.Name = "btn_Excute";
            this.btn_Excute.Size = new System.Drawing.Size(119, 40);
            this.btn_Excute.TabIndex = 5;
            this.btn_Excute.Text = "쿼리문 실행(F5,F9)";
            this.btn_Excute.UseVisualStyleBackColor = true;
            this.btn_Excute.Click += new System.EventHandler(this.btn_Excute_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(459, 267);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(119, 40);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "엑셀로 저장(S)";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Query
            // 
            this.txt_Query.Location = new System.Drawing.Point(9, 32);
            this.txt_Query.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Query.Multiline = true;
            this.txt_Query.Name = "txt_Query";
            this.txt_Query.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Query.Size = new System.Drawing.Size(442, 217);
            this.txt_Query.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "서버 정보";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Server
            // 
            this.lbl_Server.AutoSize = true;
            this.lbl_Server.Location = new System.Drawing.Point(10, 10);
            this.lbl_Server.Name = "lbl_Server";
            this.lbl_Server.Size = new System.Drawing.Size(1958, 12);
            this.lbl_Server.TabIndex = 4;
            this.lbl_Server.Text = resources.GetString("lbl_Server.Text");
            this.lbl_Server.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "DB명";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Database
            // 
            this.lbl_Database.AutoSize = true;
            this.lbl_Database.Location = new System.Drawing.Point(10, 10);
            this.lbl_Database.Name = "lbl_Database";
            this.lbl_Database.Size = new System.Drawing.Size(383, 12);
            this.lbl_Database.TabIndex = 6;
            this.lbl_Database.Text = "asdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasd";
            this.lbl_Database.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_RowCount, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Status, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(459, 8);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(119, 208);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "ROW Count";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_RowCount
            // 
            this.lbl_RowCount.AutoSize = true;
            this.lbl_RowCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_RowCount.Location = new System.Drawing.Point(3, 161);
            this.lbl_RowCount.Name = "lbl_RowCount";
            this.lbl_RowCount.Size = new System.Drawing.Size(113, 23);
            this.lbl_RowCount.TabIndex = 8;
            this.lbl_RowCount.Text = "0000000000";
            this.lbl_RowCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Status.Location = new System.Drawing.Point(3, 184);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(113, 24);
            this.lbl_Status.TabIndex = 9;
            this.lbl_Status.Text = "Status";
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Status.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbl_Server);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 46);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.lbl_Database);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 46);
            this.panel2.TabIndex = 11;
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(9, 264);
            this.txt_Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ReadOnly = true;
            this.txt_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Result.Size = new System.Drawing.Size(442, 41);
            this.txt_Result.TabIndex = 8;
            // 
            // btn_Setting
            // 
            this.btn_Setting.Location = new System.Drawing.Point(395, 5);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(58, 23);
            this.btn_Setting.TabIndex = 3;
            this.btn_Setting.Text = "설정(P)";
            this.btn_Setting.UseVisualStyleBackColor = true;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_QuerySave
            // 
            this.btn_QuerySave.Location = new System.Drawing.Point(263, 5);
            this.btn_QuerySave.Name = "btn_QuerySave";
            this.btn_QuerySave.Size = new System.Drawing.Size(126, 23);
            this.btn_QuerySave.TabIndex = 2;
            this.btn_QuerySave.Text = "쿼리문 저장(Shift+S)";
            this.btn_QuerySave.UseVisualStyleBackColor = true;
            this.btn_QuerySave.Click += new System.EventHandler(this.btn_QuerySave_Click);
            // 
            // btn_OpenQuery
            // 
            this.btn_OpenQuery.Location = new System.Drawing.Point(160, 5);
            this.btn_OpenQuery.Name = "btn_OpenQuery";
            this.btn_OpenQuery.Size = new System.Drawing.Size(97, 23);
            this.btn_OpenQuery.TabIndex = 1;
            this.btn_OpenQuery.Text = "쿼리문 열기(O)";
            this.btn_OpenQuery.UseVisualStyleBackColor = true;
            this.btn_OpenQuery.Click += new System.EventHandler(this.btn_OpenQuery_Click);
            // 
            // pgb_Loading
            // 
            this.pgb_Loading.Location = new System.Drawing.Point(9, 248);
            this.pgb_Loading.Name = "pgb_Loading";
            this.pgb_Loading.Size = new System.Drawing.Size(442, 16);
            this.pgb_Loading.TabIndex = 14;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 312);
            this.Controls.Add(this.pgb_Loading);
            this.Controls.Add(this.btn_OpenQuery);
            this.Controls.Add(this.btn_QuerySave);
            this.Controls.Add(this.btn_Setting);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txt_Query);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Excute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "QueryToExcel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Excute;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_Query;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Server;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Database;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_RowCount;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_QuerySave;
        private System.Windows.Forms.Button btn_OpenQuery;
        private System.Windows.Forms.ProgressBar pgb_Loading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

