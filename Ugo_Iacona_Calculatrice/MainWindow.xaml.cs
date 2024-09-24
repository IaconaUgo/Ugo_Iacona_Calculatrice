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
        double first_num;
        double second_num;
        double result; 
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
            first_num = double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '+';
        }
    

        private void BTN_Moins_Click(object sender, RoutedEventArgs e)
        {
            first_num = double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '-';
        }

        private void BTN_Multi_Click(object sender, RoutedEventArgs e)
        {
            first_num = double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '*';
        }

        private void BTN_Div_Click(object sender, RoutedEventArgs e)
        {
            first_num = double.Parse(TB_Display.Text);
            TB_Display.Text = "0";
            operation = '/';
        }
        private void BTN_Cos_Click(object sender, RoutedEventArgs e)
        {
            first_num = double.Parse(TB_Display.Text);

            result = Math.Cos(first_num);

            TB_Display.Text = result.ToString();
         
        }
        private void BTN_Sin_Click(object sender, RoutedEventArgs e)
        {
            first_num = double.Parse(TB_Display.Text);

            result = Math.Sin(first_num);
            TB_Display.Text = result.ToString();
            
        }
            private void BTN_Tan_Click(object sender, RoutedEventArgs e)
        {
            first_num = double.Parse(TB_Display.Text);// premier numero pris en compte par la variable double 

            result = Math.Tan(first_num); //le resultat du premier numeros pris en compte par la fonction Tan
            TB_Display.Text = result.ToString();//ecrire le resultat en caractères 
        }
        private void BTN_Racinecaree_Click(object sender, RoutedEventArgs e)
        {
            first_num = double.Parse(TB_Display.Text);
            TB_Display.Text = "√";
            operation = 'R';
        }

        private void BTN_result_Click(object sender, RoutedEventArgs e)
        {
            second_num = double.Parse(TB_Display.Text);
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

                case 'R'://case R
                    result = first_num - second_num;//result prend la velur du premier numero - le second numero
                    TB_Display.Text = result.ToString();//la fonction transforme le resultat avec des caracteres 
                    break;//arreter
            }
        }

        private void BTN_clear_Click(object sender, RoutedEventArgs e)//partie ou nous avons pas besoin d'interaction physique pour que ca marche
        {
            TB_Display.Text = "0";//la fonction display prend la valeur 0
        }

        public void display(string num)//partie interaction physique avec la machine 
        {
            if (TB_Display.Text == "0")//si la fonction display est egale a 0 alors 
            {
                TB_Display.Text = num;//la fonction va prendre la valeur num
            }
            else//sinon
            {
                TB_Display.Text = TB_Display.Text + num;// la fonction display prend la valeur de la fonction plus num
            }
        }

       
    }

}
