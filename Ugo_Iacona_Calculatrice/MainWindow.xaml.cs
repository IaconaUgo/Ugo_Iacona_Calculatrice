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
using System.Xml.Linq;

namespace Ugo_Iacona_Calculatrice
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int first_num;
        int second_num;
        int result; 
        char operation;

        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            display("1");
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            display("2");
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            display("3");
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            display("4");
        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            display("5");
        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            display("6");
        }

        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            display("7");
        }

        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            display("8");
        }

        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            display("9");
        }

        private void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            display("0");
        }

        private void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {
            first_num = Int32.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '+';
        }
    

        private void BTN_Moins_Click(object sender, RoutedEventArgs e)
        {
            first_num = Int32.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '-';
        }

        private void BTN_Multi_Click(object sender, RoutedEventArgs e)
        {
            first_num = Int32.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '*';
        }

        private void BTN_Div_Click(object sender, RoutedEventArgs e)
        {
            first_num = Int32.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '/';
        }
        private void BTN_Cos_Click(object sender, RoutedEventArgs e)
        {
            first_num = Int32.Parse(TB_Display.Text);
            TB_Display.Text = "Cos";
            operation = 'C';
        }
        private void BTN_Sin_Click(object sender, RoutedEventArgs e)
        {
            first_num = Int32.Parse(TB_Display.Text);
            TB_Display.Text = "Sin";
            operation = 'S';
        }
            private void BTN_Tan_Click(object sender, RoutedEventArgs e)
        {
            first_num = Int32.Parse(TB_Display.Text);
            TB_Display.Text = "TAN";
            operation = 'T';
        }
        private void BTN_Racinecaree_Click(object sender, RoutedEventArgs e)
        {
            first_num = Int32.Parse(TB_Display.Text);
            TB_Display.Text = "√";
            operation = 'R';
        }

        private void BTN_result_Click(object sender, RoutedEventArgs e)
        {
            second_num = Int32.Parse(TB_Display.Text);
            switch (operation)
            {
                case '+':
                    result = first_num + second_num;
                    TB_Display.Text = result.ToString();
                    break;

                case '-':
                    result = first_num - second_num;
                    TB_Display.Text = result.ToString();
                    break;

                case '*':
                    result = first_num * second_num;
                    TB_Display.Text = result.ToString();
                    break;

                case '/':
                    result = first_num / second_num;
                    TB_Display.Text = result.ToString();
                    break;

                case 'C':
                    result = first_num - second_num;
                    TB_Display.Text = result.ToString();
                    break;

                case 'S':
                    result = first_num - second_num;
                    TB_Display.Text = result.ToString();
                    break;

                case 'T':
                    result = first_num - second_num;
                    TB_Display.Text = result.ToString();
                    break;

                case 'R':
                    result = first_num - second_num;
                    TB_Display.Text = result.ToString();
                    break;
            }
        }

        private void BTN_clear_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = "0";
        }

        public void display(string num)
        {
            if (TB_Display.Text == "0")
            {
                TB_Display.Text = num;
            }
            else
            {
                TB_Display.Text = TB_Display.Text + num;
            }
        }

       
    }

}
