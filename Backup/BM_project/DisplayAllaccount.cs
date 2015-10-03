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
    public partial class DisplayAllaccount : Form
    {
        public DisplayAllaccount()
        {
            InitializeComponent();
        }

        private void DisplayAllaccount_Load(object sender, EventArgs e)
        {
            CustomerGateway gateway=new CustomerGateway();
            List<Customer> customers = gateway.GetaccountDetails();
            dataGridView1.DataSource = customers;
        }

        
    }
        

        //private dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }

