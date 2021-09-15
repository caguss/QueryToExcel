﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using ClosedXML.Excel;
using System.IO;
using Action = System.Action;
using System.Data.SqlClient;
using DataTable = System.Data.DataTable;

namespace QueryToExcel
{

    public partial class Main : Form
    {

        ConnectionSetting Connection = new ConnectionSetting();
        private DataSet Result = new DataSet();

        public Main()
        {
            InitializeComponent();
            //접속정보 Load
            Connection.MakeConnection();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            //접속 정보 Form에 보여줌
            lbl_Server.Text = Connection.Server;
            lbl_Database.Text = Connection.Database;
            lbl_RowCount.Text = "0";
            HelpButtonClicked -= null;
            HelpButtonClicked += Helpbtn;
        }

        private void Helpbtn(object sender, CancelEventArgs e)
        {
            string Notice =
                "<Ver 1.0>\n" +
                "DB에 있는 데이터를 쿼리문만을 통해 엑셀 형태로 추출할 수 있다.\n" +
                "도움말(F1): 프로그램 사용 도우미.\n" +
                "시트이름 : 엑셀 저장 시 시트의 이름.\n" +
                "쿼리문 열기(Ctrl+O) : txt 파일 내 쿼리문을 가져온다.\n" +
                "쿼리문 저장(Ctrl+Shift+S) : 쿼리문을 txt 파일로 저장한다.\n" +
                "설정(Ctrl+P) : 서버, 데이터베이스, 포트, ID, PW 세팅.\n" +
                "쿼리창 : 쿼리를 적는 곳. 여러 개의 쿼리도 한번에 적용할 수 있다.\n" +
                "ROW COUNT : 쿼리에 해당하는 모든 ROW 수의 총합.\n" +
                "쿼리문 실행(F5 or F9) : 서버에 접속해 데이터를 가져오는 단계.\n" +
                "엑셀로 저장(Ctrl+S) : 쿼리실행 이후 가져온 데이터를 엑셀로 저장한다.\n" +
                "-> 문의사항은 방찬석 사원에게로.\n";
            MessageBox.Show(Notice);//Works :)
            e.Cancel = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.S:
                    btn_Save.PerformClick();
                    //btn_Save_Click(null, null);
                    return true;
                case Keys.Control | Keys.O:
                    btn_OpenQuery.PerformClick();
                    //btn_OpenQuery_Click(null, null);
                    return true;
                case Keys.F5:
                case Keys.F9:
                    btn_Excute.PerformClick();
                    //btn_Excute_Click(null, null);
                    return true;
                case Keys.Control | Keys.P:
                    //btn_Setting_Click(null, null);
                    btn_Setting.PerformClick();
                    return true;
                case Keys.Control | Keys.Shift | Keys.S:
                    //btn_QuerySave_Click(null, null);
                    btn_QuerySave.PerformClick();
                    return true;
                case Keys.F1:
                    Helpbtn(null, new CancelEventArgs());
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        private async void btn_Excute_Click(object sender, EventArgs e)
        {
            Result = new DataSet();
            btn_Excute.Enabled = false;
            btn_Save.Enabled = false;
            if (txt_Query.Text == "")
            {
                txt_Result.Text = "쿼리를 입력해 주세요.";
                btn_Excute.Enabled = true;
                return;
            }
            pgb_Loading.Value = 0;
            lbl_Status.Text = "Querying...";
            lbl_Status.Visible = true;
            pgb_Loading.Value += 10;
            switch (Connection.SQL)
            {
                case "MYSQL":
                    await MYSQLQuerying();
                    break;
                case "MSSQL":
                    await MSSQLQuerying();
                    break;
            }

            btn_Excute.Enabled = true;
            btn_Save.Enabled = true;
        }
        #region Connection 분기
        private async Task MSSQLQuerying()
        {
            await Task.Run(() =>
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Connection.ConnectionString))
                    {
                        txt_Result.Invoke(new Action(delegate ()
                        {
                            txt_Result.Text = "연결 시도 중..";

                        }));
                        conn.Open();
                        pgb_Loading.Invoke(new Action(delegate ()
                        {
                            pgb_Loading.Value += 10;
                        }));
                        txt_Result.Invoke(new Action(delegate ()
                        {
                            txt_Result.Text = "쿼리 시도중..";

                        }));
                        SqlDataAdapter adpt = new SqlDataAdapter(txt_Query.Text, conn);
                        adpt.Fill(Result);
                        adpt.Dispose();
                    }
                    int totalRowCount = 0;
                    double eachpercent = 70 / Result.Tables.Count;
                    for (int i = 0; i < Result.Tables.Count; i++)
                    {
                        totalRowCount += Result.Tables[i].Rows.Count;
                        pgb_Loading.Invoke(new Action(delegate ()
                        {
                            pgb_Loading.Value += Convert.ToInt32(eachpercent);
                        }));
                    }
      
                    lbl_RowCount.Invoke(new Action(delegate ()
                    {
                        lbl_RowCount.Text = totalRowCount.ToString();
                    }));
                    txt_Result.Invoke(new Action(delegate ()
                    {
                        txt_Result.Text = string.Format("쿼리가 정상적으로 작동했습니다.\r\n테이블 수 : {0}", Result.Tables.Count);

                    }));
                    lbl_Status.Invoke(new Action(delegate ()
                    {
                        lbl_Status.Text = "Finished!";
                    }));
                    pgb_Loading.Invoke(new Action(delegate ()
                    {
                        pgb_Loading.Value = 100;
                    }));

                }
                catch (Exception ex)
                {
                    lbl_Status.Invoke(new Action(delegate ()
                    {
                        lbl_Status.Text = "Error!";
                    }));

                    txt_Result.Invoke(new Action(delegate ()
                    {
                        txt_Result.Text = ex.Message;
                    }));
                }

            });
        }
        private async Task MYSQLQuerying()
        {
            await Task.Run(() =>
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(Connection.ConnectionString))
                    {
                        txt_Result.Invoke(new Action(delegate ()
                        {
                            txt_Result.Text = "연결 시도 중..";

                        }));
                        conn.Open();
                        pgb_Loading.Invoke(new Action(delegate ()
                        {
                            pgb_Loading.Value += 10;
                        }));
                        txt_Result.Invoke(new Action(delegate ()
                        {
                            txt_Result.Text = "쿼리 시도중..";

                        }));
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandTimeout = 86400;
                        cmd.CommandText = txt_Query.Text;
                        cmd.Connection = conn;
                        MySqlDataAdapter adpt = new MySqlDataAdapter(cmd);
                        adpt.Fill(Result);
                        adpt.Dispose();
                    }

                    int totalRowCount = 0;
                    double eachpercent = 80 / Result.Tables.Count;
                    for (int i = 0; i < Result.Tables.Count; i++)
                    {
                        totalRowCount += Result.Tables[i].Rows.Count;
                        pgb_Loading.Invoke(new Action(delegate ()
                        {
                            pgb_Loading.Value += Convert.ToInt32(eachpercent);
                        }));
                    }

                    lbl_RowCount.Invoke(new Action(delegate ()
                    {
                        lbl_RowCount.Text = totalRowCount.ToString();
                    }));
                    txt_Result.Invoke(new Action(delegate ()
                    {
                        txt_Result.Text = string.Format("쿼리가 정상적으로 작동했습니다.\r\n테이블 수 : {0}", Result.Tables.Count);

                    }));
                    lbl_Status.Invoke(new Action(delegate ()
                    {
                        lbl_Status.Text = "Finished!";
                    }));
                    pgb_Loading.Invoke(new Action(delegate ()
                    {
                        pgb_Loading.Value = 100;
                    }));
                }
                catch (Exception ex)
                {
                    lbl_Status.Invoke(new Action(delegate ()
                    {
                        lbl_Status.Text = "Error!";
                    }));

                    txt_Result.Invoke(new Action(delegate ()
                    {
                        txt_Result.Text = ex.Message;
                    }));
                }
            });
        }

        #endregion

        private async void btn_Save_Click(object sender, EventArgs e)
        {
            btn_Save.Enabled = false;
            btn_Excute.Enabled = false;

            if (Convert.ToInt32(lbl_RowCount.Text) <= 0)
            {
                txt_Result.Text = "쿼리를 먼저 실행하세요.";
                return;
            }
            txt_Result.Text = "잠시만 기다려주세요..";
            lbl_Status.Text = "Saving...";
            pgb_Loading.Value = 0;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "경로 설정";
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.Filter = "xlsx 파일|*.xlsx|xls 파일|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pgb_Loading.Invoke(new Action(delegate ()
                {
                    pgb_Loading.Value += 10;
                }));
                await Saving(saveFileDialog.FileName);
            }
            btn_Save.Enabled = true;
            btn_Excute.Enabled = true;
        }

        private async Task Saving(string filename)
        {
            
            
            await Task.Run(() =>
            {
               
                int num = 1;
                Microsoft.Office.Interop.Excel.Application ap = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook = ap.Workbooks.Add();
                XLWorkbook wb = new XLWorkbook();

                try
                {
                    double eachpercent = 80 / Result.Tables.Count;

                    //통합 파일인 경우
                    if (Connection.SaveIntergration)
                    {
                        #region 통합 파일
                        while (Result.Tables.Count >= 1)
                        {
                            wb.Worksheets.Add(Result.Tables[0], Path.GetFileNameWithoutExtension(filename) + num.ToString());
                            wb.Worksheet(num).Columns().AdjustToContents();  // Adjust column width
                            wb.Worksheet(num).Rows().AdjustToContents();     // Adjust row heights

                            pgb_Loading.Invoke(new Action(delegate ()
                            {
                                pgb_Loading.Value += Convert.ToInt32(eachpercent);
                            }));
                            num++;
                            Result.Tables[0].Dispose();
                            Result.Tables.RemoveAt(0);
                        }
                        wb.SaveAs(filename);

                        //메모리 최적화를 위한 반복 로직 변경
                        //foreach (System.Data.DataTable dataTable in Result.Tables)
                        //{
                        //    wb.Worksheets.Add(dataTable, Path.GetFileNameWithoutExtension(filename) + num.ToString());
                        //    wb.Worksheet(num).Columns().AdjustToContents();  // Adjust column width
                        //    wb.Worksheet(num).Rows().AdjustToContents();     // Adjust row heights

                        //    pgb_Loading.Invoke(new Action(delegate ()
                        //    {
                        //        pgb_Loading.Value += Convert.ToInt32(eachpercent);
                        //    }));
                        //    num++;
                        //}
                        #endregion
                    }
                    else
                    {

                        string filepath = Path.GetDirectoryName(filename) + @"\\ExcelToQuery";
                        if (File.Exists(filepath) == false)
                        {
                            DirectoryInfo di = new DirectoryInfo(filepath);
                            di.Create();
                        }


                        #region 개별 파일
                        while (Result.Tables.Count >= 1)
                        {
                            wb.Worksheets.Add(Result.Tables[0]);
                            wb.Worksheet(1).Columns().AdjustToContents();  // Adjust column width
                            wb.Worksheet(1).Rows().AdjustToContents();     // Adjust row heights

                            wb.SaveAs(filepath + "\\" + Path.GetFileNameWithoutExtension(filename) + num + Path.GetExtension(filename));

                            wb.Dispose();

                            wb = new XLWorkbook();
                            Result.Tables[0].Dispose();
                            Result.Tables.RemoveAt(0);

                            pgb_Loading.Invoke(new Action(delegate ()
                            {
                                pgb_Loading.Value += Convert.ToInt32(eachpercent);
                            }));
                            num++;
                            workbook.Close();

                            workbook = ap.Workbooks.Add();
                        }
                        #endregion
                    }

                    Result.Dispose();
                    Result = new DataSet();
                    workbook.Close();
                    ap.Quit();

                    pgb_Loading.Invoke(new Action(delegate ()
                    {
                        pgb_Loading.Value = 100;
                    }));
                    txt_Result.Invoke(new Action(delegate ()
                    {
                        txt_Result.Text = string.Format("저장이 완료되었습니다. \r\n경로 : {0}", filename);
                    }));
                    lbl_Status.Invoke(new Action(delegate ()
                    {
                        lbl_Status.Text = "Finished!";
                    }));
                    lbl_RowCount.Invoke(new Action(delegate ()
                    {
                        lbl_RowCount.Text = "0";
                    }));
                    btn_Save.Invoke(new Action(delegate ()
                    {
                        btn_Save.Enabled = true;
                    }));
                    pgb_Loading.Invoke(new Action(delegate ()
                    {
                        pgb_Loading.Value = 100;
                    }));

                }
                catch (Exception ex)
                {
                    wb = new XLWorkbook();

                    lbl_Status.Invoke(new Action(delegate ()
                    {
                        lbl_Status.Text = "Error!";
                    }));
                    txt_Result.Invoke(new Action(delegate ()
                    {
                        txt_Result.Text = ex.Message;
                    }));
                    
                }
            });
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting(Connection);

            if (setting.ShowDialog() == DialogResult.OK)
            {
                //창 닫힌 후,
                Connection = setting.FinishedConn;
                lbl_Server.Text = Connection.Server;
                lbl_Database.Text = Connection.Database;
            }

        }
        #region 쿼리 저장,열기
        private void btn_QuerySave_Click(object sender, EventArgs e)
        {
            btn_QuerySave.Enabled = false;
            lbl_Status.Text = "Saving...";

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "경로 설정";
            saveFile.DefaultExt = "txt";
            saveFile.Filter = "텍스트 파일|*.txt";
            saveFile.InitialDirectory = Settings.Default.RecentPath;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFile.FileName, txt_Query.Text, Encoding.Default);
                    txt_Result.Text = string.Format("쿼리 저장이 완료되었습니다. \r\n경로 : {0}", saveFile.FileName);
                    lbl_Status.Text = "Finished!";
                }
                catch (Exception ex)
                {
                    lbl_Status.Text = "Error!";
                    txt_Result.Text = ex.Message;
                }

            }

            lbl_Status.Text = "Finished!";
            btn_QuerySave.Enabled = true;

        }

        private void btn_OpenQuery_Click(object sender, EventArgs e)
        {
            btn_OpenQuery.Enabled = false;
            lbl_Status.Text = "Saving...";

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "경로 설정";
            openFile.DefaultExt = "txt";
            openFile.InitialDirectory = Settings.Default.RecentPath;
            openFile.Filter = "텍스트 파일|*.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFile.FileName);
                    txt_Query.Text = sr.ReadToEnd();
                    txt_Result.Text = string.Format("쿼리 열기가 완료되었습니다. \r\n경로 : {0}", openFile.FileName);
                    lbl_Status.Text = "Finished!";

                    Settings.Default.RecentPath = openFile.FileName;
                    Settings.Default.Save();
                }
                catch (Exception ex)
                {
                    lbl_Status.Text = "Error!";
                    txt_Result.Text = ex.Message;
                }

            }


            lbl_Status.Text = "Finished!";
            btn_OpenQuery.Enabled = true;
        }
        #endregion
    }
}
