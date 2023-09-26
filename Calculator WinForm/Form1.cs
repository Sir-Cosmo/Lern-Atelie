using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WinForm
{
    public partial class Form1 : Form

    {
        string option;
        int number1;
        int number2;
        int result;
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "1";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_numbers_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "2";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtTotal.Text += btn.Text;
        }

        private void nummern_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtTotal.Text += btn.Text;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtTotal.Text += btn.Text;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtTotal.Text += btn.Text;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtTotal.Text += btn.Text;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtTotal.Text += btn.Text;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtTotal.Text += btn.Text;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtTotal.Text += btn.Text;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtTotal.Text += btn.Text;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            txtTotal.Text = "";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            option = "+";
            number1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            number2= int.Parse(txtTotal.Text);
           
            if (option.Equals("+"))
                result = number1 + number2;

            if (option.Equals("-"))
                result = number1 - number2;

            if (option.Equals("*"))
                result = number1 * number2;

            txtTotal.Clear();
            txtTotal.Text += result;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            option = "-";
            number1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void mal_btn_Click(object sender, EventArgs e)
        {
            option = "*";
            number1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }
    }
}
