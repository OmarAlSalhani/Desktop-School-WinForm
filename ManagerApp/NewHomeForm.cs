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
    public partial class NewHomeForm : Form
    {
        public NewHomeForm()
        {
            InitializeComponent();
        }
        public void KeepSize()
        {
            Top = Left = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void NewHomeForm_Load(object sender, EventArgs e)
        {
            ConnectionClass.Connect();
                NewHomePageForm NHPF = new NewHomePageForm();
                KeepSize();
                NHPF.TopLevel = false;
                Student_Panel.Show();
                MainMPanel.Controls.Add(NHPF);
                NHPF.BringToFront();
                NHPF.Show();
            
        }
        public void NewHomeForm_SizeChanged(object sender, EventArgs e)
        {
            Top = Left = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            foreach (Form i in MainMPanel.Controls)
            {
                i.Width = MainMPanel.Width;
                i.Height = MainMPanel.Height;
            }

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            NewSettingsForm NSF = new NewSettingsForm();
            MainMPanel.Controls.Clear();
            NSF.TopLevel = false;
            MainMPanel.Controls.Add(NSF);
            Student_Panel.Hide();
            NSF.BringToFront();
            NSF.Show();
            NewHomeForm_SizeChanged(sender, e);
        }

        private void AddStageButton_Click(object sender, EventArgs e)
        {
            NewAddStageForm NASF = new NewAddStageForm();
            MainMPanel.Controls.Clear();
            NASF.TopLevel = false;
            MainMPanel.Controls.Add(NASF);
            Student_Panel.Hide();
            NASF.BringToFront();
            NASF.Show();
            NewHomeForm_SizeChanged(sender, e);
        }

        private void HomePageButton_Click(object sender, EventArgs e)
        {
            NewHomePageForm NHPF = new NewHomePageForm();
            MainMPanel.Controls.Clear();
            NHPF.TopLevel = false;
            MainMPanel.Controls.Add(NHPF);
            Student_Panel.Show();
            NHPF.BringToFront();
            NHPF.Show();
            NewHomeForm_SizeChanged(sender, e);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            NewAddStudentForm NSF = new NewAddStudentForm();
            MainMPanel.Controls.Clear();
            NSF.TopLevel = false;
            MainMPanel.Controls.Add(NSF);
            Student_Panel.Hide();
            NSF.BringToFront();
            NSF.Show();
            NewHomeForm_SizeChanged(sender, e);
        }
       
    }
}
