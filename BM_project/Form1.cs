using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BM_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "waliul" && txtPassword.Text == "cse"))
            {
                this.Hide();
                Form2 sf = new Form2();
                sf.Show();

            }
            else if (txtUsername.Text != "waliul" || txtPassword.Text != "cse")
            {
                lblInfo.Text = "Invalid UserName or Password ";
            }
            
            
        }
    }
}
