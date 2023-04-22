using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManagerApp
{
    public partial class NewTeacherTaqrerForm : Form
    {
        public static int NumberR = 0;
        public NewTeacherTaqrerForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
        }

        private void NewTeacherTaqrerForm_Load(object sender, EventArgs e)
        {
            DataTable T = new DataTable();
            string a = @"Select
ر,
الاسم,
الحالة,
العمر,
الجوال,
المرحلة,
الحلقة,
غياب_اجازة,
انذار,
تاريخ_التسجيل
From Teachers";
            ConnectionClass.Select(a,T);
            gunaDataGridView1.DataSource = T;
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FindControl fc = new FindControl();
            if (gunaDataGridView1.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (gunaDataGridView1.CurrentCell != null && gunaDataGridView1.CurrentCell.Value != null)
                {
                    NumberR = (int)gunaDataGridView1.CurrentCell.Value;
                    ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Clear();
                    NewTeacherInfoForm T = new NewTeacherInfoForm();
                    T.TopLevel = false;
                    T.WindowState = FormWindowState.Maximized;
                    ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Add(T);
                    ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "Student_Panel")).Hide();
                    T.Show();
                    T.BringToFront();
                    T.Show();
                }
            }
        }
    }
}
