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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        DataTable tab = new DataTable();
        private void Form4_Load(object sender, EventArgs e)
        {
            tab.Columns.Add("Roll Number", typeof(int));
            tab.Columns.Add("Capacity", typeof(int));
            dataGridView1.DataSource = tab;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tab.Rows.Add(textBox1.Text, textBox2.Text);
            dataGridView1.DataSource = tab;
        }
    }
}
