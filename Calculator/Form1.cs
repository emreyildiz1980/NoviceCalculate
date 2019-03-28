using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string zero="0",one = "1", two = "2", three = "3", four = "4", five = "5", six = "6", seven = "7", eight = "8",
            nine = "9",  minus = "-", add="+",multiple="*", divide = "/";
        char token;

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(add);
            token = '+';
            CancelButtons();
            button12.Enabled = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(multiple);
            token = '*';
            CancelButtons();
            button12.Enabled = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(divide);
            token = '/';
            CancelButtons();
            button12.Enabled = true;
        }

        decimal result = 0; 

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            EnableButtons();
            token = '=';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(minus);
            CancelButtons();
            token ='-';
        }

        private void button12_Click(object sender, EventArgs e)
        {
           string[] numbers= textBox1.Text.Split(token);
            try
            {
                switch (token)
                {
                    case '+':
                        result = Convert.ToDecimal(numbers[0]) + Convert.ToDecimal(numbers[1]);
                        break;
                    case '-':
                        result = Convert.ToDecimal(numbers[0]) - Convert.ToDecimal(numbers[1]);
                        break;
                    case '*':
                        result = Convert.ToDecimal(numbers[0]) * Convert.ToDecimal(numbers[1]);
                        break;
                    case '/':
                        try
                        {
                            result = Convert.ToDecimal(numbers[0]) / Convert.ToDecimal(numbers[1]);
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("0 ile bölünemez !");
                            button16.PerformClick();
                        }
                        break;
                    default:
                        break;
            }
            textBox2.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlış Format !");
            }
          
        }

        private void button10_Click(object sender, EventArgs e)
        {

            textBox1.AppendText(zero);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(nine);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            textBox1.AppendText(eight);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            textBox1.AppendText(seven);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            textBox1.AppendText(six);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            textBox1.AppendText(five);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox1.AppendText(four);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(three);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(two);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";
            button10.Text = "0";
            button11.Text = "-";
            button12.Text = "=";
            button13.Text = "+";
            button14.Text = "*";
            button15.Text = "/";
            button16.Text = "Clear";
            label2.Text = "=";
            label1.Text = "SONUC";
            button12.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(one);
        }

        void CancelButtons()
        {
            button11.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button12.Enabled = true;
        }
         void EnableButtons()
        {
            button11.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button12.Enabled = false;
        }
    }

}
