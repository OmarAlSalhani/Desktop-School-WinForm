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
    public partial class WarningForm : Form
    {
        public WarningForm()
        {
            InitializeComponent();
        }
        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaCheckBox1.Checked)
                gunaDateTimePicker2.Enabled = true;
            else
            {
                gunaDateTimePicker2.Enabled = false;

            }


        }
        FindControl fc = new FindControl();
        private void gunaButton6_Click(object sender, EventArgs e)
        {
            NewStudentsTqarerForm F = new NewStudentsTqarerForm();
            OleDbCommand Command = new OleDbCommand();
            Command.Connection = ConnectionClass.Connection;
            Command.CommandText = @"insert into Warnings (السبب,التاريخ,حضور_الولي,رقم_الطالب,اسم_الطالب)
values(
@reason,
@date,
@wle,
@number,
@name)";
            Command.Parameters.AddWithValue("@reason", textBox1.Text);
            Command.Parameters.AddWithValue("@date", gunaDateTimePicker1.Value);
            Command.Parameters.AddWithValue("@wle", (gunaDateTimePicker2.Enabled == false) ? "لا" : gunaDateTimePicker2.Value.ToShortDateString());
            Command.Parameters.AddWithValue("@number", NewStudentsTqarerForm.Warning);
            Command.Parameters.AddWithValue("@name", NewStudentsTqarerForm.WarningName);


            if (Command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("تم أضافة أنذار");
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
                ((Guna.UI.WinForms.GunaDataGridView)fc.Ctrl(fc.TheForm("NewStudentsTqarerForm"), "gunaDataGridView1")).DataSource = T;
                this.Hide();
            }
        }
    }
}