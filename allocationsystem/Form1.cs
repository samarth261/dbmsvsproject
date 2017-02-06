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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

       

  

       

        
       

       
    }
}
