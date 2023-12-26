using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 補校出缺
{
    class FileLoader
    {
        public static string StudentFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\1121補校出缺\學生名單.csv";
        public static string RecordFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\1121補校出缺\出缺紀錄.csv";
        public static string StudentFileLoad(string students)
        {
           
            try
            {
                return File.ReadAllText(students, Encoding.Default);
            }
            catch(FileNotFoundException)
            {  
                return "File not found";
            }
            
        }
        public static string RecordFileLoad(string record)
        {
            try
            {
                return File.ReadAllText(record, Encoding.Default);
            }
            catch (FileNotFoundException)
            {
                return "File not found";
            }
        }


    }
}
