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
        Double result = 0;
        string operation_perform = "";
        bool isoperationperformed=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Click_button(object sender, EventArgs e)
        {
            if ((result_box.Text == "0") || (isoperationperformed))
            {
                result_box.Clear();
            }
            Button button = (Button)sender;
            result_box.Text = result_box.Text + button.Text;
            isoperationperformed=false ;
        }

        private void operation_click(object sender, EventArgs e)
        {
            if (result != 0)
            {
                button16.PerformClick();
                Button button = (Button)sender;
                operation_perform = button.Text;
                label_click_fun.Text = result + " " + operation_perform;
                isoperationperformed = true;
            }else
            {
                Button button = (Button)sender;
                operation_perform = button.Text;
                result = Double.Parse(result_box.Text);
                label_click_fun.Text = result + " " + operation_perform;
                isoperationperformed = true;
            }


        }

        private void button12_Click(object sender, EventArgs e)
        {
            result_box.Text = "0";
            result = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (operation_perform)
            {
                case "+":
                    result_box.Text = (result + Double.Parse(result_box.Text)).ToString();
                    break;

                case "-":
                    result_box.Text = (result - Double.Parse(result_box.Text)).ToString();
                    break;

                case "*":
                    result_box.Text = (result * Double.Parse(result_box.Text)).ToString();
                    break;

                case "/":
                    result_box.Text = (result / Double.Parse(result_box.Text)).ToString();
                    break;
                default:
                        break;

            }
            result = Double.Parse(result_box.Text);
            label_click_fun.Text = "";
        }
        private void result_box_TextChanged(object sender, EventArgs e)
        {

        }
        private void label_click(object sender, EventArgs e)
        {
            
        }
    }
}
