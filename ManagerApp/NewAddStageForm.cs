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
    public partial class NewAddStageForm : Form
    {
        public NewAddStageForm()
        {
            InitializeComponent();
        }
        private void Back_Button_Click(object sender, EventArgs e)
        {
            FindControl fc = new FindControl();
            NewHomePageForm NHPF = new NewHomePageForm();
            NewHomeForm F = new NewHomeForm();
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Clear();
            NHPF.TopLevel = false;
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "MainMPanel")).Controls.Add(NHPF);
            ((Panel)fc.Ctrl(fc.TheForm("NewHomeForm"), "Student_Panel")).Show();
            NHPF.BringToFront();
            NHPF.Show();
        }
        private void NewAddStageForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
