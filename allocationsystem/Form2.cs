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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            monthCalendar1.Visible = true;
            button4.Visible = true;
           
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.Date.ToShortDateString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button4.Visible = false;
            monthCalendar1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
