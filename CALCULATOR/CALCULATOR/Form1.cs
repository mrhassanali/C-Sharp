using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1, number2, sum;
            number1 = double.Parse(textBox1.Text);
            number2 = double.Parse(textBox2.Text);
            sum = number1 + number2;
            result.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double number3, number4, Subtraction;
            number3 = double.Parse(textBox1.Text);
            number4 = double.Parse(textBox2.Text);
            Subtraction = number3 - number4;
            result.Text = Subtraction.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double number5, number6, Multiplication;
            number5 = double.Parse(textBox1.Text);
            number6 = double.Parse(textBox2.Text);
            Multiplication = number5 * number6;
            result.Text = Multiplication.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double number7, number8, Division;
            number7 = double.Parse(textBox1.Text);
            number8 = double.Parse(textBox2.Text);
            Division = number7 / number8;
            result.Text = Division.ToString();
        }
    }
}
