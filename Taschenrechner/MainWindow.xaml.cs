﻿using System;
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

namespace Taschenrechner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int aktuellerWert = 0;
        int lastresult = 0;
        bool numberinputrunning = true;
        char lastoperation = '+';

        public MainWindow()
        {
            InitializeComponent();
        }
        private void appendnumber(int z)
        {
            if (!numberinputrunning)
            {
                aktuellerWert = z;
                numberinputrunning = true;
                textBlockAusgabe.Text = aktuellerWert.ToString();
            }
            else
            {
                aktuellerWert = aktuellerWert * 10 + z;
                textBlockAusgabe.Text = aktuellerWert.ToString();
            }
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            appendnumber(7);
        }       
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            appendnumber(8);
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            appendnumber(9);
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            appendnumber(4);
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            appendnumber(5);
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            appendnumber(6);
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            appendnumber(1);
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            appendnumber(2);
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            appendnumber(3);
        }
        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            appendnumber(0);
        }
        private void calculate(char mathoperation)
        {
            switch (lastoperation)
            {
                case '+':
                    lastresult = lastresult + aktuellerWert;
                    break;
                case '-':
                    lastresult = lastresult - aktuellerWert;
                    break;
                case '*':
                    lastresult = lastresult * aktuellerWert;
                    break;
                case '/':
                    lastresult = lastresult / aktuellerWert;
                    break;
                case '=':
                    break;
            }
            textBlockAusgabe.Text = lastresult.ToString();
            numberinputrunning = false;
            lastoperation = mathoperation;
        }
        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            calculate('+');
        }

       

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            calculate('-');
        }

        private void ButtonMal_Click(object sender, RoutedEventArgs e)
        {
            calculate('*');
        }

        private void ButtonGeteilt_Click(object sender, RoutedEventArgs e)
        {
            calculate('/');
        }

        private void ButtonGleich_Click(object sender, RoutedEventArgs e)
        {
            calculate('=');
        }
    }
}
