using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Flight Information : " + comboBox1.Text + " " + comboBox2.Text + " " + dateTimePicker1.Text + "Passenger Information : " + textBox1.Text + " " + maskedTextBox1.Text + " " + maskedTextBox2.Text);
            MessageBox.Show("Registration Succesful");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label7.Text;
        }
    }
}
