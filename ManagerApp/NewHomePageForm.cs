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
    public partial class NewHomePageForm : Form
    {
        public NewHomePageForm()
        {
            InitializeComponent();
        }
        private void gunaAdvenceTileButton10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        FindControl fc = new FindControl();
        private void gunaAdvenceTileButton5_Click(object sender, EventArgs e)
        {
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Remove(this);
            NewStudentsTqarerForm NSSF = new NewStudentsTqarerForm();
            NSSF.TopLevel = false;
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Add(NSSF);
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "StudentPanel")).Show();
            NSSF.Show();
            NSSF.BringToFront();
        }
        private void NewHomePageForm_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
            timer1.Enabled = true;
            timer1.Interval = 1000;
            WindowState = FormWindowState.Maximized;
            DayLabel.Text = "اليوم : " + DateTime.Now.DayOfWeek;
            DateLabel.Text = "التاريخ : " + DateTime.Now.ToShortDateString();
        }

        private void Check_in_Btn_Click(object sender, EventArgs e)
        {
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Clear();
            NewCheckForm NCF = new NewCheckForm();
            NCF.TopLevel = false;
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Add(NCF);
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "Student_Panel")).Hide();
            NCF.Show();
            NCF.BringToFront();
        }

        private void StudentPayment_Btn_Click(object sender, EventArgs e)
        {
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Clear();
            NewStudentsPaymentForm SPF = new NewStudentsPaymentForm();
            SPF.TopLevel = false;
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Add(SPF);
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "Student_Panel")).Hide();
            SPF.Show();
            SPF.BringToFront();
        }

        private void IncomOutcomBtn_Click(object sender, EventArgs e)
        {
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Clear();
            NewIncomOutcomForm SPF = new NewIncomOutcomForm();
            SPF.TopLevel = false;
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Add(SPF);
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "Student_Panel")).Hide();
            SPF.Show();
            SPF.BringToFront();
        }

        private void gunaAdvenceTileButton7_Click(object sender, EventArgs e)
        {
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Clear();
            Mra7elT3lemeeForm SPF = new Mra7elT3lemeeForm();
            SPF.TopLevel = false;
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Add(SPF);
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "StudentPanel")).Show();
            SPF.Show();
            SPF.BringToFront();
        }

        private void gunaAdvenceTileButton6_Click(object sender, EventArgs e)
        {
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Clear();
            NewTeacherTaqrerForm SPF = new NewTeacherTaqrerForm();
            SPF.TopLevel = false;
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Add(SPF);
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "Student_Panel")).Hide();
            SPF.Show();
            SPF.BringToFront();
        }

        private void orphansButtons_Click(object sender, EventArgs e)
        {
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Clear();
            Mar7elT3lemee_YatemFaqerForm SPF = new Mar7elT3lemee_YatemFaqerForm();
            SPF.TopLevel = false;
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Add(SPF);
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "Student_Panel")).Hide();
            SPF.Show();
            SPF.BringToFront();
        }

        private void gunaAdvenceTileButton8_Click(object sender, EventArgs e)
        {
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Clear();
            NewExamForm SPF = new NewExamForm();
            SPF.TopLevel = false;
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Add(SPF);
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "Student_Panel")).Show();
            SPF.Show();
            SPF.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = "الوقت : "+DateTime.Now.ToShortTimeString();
        }
    }
}
