using System;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            DateTime bdate = new DateTime(2000, 1, 1);
            Customer cus = new Customer("Ian","Na",bdate);
            cus.Address = "123 Sejong-Ro Yeoju";
            cus.Description = "Create Name and etc";

            CusFulltName.Text = cus.FullName;
            CusAddress.Text = cus.Address;
            CusAge.Text = cus.Age.ToString();
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQualified.ToString();
        }
    }
}
