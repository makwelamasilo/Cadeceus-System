using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Clerk : Form
    {
        public Clerk()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to exit the program", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            monthCalendar1.Enabled = true;
            textBox1.Enabled = true;
            label2.Enabled = true;
            button3.Enabled = true;

            groupBox2.Enabled = false;
            button5.Enabled = false;
            label3.Enabled = false;
            textBox2.Enabled = false;

            groupBox3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            textBox3.Enabled = false;
            dateTimePicker1.Enabled = false;
            button8.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            button5.Enabled = true;
            label3.Enabled = true;
            textBox2.Enabled = true;

            groupBox3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            textBox3.Enabled = false;
            dateTimePicker1.Enabled = false;
            button8.Enabled = false;

            groupBox1.Enabled = false;
            monthCalendar1.Enabled = false;
            textBox1.Enabled = false;
            label2.Enabled = false;
            button3.Enabled = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            textBox3.Enabled = true;
            dateTimePicker1.Enabled = true;
            button8.Enabled = true;

            groupBox1.Enabled = false;
            monthCalendar1.Enabled = false;
            textBox1.Enabled = false;
            label2.Enabled = false;
            button3.Enabled = false;

            groupBox2.Enabled = false;
            button5.Enabled = false;
            label3.Enabled = false;
            textBox2.Enabled = false;

        }
    }
}
