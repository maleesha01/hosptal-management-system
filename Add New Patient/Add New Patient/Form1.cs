using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Add_New_Patient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String patientId = textBox1.Text;
            String name = textBox2.Text;
            String address = textBox4.Text;
            int age = Convert.ToInt32(textBox3.Text);
            String gender = comboBox1.Text;
        }
    }
}
