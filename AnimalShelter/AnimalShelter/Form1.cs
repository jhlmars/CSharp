using System;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        Customer[] CustomerArray = new Customer[10];
        public int CustomerArrayIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            CustomerArray[CustomerArrayIndex] = new Customer(CusNewFirstName.Text, CusNewLastName.Text,
                DateTime.Parse(CusNewBirthday.Text));
            CustomerArray[CustomerArrayIndex].Address = CusNewAddress.Text;
            CustomerArray[CustomerArrayIndex].Description = CusNewDescription.Text;

            CustomerList.Items.Add(CustomerArray[CustomerArrayIndex].FirstName);
            CustomerArrayIndex++;
        }

        private void CustomerList_Click(object sender, EventArgs e)
        {
            string firstName = CustomerList.SelectedItem.ToString();
            
            for(int index = 0; index < CustomerArrayIndex; index++)
            {
                if(CustomerArray[index].FirstName == firstName)
                {
                    ShowDetails(CustomerArray[index]);
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
