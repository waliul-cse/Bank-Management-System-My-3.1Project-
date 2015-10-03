using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BM_project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.accountno = accnoTextBox.Text;
            customer.name = nameTextBox.Text;
            customer.address = addressTextBox.Text;
            customer.phonenumber = phnoTextBox.Text;
            customer.sex = sexTextBox.Text;
            customer.occupation = occupationTextBox.Text;
            customer.annualincome = annincomeTextBox.Text;
            customer.accountstatement = accstateTextBox.Text;
            CustomerGateway gateway=new CustomerGateway();
            int i = CustomerGateway.Save(customer);
        }


        /*string message =
              string.Format(
                  "accountno{0}name{1}address{2}phonenumber{3}sex{4}occupation{5}annualincome{6}accountstatement{7}",
                 customer.accountno, customer.name, customer.address, customer.phonenumber, customer.sex, customer.occupation, customer.annualincome, customer.accountstatement);
            */

       


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
