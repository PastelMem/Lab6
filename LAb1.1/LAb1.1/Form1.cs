using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAb1._1
{
    public partial class Form1 : Form
    {
        private object textBoxInput;
        string operation;
        string num1_str;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //float floating = 10.0f;

        private void label3_Click(object sender, EventArgs e)
        {



        }

        private void button28_Click(object sender, EventArgs e)
        {
            //add
            textBox.Text = "IS KKU";


        }

        private void button27_Click(object sender, EventArgs e)
        {
            //clear
            textBox.Text = string.Empty;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textbox
            string num1 = textBox.Text;




        }

        private void button22_Click(object sender, EventArgs e)
        {
            //result
            string num2_str = textBox.Text;
            int Num1 = int.Parse(num1_str), Num2 = int.Parse(num2_str);

            if (operation == "+")
            {

                textBox.Text = String.Format("{0}", Num1 + Num2);
            }
            else if (operation == "-")
            {
                textBox.Text = String.Format("{0}", Num1 - Num2);
            }
            else if (operation == "*")
            {
                textBox.Text = String.Format("{0}", Num1 * Num2);
            }
            else
            {
                textBox.Text = String.Format("{0:0.0}", Num1 / Num2);
            }


        }

        private void button23_Click(object sender, EventArgs e)
        {
            //plus
            num1_str = textBox.Text;
            textBox.Text = string.Empty;
            operation = "+";


        }

        private void button24_Click(object sender, EventArgs e)
        {
            num1_str = textBox.Text;
            textBox.Text = string.Empty;
            operation = "-";


            //minus
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //multiply
            num1_str = textBox.Text;
            textBox.Text = string.Empty;
            operation = "*";


        }

        private void button26_Click(object sender, EventArgs e)
        {
            //devide
            num1_str = textBox.Text;
            textBox.Text = string.Empty;
            operation = "/";


        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox.Text = "1";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox.Text = "2";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox.Text = "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox.Text = "4";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox.Text = "5";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox.Text = "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text = "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox.Text = "9";
        }
    }
}
