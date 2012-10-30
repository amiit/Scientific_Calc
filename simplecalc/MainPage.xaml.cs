using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace simplecalc
{
    public partial class MainPage : PhoneApplicationPage
    {
        public String no1, consfun;
        public bool inputstatus;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            no1 = "";
            radioButton1.IsChecked = true;
        }

      
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button1.Content;
            else
            {
                textBox1.Text = Convert.ToString(button1.Content);
                inputstatus = true;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button2.Content;
            else
            {
                textBox1.Text = Convert.ToString(button2.Content);
                inputstatus = true;
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            consfun = "+";
        }
        private void button14_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            consfun = "-";
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            consfun = "*";
        }
        private void button16_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            textBox1.Text = "";
            consfun = "/";
        }
        private void funcall()
        {
            switch (consfun)
            {
                case "+":
                    int n = textBox1.Text.Length;
                    if (n == 0)
                        return;
                    else
                    {
                        textBox1.Text = Convert.ToString(Convert.ToDouble(no1) + Convert.ToDouble(textBox1.Text));
                    }
                    break;
                case "-":
                    n = textBox1.Text.Length;
                    if (n == 0)
                        return;
                    else
                    {

                        textBox1.Text = Convert.ToString(Convert.ToDouble(no1) - Convert.ToDouble(textBox1.Text));

                    }
                    break;
                case "*":
                    n = textBox1.Text.Length;
                    if (n == 0)
                        return;
                    else
                    {
                        textBox1.Text = Convert.ToString(Convert.ToDouble(no1) * Convert.ToDouble(textBox1.Text));
                    }
                    break;
                case "/":

                    n = textBox1.Text.Length;
                    if (n == 0)
                        return;
                    else
                    {
                        if (textBox1.Text == "0")
                        {
                            textBox1.Text = "Infinity";
                        }
                        else
                        {
                            textBox1.Text = Convert.ToString(Convert.ToDouble(no1) / Convert.ToDouble(textBox1.Text));
                        }
                    }
                    break;
                case "MOD":
                    textBox1.Text = Convert.ToString(Convert.ToDouble(no1) % Convert.ToDouble(textBox1.Text));
                    break;
                case "x^y":
                    n = textBox1.Text.Length;
                    if (n == 0)
                        return;
                    else
                    {
                        textBox1.Text = Convert.ToString(System.Math.Pow(Convert.ToDouble(no1), Convert.ToDouble(textBox1.Text)));
                    }
                    break;
                case "nPr":
                    int var1, var2;
                    var1 = fact(Convert.ToInt32(no1));
                    var2 = fact(Convert.ToInt32(no1) - Convert.ToInt32(textBox1.Text));
                    textBox1.Text = Convert.ToString(var1 / var2);
                    break;
                case "nCr":
                    int var3, var4, var5;
                    var3 = fact(Convert.ToInt32(no1));
                    var4 = fact(Convert.ToInt32(no1) - Convert.ToInt32(textBox1.Text));
                    var5 = fact(Convert.ToInt32(textBox1.Text));
                    textBox1.Text = Convert.ToString(var3 / (var4 * var5));
                    break;

            }
        }
        private int fact(int x)
        {
            int i = 1;
            for (int s = 1; s <= x; s++)
            {
                i = i * s;
            }
            return i;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            funcall();
            inputstatus = false;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button7.Content;
            else
            {
                textBox1.Text = Convert.ToString(button7.Content);
                inputstatus = true;
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button5.Content;
            else
            {
                textBox1.Text = Convert.ToString(button5.Content);
                inputstatus = true;
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button6.Content;
            else
            {
                textBox1.Text = Convert.ToString(button6.Content);
                inputstatus = true;
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button8.Content;
            else
            {
                textBox1.Text = Convert.ToString(button8.Content);
                inputstatus = true;
            }

        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button9.Content;
            else
            {
                textBox1.Text = Convert.ToString(button9.Content);
                inputstatus = true;
            }
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button10.Content;
            else
            {
                textBox1.Text = Convert.ToString(button10.Content);
                inputstatus = true;
            }
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button11.Content;
            else
            {
                textBox1.Text = Convert.ToString(button11.Content);
                inputstatus = true;
            }
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button12.Content;
            else
            {
                textBox1.Text = Convert.ToString(button12.Content);
                inputstatus = true;
            }
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus == true)
                textBox1.Text += button13.Content;
            else
            {
                textBox1.Text = Convert.ToString(button13.Content);
                inputstatus = true;
            }
        }

        private void button17_Click(object sender, RoutedEventArgs e)
        {
            textBox1.IsEnabled = true;
            textBox1.Text = "0";
        }

        private void button18_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = string.Empty;
            inputstatus = true;
        }

        private void button19_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "3.141592654";
        }

        private void button20_Click(object sender, RoutedEventArgs e)
        {
            textBox1.IsEnabled = false;
            textBox1.Text = "";
            inputstatus = false;
        }

        private void button21_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else if (textBox1.Text == "Syntax Error")
                textBox1.Text = "";
            else
            {
                textBox1.Text = (no1.Substring(0, n - 1));
            }

        }

        private void button22_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else if (textBox1.Text == "Syntax Error")
                textBox1.Text = "";
            else
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(1.0 / Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
        }

        private void button23_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else if (textBox1.Text == "Syntax Error")
                textBox1.Text = "";
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Log(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
        }

        private void button24_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else if (textBox1.Text == "Syntax Error")
                textBox1.Text = "";
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Log10(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
        }

        private void button25_Click(object sender, RoutedEventArgs e)
        {
            int const1 = 1;
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else if (textBox1.Text == "Syntax Error")
                textBox1.Text = "";
            else
            {
                for (int i = 1; i <= Convert.ToDouble(textBox1.Text); i++)
                {
                    const1 = const1 * i;
                }
                textBox1.Text = Convert.ToString(const1);
                inputstatus = false;
            }
        }

        private void button27_Click(object sender, RoutedEventArgs e)
        {

            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else if (textBox1.Text == "Syntax Error")
                textBox1.Text = "";
            else
            {
                textBox1.Text = "";
                consfun = "MOD";
            }
        }

        private void button26_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else if (textBox1.Text == "Syntax Error")
                textBox1.Text = "";
            else
            {
                textBox1.Text = Convert.ToString(-Convert.ToInt32(textBox1.Text));
                inputstatus = false;
            }
        }

        private void button30_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else if (textBox1.Text == "Syntax Error")
                textBox1.Text = "";
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Sqrt(Convert.ToDouble(textBox1.Text)));
                inputstatus = false;
            }
        }

        private void button29_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else if (textBox1.Text == "Syntax Error")
                textBox1.Text = "";
            else
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text));
                inputstatus = false;
            }
        }

        private void button28_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else if (textBox1.Text == "")
                textBox1.Text = "";
            else if (textBox1.Text == "Syntax Error")
                textBox1.Text = "";
            else
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text));
                inputstatus = false;
            }
        }

        private void button31_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else if (textBox1.Text == "Syntax Error")
                textBox1.Text = "";
            else
            {
                textBox1.Text = "";
                consfun = "x^y";
            }
        }

        private void button32_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else if (textBox1.Text == "Syntax Error") 
                textBox1.Text = "";
            else
            {
                textBox1.Text = "";
                consfun = "nPr";
            }
        }

        private void button33_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else if (textBox1.Text == "Syntax Error")
                textBox1.Text = "";
            else
            {
                textBox1.Text = "";
                consfun = "nCr";
            }
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void button34_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else if (textBox1.Text == "Syntax Error")
                textBox1.Text = "";
            else
            {
                //if degree is selected
                if (radioButton1.IsChecked == true)
                {
                    textBox1.Text = Convert.ToString(Math.Sin((Convert.ToDouble((Math.PI) / 180)) * (Convert.ToDouble(textBox1.Text))));
                    inputstatus = false;
                }
                else
                {
                    textBox1.Text = Convert.ToString(Math.Sin(Convert.ToDouble(textBox1.Text)));
                    inputstatus = false;
                }
            }
        }

        private void button35_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else if (textBox1.Text == "Syntax Error")
                textBox1.Text = "";
            else
            {
                //if degree is selected
                if (radioButton1.IsChecked == true)
                {
                    textBox1.Text = Convert.ToString(Math.Cos((Convert.ToDouble((Math.PI) / 180)) * (Convert.ToDouble(textBox1.Text))));
                    inputstatus = false;
                }
                else
                {
                    textBox1.Text = Convert.ToString(Math.Cos(Convert.ToDouble(textBox1.Text)));
                    inputstatus = false;
                }
            }
        }

        private void button36_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else if (textBox1.Text == "Syntax Error")
                textBox1.Text = "";
            else
            {
                // if degree is selected
                if (radioButton1.IsChecked == true)
                {
                    textBox1.Text = Convert.ToString(Math.Tan((Convert.ToDouble((Math.PI) / 180)) * (Convert.ToDouble(textBox1.Text))));
                    inputstatus = false;
                }
                else
                {
                    textBox1.Text = Convert.ToString(Math.Tan(Convert.ToDouble(textBox1.Text)));
                    inputstatus = false;
                }
            }
        }

        private void button37_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else if (textBox1.Text == "Syntax Error")
                textBox1.Text = "";
            else
            {
                // if degree is selected
                if (radioButton1.IsChecked == true)
                {
                    textBox1.Text = Convert.ToString(Math.Asin((Convert.ToDouble((Math.PI) / 180)) * (Convert.ToDouble(textBox1.Text))));
                    inputstatus = false;
                }
                else
                {
                    textBox1.Text = Convert.ToString(Math.Asin(Convert.ToDouble(textBox1.Text)));
                    inputstatus = false;
                }
            }
        }

        private void button38_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else if (textBox1.Text == "Syntax Error")
                textBox1.Text = "";
            else
            {
                //if degree is selected
                if (radioButton1.IsChecked == true)
                {
                    textBox1.Text = Convert.ToString(Math.Acos((Convert.ToDouble((Math.PI) / 180)) * (Convert.ToDouble(textBox1.Text))));
                    inputstatus = false;
                }
                else
                {
                    textBox1.Text = Convert.ToString(Math.Acos(Convert.ToDouble(textBox1.Text)));
                    inputstatus = false;
                }
            }
        }

        private void button39_Click(object sender, RoutedEventArgs e)
        {
            no1 = textBox1.Text;
            int n = no1.Length;
            if (n == 0)
                textBox1.Text = "Syntax Error";
            else if (textBox1.Text == "Syntax Error")
                textBox1.Text = "";
            else
            {
                //if degree is selected
                if (radioButton1.IsChecked == true)
                {
                    textBox1.Text = Convert.ToString(Math.Atan((Convert.ToDouble((Math.PI) / 180)) * (Convert.ToDouble(textBox1.Text))));
                    inputstatus = false;
                }
                else
                {
                    textBox1.Text = Convert.ToString(Math.Atan(Convert.ToDouble(textBox1.Text)));
                    inputstatus = false;
                }
            }

        }

    }
}