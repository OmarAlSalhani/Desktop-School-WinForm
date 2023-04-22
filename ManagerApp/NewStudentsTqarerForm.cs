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
    public partial class NewStudentsTqarerForm : Form
    {
        public static int R = 0;
        public static int Hale = 0;
        public static int Warning = 0;
        public static string WarningName = null;
        public NewStudentsTqarerForm()
        {
            InitializeComponent();
        }
        FindControl fc = new FindControl();
        private void SaveButton_Click(object sender, EventArgs e)
        {
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Remove(this);
            NewShowStudentForm NSSF = new NewShowStudentForm();
            NSSF.TopLevel = false;
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Add(NSSF);
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "Student_Panel")).Show();
            NSSF.Show();
            NSSF.BringToFront();
        }

        private void NewStudentsTqarerForm_Load(object sender, EventArgs e)
        {
            FillTexts();
            ConnectionClass.Connect();
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
            gunaDataGridView1.DataSource = T;
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
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
(select count(السبب) from Warnings where ) As انذار,
اسم_المعلم,
Format (تاريخ_التسجيل,'Short Date') As تاريخ_التسجيل From Students where الاسم like '%" + gunaTextBox1.Text + "%'";
            OleDbDataAdapter AD = new OleDbDataAdapter(sql2, ConnectionClass.Connection);
            DataTable dt = new DataTable();
            AD.Fill(dt);
            gunaDataGridView1.DataSource = dt;
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Remove(this);
            NewShowStudentForm NSSF = new NewShowStudentForm();
            NSSF.TopLevel = false;
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Add(NSSF);
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "Student_Panel")).Show();
            NSSF.Show();
            NSSF.BringToFront();

        }
        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gunaDataGridView1.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (gunaDataGridView1.CurrentCell != null && gunaDataGridView1.CurrentCell.Value != null)
                {
                    R = (int)gunaDataGridView1.CurrentCell.Value;
                }
            }
            else if (gunaDataGridView1.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1)
            {
                if (gunaDataGridView1.CurrentCell != null && gunaDataGridView1.CurrentCell.Value != null)
                {
                    Hale =(int) gunaDataGridView1.CurrentRow.Cells[0].Value;
                    HaleForm H = new HaleForm();
                    H.Show();
                }
            }
            else if (gunaDataGridView1.CurrentCell.ColumnIndex.Equals(11) && e.RowIndex != -1)
            {
                if (gunaDataGridView1.CurrentCell != null && gunaDataGridView1.CurrentCell.Value != null)
                {
                    Warning = (int)gunaDataGridView1.CurrentRow.Cells[0].Value;
                    WarningName =gunaDataGridView1.CurrentRow.Cells[1].Value.ToString();
                    WarningForm H = new WarningForm();
                    H.Show();
                }
            }
        }
        private void comboBox1_Click(object sender, EventArgs e)
        {
            TeacherComboBox.Items.Clear();
            string query = "select اسم_المعلم from Students";
            DataTable T = new DataTable();
            ConnectionClass.Select(query, T);
            for (int i = 0; i < T.Rows.Count; i++)
            {
                TeacherComboBox.Items.Add(T.Rows[i]["اسم_المعلم"].ToString());
            }
        }
        private void Mr7leComboBox_Click(object sender, EventArgs e)
        {
            Mr7leComboBox.Items.Clear();
            string query = "select ID from Rings";
            DataTable T = new DataTable();
            ConnectionClass.Select(query, T);
            for (int i = 0; i < T.Rows.Count; i++)
            {
                Mr7leComboBox.Items.Add(T.Rows[i]["ID"].ToString());
            }
        }
        private void RingComboBox_Click(object sender, EventArgs e)
        {
            RingComboBox.Items.Clear();
            string query = "select حلقة from Students";
            DataTable T = new DataTable();
            ConnectionClass.Select(query, T);
            for (int i = 0; i < T.Rows.Count; i++)
            {
                RingComboBox.Items.Add(T.Rows[i]["حلقة"].ToString());
            }
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
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
Format (تاريخ_التسجيل,'Short Date') As تاريخ_التسجيل From Students where
اسم_المعلم = '" + TeacherComboBox.Text + "'or الجنس = '"+SexComboBox.Text+"'or الحالة = '"+StatusComboBox.Text+"'or حلقة = '"+RingComboBox.Text+"'or مرحلة = '"+Mr7leComboBox.Text+"' ";
            OleDbDataAdapter AD = new OleDbDataAdapter(sql2, ConnectionClass.Connection);
            DataTable dt = new DataTable();
            AD.Fill(dt);
            gunaDataGridView1.DataSource = dt;
        }
        public void FillTexts()
        {
            DataTable TotalT = new DataTable();
            DataTable MaleT = new DataTable();
            DataTable FemaleT = new DataTable();
            DataTable ExistT = new DataTable();
            DataTable SuccesfulT = new DataTable();
            DataTable FireT = new DataTable();
            DataTable FailT = new DataTable();
            DataTable WaitT = new DataTable();
            ConnectionClass.Select("Select count(ر) As TotCount from Students",TotalT);
            Total.Text = TotalT.Rows[0]["TotCount"].ToString();
            ConnectionClass.Select(@"Select count (ر) As MaleCount from Students where
الجنس = 'ذكر'
and
الحالة = 'يحضر'
", MaleT);
            Male.Text= MaleT.Rows[0]["MaleCount"].ToString();
            ConnectionClass.Select(@"Select count (ر) As FemaleCount from Students where
الجنس = 'انثى'
and
الحالة = 'يحضر'
", FemaleT);
            Female.Text = FemaleT.Rows[0]["FemaleCount"].ToString();

            ConnectionClass.Select(@"Select count (ر) As ExistT from Students where
الحالة = 'يحضر'
", ExistT);
            Exist.Text = ExistT.Rows[0]["ExistT"].ToString();


            ConnectionClass.Select(@"Select count (ر) As SuccesfulT from Students where
الحالة = 'ناجح'
", SuccesfulT);
            Succesful.Text = SuccesfulT.Rows[0]["SuccesfulT"].ToString();

            ConnectionClass.Select(@"Select count (ر) As FailT from Students where
الحالة = 'راسب'
", FailT);
            Fail.Text = FailT.Rows[0]["FailT"].ToString();

            ConnectionClass.Select(@"Select count (ر) As FireT from Students where
الحالة = 'مطرود'
", FireT);
            Fire.Text = FireT.Rows[0]["FireT"].ToString();

            ConnectionClass.Select(@"Select count (ر) As WaitT from Students where
الحالة = 'أنتظار'
", WaitT);
            Wait.Text = WaitT.Rows[0]["WaitT"].ToString();

        }
    }
    
}
