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
    public partial class Mar7elT3lemee_YatemFaqerForm : Form
    {
        public Mar7elT3lemee_YatemFaqerForm()
        {
            InitializeComponent();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Mar7elT3lemee_YatemFaqerForm_Load(object sender, EventArgs e)
        {
            DataTable T = new DataTable();
            string a = @"Select
ر,
اسم,
حالة,
رقم,
عنوان,
تاريخ
From Mra7elYatemFaqer";
            ConnectionClass.Select(a, T);
            gunaDataGridView1.DataSource = T;
        }
    }
}
