using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator.ViewModel
{
    public partial class CResult : ObservableObject
    {
        long number1 = 0;
        long number2 = 0;
        string operation = "";


        [ObservableProperty]
        string sResult = "";

        [RelayCommand]
        private void zero_Pressed()
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                SResult = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                SResult = number2.ToString();
            }
        }

        [RelayCommand]
        private void one_Pressed()
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                SResult = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                SResult = number2.ToString();
            }
        }

        [RelayCommand]
        private void two_Pressed()
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                SResult = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                SResult = number2.ToString();
            }
        }

        [RelayCommand]
        private void three_Pressed()
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                SResult = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                SResult = number2.ToString();
            }
        }

        [RelayCommand]
        private void four_Pressed()
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                SResult = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                SResult = number2.ToString();
            }
        }

        [RelayCommand]
        private void five_Pressed()
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                SResult = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                SResult = number2.ToString();
            }
        }

        [RelayCommand]
        private void six_Pressed()
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                SResult = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                SResult = number2.ToString();
            }
        }

        [RelayCommand]
        private void seven_Pressed()
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                SResult = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                SResult = number2.ToString();
            }
        }

        [RelayCommand]
        private void eight_Pressed()
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                SResult = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                SResult = number2.ToString();
            }
        }

        [RelayCommand]
        private void nine_Pressed()
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                SResult = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                SResult = number2.ToString();
            }
        }

        [RelayCommand]
        private void plus_Pressed()
        {
            operation = "+";
            SResult = "0";
        }

        [RelayCommand]
        private void minus_Pressed()
        {
            operation = "-";
            SResult = "0";
        }

        [RelayCommand]
        private void multiply_Pressed()
        {
            operation = "*";
            SResult = "0";
        }

        [RelayCommand]
        private void divide_Pressed()
        {
            operation = "/";
            SResult = "0";
        }

        [RelayCommand]
        private void equals_Pressed()
        {
            switch (operation)
            {
                case "+":
                    SResult = (number1 + number2).ToString();
                    break;
                case "-":
                    SResult = (number1 - number2).ToString();
                    break;
                case "*":
                    SResult = (number1 * number2).ToString();
                    break;
                case "/":
                    SResult = (number1 / number2).ToString();
                    break;
            }
        }

        [RelayCommand]
        private void deleteE_Pressed()
        {
            if (operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }

            SResult = "0";
        }

        [RelayCommand]
        private void delete_Pressed()
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            SResult = "0";
        }

        [RelayCommand]
        private void plusAndMinus_Pressed()
        {
            if (operation == "")
            {
                number1 *= -1;
                SResult = number1.ToString();
            }
            else
            {
                number2 *= -1;
                SResult = number2.ToString();
            }
        }
    }
}