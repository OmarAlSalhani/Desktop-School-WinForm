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
    public partial class Mra7elT3lemeeForm : Form
    {
        public Mra7elT3lemeeForm()
        {
            InitializeComponent();
        }

        private void Mra7elT3lemeeForm_Load(object sender, EventArgs e)
        {

            DataTable T = new DataTable();
            string a = @"Select
ر,
المرحلة,
عدد_الحلقات,
مادة1,
مادة2,
مادة3,
سنة_دراسية
From Mra7elT3lemee";
            ConnectionClass.Select(a, T);
            gunaDataGridView1.DataSource = T;
        }
    }
}
