using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace GiaoDien
{
    public partial class frm_ThemTuFile : Form
    {
        public frm_ThemTuFile()
        {
            InitializeComponent();
        }

        private void frm_ThemTuFile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ShopGiay.PHIEUDATHANGNCC' table. You can move, or remove it, as needed.
            this.pHIEUDATHANGNCCTableAdapter.Fill(this.dataSet_ShopGiay.PHIEUDATHANGNCC);
            //ReadExcelContents(FN);
        }
        string FN;
        string pathname;
        string fileName;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "XLS files (*.xls, *.xlt)|*.xls;*.xlt|XLSX files (*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx;*.xlsm;*.xltx;*.xltm|ODS files (*.ods, *.ots)|*.ods;*.ots|CSV files (*.csv, *.tsv)|*.csv;*.tsv|HTML files (*.html, *.htm)|*.html;*.htm";
            open.FilterIndex = 3;
            open.RestoreDirectory = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                txt_link.Text = open.FileName;
                pathname = open.FileName;
                fileName = System.IO.Path.GetFileNameWithoutExtension(open.FileName);
            }
            FN = txt_link.Text.ToString();

            MessageBox.Show(FN);
        }
        public DataTable ReadExcelContents(string fileName)
        {
            try
            {
                //String name = "Sheet1";
                //OleDbConnection connection = new OleDbConnection();

                //connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=Excel 8.0;Data Source=" + fileName); //Excel 97-2003, .xls
                ////string excelQuery = @"Select [Day],[Outlook],[temp],[Humidity],[Wind], [PlaySport] FROM [Sheet1$]";

                //string excelQuery = @"Select * FROM [" + name + "$]";
                //connection.Open();
                //OleDbCommand cmd = new OleDbCommand(excelQuery, connection);
                //OleDbDataAdapter adapter = new OleDbDataAdapter();
                //adapter.SelectCommand = cmd;
                //DataSet ds = new DataSet();
                //adapter.Fill(ds);
                //DataTable dt = ds.Tables[0];
                //dataGridViewX1.DataSource = dt.DefaultView;
                //connection.Close();
                //return dt;

                DataTable tbContainer = new DataTable();
                string strConn = string.Empty;
                FileInfo file = new FileInfo(FN);
                if (!file.Exists) { throw new Exception("Error, file doesn't exists!"); }
                string extension = file.Extension;
                switch (extension)
                {
                    case ".xls":
                        strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathname + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                        break;
                    case ".xlsx":
                        strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathname + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                        break;
                    default:
                        strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathname + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                        break;
                }
                OleDbConnection cnnxls = new OleDbConnection(strConn);
                OleDbDataAdapter oda = new OleDbDataAdapter(string.Format("select * from [Sheet1$]"), cnnxls);
                oda.Fill(tbContainer);
                dataGridViewX1.DataSource = tbContainer;
                return tbContainer;

            }
            catch (Exception ex)
            {
                MessageBox.Show("File không tồn tại. " + ex.Message, "vui lòng kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            ReadExcelContents(FN);  
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        int newLocationX, newLocationY;
        private void CTHD_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            newLocationX = e.X;
            newLocationY = e.Y;
        }

        private void CTHD_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Left = Left + (e.X - newLocationX);
            Top = Top + (e.Y - newLocationY);
        }
        int n;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                n = 1;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                n = 0;
            }
        }
    
    }
}
