using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWin
{
    public partial class Calculator : Form
    {
        public int Result = 0;
        public bool isNewNum = true;

        public Calculator()
        {
            InitializeComponent();
        }

        public int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public float Add(float num1, float num2)
        {
            float sum = num1 + num2;
            return sum;
        }

        public int Substract(int num1, int num2)
        {
            int sub = num1 - num2;
            return sub;
        }

        private void NumBtn1_Click(object sender, EventArgs e)
        {
            SetNum("1");
        }
        private void NumBtn2_Click(object sender, EventArgs e)
        {
            SetNum("2");
        }
        public void SetNum(string num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else
            {
                if (NumScreen.Text == "0")
                {
                    NumScreen.Text = num;
                }
                else
                {
                    NumScreen.Text = NumScreen.Text + num;
                }
            }
        }
        private void NumPlus_Click(object sender, EventArgs e)
        {
            int num = int.Parse(NumScreen.Text);
            Result = Result + num;

            NumScreen.Text = Result.ToString();
            isNewNum = true;
        }        
    }
}
