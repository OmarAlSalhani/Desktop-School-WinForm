using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
namespace ManagerApp
{
    class ConnectionClass
    {
        public static OleDbConnection Connection=new OleDbConnection();
        public static void Connect()
        {
            try
            {             
                    Connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Settings1.Default.DatabasePath);
                    Connection.Open();
                
            }
            catch(OleDbException ea)
            {
                MessageBox.Show(ea.Message);
                if (ea.Message.Contains("Could not find file") || ea.Message.Contains("No error"))
                {
                    MessageBox.Show("سيتم فتح مستعرض الملفات لأختيار ملف قاعدة البيانات");
                    OpenFileDialog OF = new OpenFileDialog();
                    OF.ShowDialog();
                    Settings1.Default.DatabasePath = OF.FileName;
                    Settings1.Default.Save();
                    Application.Restart();
                    
                }
            }
        }
        public static void Select(string A,DataTable Table)
        {
            OleDbDataAdapter DA;
            DA = new OleDbDataAdapter(A, Connection);
            DA.Fill(Table);
        }
        public static void Add(string command)
        {
            OleDbCommand Command = new OleDbCommand();
            Command.Connection = Connection;
            Command.CommandText = command;
            if (Command.ExecuteNonQuery() >= 1)
                MessageBox.Show("تمت أضافة الطالب بنجاح");
        }
    }
}
