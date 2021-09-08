using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryToExcel
{
    public partial class Setting : Form
    {
        public ConnectionSetting FinishedConn = new ConnectionSetting();
        public string SQLKind = Settings.Default.SQL;
        public Setting()
        {
            InitializeComponent();
        }
        public Setting(ConnectionSetting connsett)
        {
            InitializeComponent();
            txt_Server.Text = connsett.Server;
            txt_Database.Text = connsett.Database;
            txt_Uid.Text = connsett.UserName;
            txt_PW.Text = connsett.UserPW;
            txt_Port.Text = connsett.Port;
            switch (SQLKind)
            {
                case "MYSQL":
                    rb_MYSQL.Checked = true;
                    break;
                case "MSSQL":
                    rb_MSSQL.Checked = true;
                    break;
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            FinishedConn.Server = txt_Server.Text;
            FinishedConn.Database = txt_Database.Text;
            FinishedConn.UserName = txt_Uid.Text;
            FinishedConn.UserPW = txt_PW.Text;
            FinishedConn.Port = txt_Port.Text;
            FinishedConn.SQL = SQLKind;

            FinishedConn.MakeConnection(txt_Server.Text, txt_Port.Text, txt_Uid.Text, txt_PW.Text, txt_Database.Text, SQLKind);

            Settings.Default.Server = txt_Server.Text;
            Settings.Default.Database = txt_Database.Text;
            Settings.Default.Uid = txt_Uid.Text;
            Settings.Default.SQL = SQLKind;
            Settings.Default.Password = txt_PW.Text;
            Settings.Default.Port = txt_Port.Text;
            Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                SQLKind = rb.Text;
            }
        }

    }
}
