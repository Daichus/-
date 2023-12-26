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
    public partial class Stats : Form
    {
        private string[] Students;//學生座號姓名
        private List<string> student_atten = new List<string>();//出缺紀錄
          
        public Stats()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;
            if (string.IsNullOrEmpty(txt2.Text))
            {
                MessageBox.Show("學生姓名欄位不能為空");
                return;
            }
            if (!DateTime.TryParse(txt3.Text, out startDate))
            {
                MessageBox.Show("日期格式錯誤");
                return;
            }
             
            endDate = startDate;
            if (!string.IsNullOrEmpty(txt4.Text))
            {
                if (!DateTime.TryParse(txt4.Text, out endDate))
                {
                    MessageBox.Show("日期格式錯誤");
                }
            }
             
            var AttendQuery = student_atten
            .Where(record => DateTime.Parse(record.Split(',')[6]) >= startDate &&
                     DateTime.Parse(record.Split(',')[6]) <= endDate &&
                     record.Split(',')[0] == txt1.Text.Trim())
                     .SelectMany(record => record.Split(',').Skip(2).Take(4));
            
            int countSick = AttendQuery.Count(type => type == "病");
            int countPersonal = AttendQuery.Count(type => type == "事");
            int countOfficial = AttendQuery.Count(type => type == "公");
            int countEmpty = AttendQuery.Count(type => type == "曠"); 
            txt_s.Text = countSick.ToString();
            txt_p.Text = countPersonal.ToString();
            txt_o.Text = countOfficial.ToString();
            txt_e.Text = countEmpty.ToString();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (var Student in Students)
            {
                if (txt1.Text.Trim() == Student.Split(',')[0].Trim())
                {
                    txt2.Text = Student.Split(',')[1];
                    return;
                }
                else
                {
                    txt2.Text = "";
                }
            }
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            string student = FileLoader.StudentFileLoad(FileLoader.StudentFilePath); 
            string RecordString = FileLoader.RecordFileLoad(FileLoader.RecordFilePath);
            string[] records = RecordString.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            Students = student.Split(new[] {"\r\n"},StringSplitOptions.RemoveEmptyEntries);
            student_atten.AddRange(records);

        }

        private void Txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
