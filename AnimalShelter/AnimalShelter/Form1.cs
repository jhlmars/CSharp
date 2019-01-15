using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        /* 기존의 Customer 배열을 List로 수정 */
        public List<Customer> Customers = new List<Customer>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer(CusNewFirstName.Text, CusNewLastName.Text,
                DateTime.Parse(CusNewBirthday.Text));
            cus.Address = CusNewAddress.Text;
            cus.Description = CusNewDescription.Text;

            CustomerList.Items.Add(cus.FirstName);
            Customers.Add(cus);
        }

        private void CustomerList_Click(object sender, EventArgs e)
        {
            string firstName = CustomerList.SelectedItem.ToString();
            
            foreach(Customer cus in Customers)
            {
                if(cus.FirstName == firstName)
                {
                    ShowDetails(cus);
                    break;
                }
            }
        }

        public void ShowDetails(Customer cus)
        {
            CusFulltName.Text = cus.FullName;
            CusAddress.Text = cus.Address;
            CusAge.Text = cus.Age.ToString();
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQualified.ToString();
        }
    }
}
