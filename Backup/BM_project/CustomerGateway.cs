using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BM_project
{
    public class CustomerGateway
    {
       string connectionString = @"Server=WALIUL-PC;Database=Databank;user id=sa;password=cse;";
        static SqlConnection  connection;
          
       public CustomerGateway()
       {
       connection = new SqlConnection(connectionString);
    }

    public static int Save(Customer customer)
    {
        connection.Open();
    string inserQuery =string.Format("Insert into Acc_Table values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", customer.accountno,
        customer.name, customer.address, customer.phonenumber, customer.sex, customer.occupation, customer.annualincome, customer.accountstatement);
            SqlCommand command = new SqlCommand(inserQuery, connection);
            int i = command.ExecuteNonQuery();
            MessageBox.Show("Account has been created successfully");
            connection.Close();
            return i;

        }


        public List<Customer> GetaccountDetails()
        {
            connection.Open();
            string selectQuery = "select* from Acc_table";
            SqlCommand command = new SqlCommand(selectQuery, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Customer> customers = new List<Customer>();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer.accountno = reader[0].ToString();
                customer.name = reader[1].ToString();
                customer.address = reader[2].ToString();
                customer.phonenumber = reader[3].ToString();
                customer.sex = reader[4].ToString();
                customer.occupation = reader[5].ToString();
                customer.annualincome = reader[6].ToString();
                customer.accountstatement = reader[7].ToString();
                customers.Add(customer);
            }
            connection.Close();
            return customers;

        }
    }
}
