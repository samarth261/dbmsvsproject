using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace allocationsystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String Semester;
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.Date.ToShortDateString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
            button5.Visible = false;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker2.Value.Date.ToShortDateString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button6.Visible = true;
            dateTimePicker2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Visible = false;
            button6.Visible = false;
        }
        DataTable table = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Start Date", typeof(string));
            table.Columns.Add("End Date", typeof(string));
            table.Columns.Add("Academic Semester", typeof(string));
            dataGridView2.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text, textBox2.Text, Semester);
            dataGridView2.DataSource = table;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Semester = "Even";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Semester = "Odd";
        }

       

       

  

       

        
       

       
    }
}
