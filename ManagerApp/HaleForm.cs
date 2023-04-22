using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ManagerApp
{
    public partial class HaleForm : Form
    {
        public HaleForm()
        {
            InitializeComponent();
        }
        FindControl fc = new FindControl();
        private void gunaButton6_Click(object sender, EventArgs e)
        {
            NewStudentsTqarerForm F = new NewStudentsTqarerForm();
            OleDbCommand Command = new OleDbCommand();
            Command.Connection = ConnectionClass.Connection;
            Command.CommandText = "update Students Set الحالة = '"+StatusComboBox.SelectedItem+"',تاريخ_الحالة = '"+gunaDateTimePicker1.Value+"'where ر = "+NewStudentsTqarerForm.Hale+"";
            if(Command.ExecuteNonQuery()==1)
            {
                MessageBox.Show("تم تعديل الحالة");
                F.FillTexts();
                DataTable T = new DataTable();
                string sql2 = @"Select
ر,
الاسم,
الحالة,
العمر,
جوال,
مرحلة,
حلقة,
غياب_اجازة,
حفظ,
تلاوة,
مكفل,
انذار,
اسم_المعلم,
Format (تاريخ_التسجيل,'Short Date') As تاريخ_التسجيل From Students";
                ConnectionClass.Select(sql2, T);
                ((Guna.UI.WinForms.GunaDataGridView)fc.Ctrl(fc.TheForm("NewStudentsTqarerForm"), "gunaDataGridView1")).DataSource=T;
                this.Hide();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
