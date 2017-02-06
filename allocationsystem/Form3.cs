using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace allocationsystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Designation", typeof(string));
            dt.Columns.Add("Department", typeof(string));
            dt.Columns.Add("Threshold", typeof(int));
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(IDBox.Text,NameBox.Text,Designation.Text,DeptCombo.Text,ThresholdBox.Text);
           dataGridView1.DataSource = dt;
           IDBox.Text = String.Empty;
           ThresholdBox.Text = String.Empty;
           Designation.Text = String.Empty;
           NameBox.Text = String.Empty;
           DeptCombo.Text = String.Empty;
        }

        
    }
}
