using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long number1 = 0;
        long number2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                SResult.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                SResult.Text = number2.ToString();
            }
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                SResult.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                SResult.Text = number2.ToString();
            }
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                SResult.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                SResult.Text = number2.ToString();
            }
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                SResult.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                SResult.Text = number2.ToString();
            }
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                SResult.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                SResult.Text = number2.ToString();
            }
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                SResult.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                SResult.Text = number2.ToString();
            }
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                SResult.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                SResult.Text = number2.ToString();
            }
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                SResult.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                SResult.Text = number2.ToString();
            }
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                SResult.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                SResult.Text = number2.ToString();
            }
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                SResult.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                SResult.Text = number2.ToString();
            }
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            SResult.Text = "0";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            SResult.Text = "0";
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            SResult.Text = "0";
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            SResult.Text = "0";
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    SResult.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    SResult.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    SResult.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    SResult.Text = (number1 / number2).ToString();
                    break;
            }
        }

        private void deleteE_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }

            SResult.Text = "0";
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            SResult.Text = "0";
        }

        private void plusToMinus_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                SResult.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                SResult.Text = number2.ToString();
            }
        }
    }
}
