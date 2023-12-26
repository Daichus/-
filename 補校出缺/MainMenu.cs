using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
 

namespace 補校出缺
{
    public partial class MainMenu : Form
    {
        private string[] Students;//儲存學生座號姓名的數組
        private List<string> StudentRecord=new List<string>();//儲存出缺紀錄字串的數列
        
        
        string Txt1DefaultText = "座號格式:10101";
        string Txt4DefaultText = "可不填寫";
        string DateTimeDefaultText = "格式:2024/01/01";
        string ErrorMessageFileNotFound = @"請確保檔案位於Documents\1121補校出缺\項目下!";
        public MainMenu()   
        {
            InitializeComponent();
            txt1.Text = Txt1DefaultText;
            txt1.ForeColor = Color.Gray;
            txt3.Text = DateTimeDefaultText;
            txt3.ForeColor = Color.Gray;
            txt4.Text = Txt4DefaultText;
            txt4.ForeColor = Color.Gray;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string StudentString=FileLoader.StudentFileLoad(FileLoader.StudentFilePath);
            string StudentRecordString=FileLoader.RecordFileLoad(FileLoader.RecordFilePath);
            if (StudentString == "File not found"|| StudentRecordString=="File not found")
            {
                MessageBox.Show(ErrorMessageFileNotFound);
                Application.Exit();
            }
            //取得學收缺況紀錄字串

            Students = StudentString.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);//取得各筆姓名var:["10101,小明","10102,小王"]
            string[] records = StudentRecordString.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);//取得各筆缺況紀錄var:["10101,小名,曠,曠,曠,曠,2023/01/01"]
            StudentRecord.AddRange(records); 
            com1.Items.AddRange(new string[] {" ","曠","病","事","公" });
            for (int i = 1; i <= 4; i++)
            {
                com2.Items.Add(i.ToString());
                com3.Items.Add(i.ToString());
            }
            com1.SelectedIndex = 0;
            com2.SelectedIndex = 0;
            com3.SelectedIndex = 0;

            InitializeListView();
        }

        public void InitializeListView()//初始化ListView
        {
            lv1.View = View.Details;
            lv1.Columns.Clear();
            lv1.Items.Clear();
            int col_width = 55;

            lv1.Columns.Add("座號", 75, HorizontalAlignment.Left);
            lv1.Columns.Add("姓名", 75, HorizontalAlignment.Left);
            lv1.Columns.Add("第一節", col_width, HorizontalAlignment.Left);
            lv1.Columns.Add("第二節", col_width, HorizontalAlignment.Left);
            lv1.Columns.Add("第三節", col_width, HorizontalAlignment.Left);
            lv1.Columns.Add("第四節", col_width, HorizontalAlignment.Left);
            lv1.Columns.Add("日期", 105, HorizontalAlignment.Left);

            if (!String.IsNullOrEmpty(txt2.Text))
            {
                var SortedRecords = StudentRecord.Where(record=>record.Split(',')[1]==txt2.Text)
                .Select(record => new { Record = record, Date = DateTime.Parse(record.Split(',')[6]) })
                .OrderBy(x => x.Date).ToList();

                lv1.Items.Clear();

                foreach (var item in SortedRecords)
                {
                    var listViewItem = new ListViewItem(item.Record.Split(','));
                    listViewItem.Tag = item.Record;
                    lv1.Items.Add(listViewItem);
                }
            }
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            foreach (var Student in Students)
            {
                if (txt1.Text.Trim() == Student.Split(',')[0])
                {
                    txt2.Text = Student.Split(',')[1];
                    break;
                }
                else
                {
                    txt2.Text = "";
                }
            }
            InitializeListView();

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Bt2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt3.Text) || com1.SelectedIndex == -1 || com2.SelectedIndex == -1 || com3.SelectedIndex == -1)
            {
                MessageBox.Show("請確認缺曠訊息均已填寫");
                return;
            }//確保下拉式選單，學生資料，以及日期均有填寫
            if (!DateTime.TryParse(txt3.Text, out DateTime start_day))
            {
                MessageBox.Show("無效日期格式");
                return;
            }
            DateTime endDate = start_day;
            if (!string.IsNullOrEmpty(txt4.Text))
            {
                if (!DateTime.TryParse(txt4.Text, out endDate))
                {
                    MessageBox.Show("无效的结束日期格式");
                    return;
                }
            }
            for (DateTime date = start_day; date <= endDate; date = date.AddDays(1))
            {
                foreach (var Record in StudentRecord)
                {
                    var field = Record.Split(',');
                    if (field[1] == txt2.Text && field[6] == date.ToString("yyyy/M/d"))
                    {
                        MessageBox.Show($"{txt2.Text}已有該筆資料!");
                        return;
                    }
                }

                string record = GenerateData(date);
                StudentRecord.Add(record);
            }
            
             
            MessageBox.Show($"登入完成!");
            InitializeListView();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Record =String.Join("\r\n", StudentRecord);
            File.WriteAllText(FileLoader.RecordFilePath, Record, Encoding.UTF8);
            MessageBox.Show("儲存完成");
        }
        private string GenerateData(DateTime date)
        {
            string[] absence_data=new string[4] { " "," "," "," "};
            string absence_type = com1.SelectedItem.ToString();
            //取得缺曠類別
            int.TryParse(com2.SelectedItem.ToString(),out int period1);
            int.TryParse(com3.SelectedItem.ToString(), out int period2);
            //取得下拉式選單的數字
            for (int i = period1 - 1; i <= period2-1; i++)
            {
                absence_data[i] = absence_type;
            }
            return txt1.Text + "," + txt2.Text + "," + string.Join(",", absence_data) + "," + date.ToString("yyyy/M/d");
            //組合成單一筆資料
        }
        

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("是否要離開？","請先儲存資料",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt1.Text))
            {
                InitializeListView();
                return;
            }  
            var filter = StudentRecord.Where(record => record.Split(',')[0].Trim().Equals(txt1.Text.Trim())).ToList();
            lv1.Items.Clear();
            foreach (var record in filter)
            {
                lv1.Items.Add(new ListViewItem(record.Split(',')));
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("確定刪除？", "您正在刪除一筆資料", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem records in lv1.SelectedItems)
                {
                    var remove_r = records.Tag as string;
                    StudentRecord.Remove(remove_r);
                    lv1.Items.Remove(records);
                }
                InitializeListView();
            }
            
        }

        
       

        private void Bt6_Click_1(object sender, EventArgs e)
        {
            Stats stats = new Stats(); 
            stats.Show();           
        }

        

        private void Button2_Click_2(object sender, EventArgs e)
        {
            txt1.Text=null;
            txt2.Text = null;
        }

        private void Txt1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt1.Text))
            {
                txt1.Text = Txt1DefaultText;
                txt1.ForeColor = Color.Gray;
            }
        }

        private void Txt1_Enter(object sender, EventArgs e)
        {
            if (txt1.Text == Txt1DefaultText)
            {
                txt1.Text = "";
                txt1.ForeColor = Color.Black;
            }
        }

        private void Txt3_Enter(object sender, EventArgs e)
        {
            if (txt3.Text == DateTimeDefaultText)
            {
                txt3.Text = "";
                txt3.ForeColor = Color.Black;
            }
        }

        private void Txt3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt3.Text))
            {
                txt3.Text = DateTimeDefaultText;
                txt3.ForeColor = Color.Gray;
            }
        }

        private void Txt4_Enter(object sender, EventArgs e)
        {
            if (txt4.Text == Txt4DefaultText)
            {
                txt4.Text = "";
                txt4.ForeColor = Color.Black;
            }
        }

        private void Txt4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt4.Text))
            {
                txt4.Text = Txt4DefaultText;
                txt4.ForeColor = Color.Gray;
            }
        }
    }
}
