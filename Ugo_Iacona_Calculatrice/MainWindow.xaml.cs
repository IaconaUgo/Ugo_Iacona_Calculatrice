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
        double first_num;// declare la variable double qui ce nomme first_num
        double second_num;// declare la variable double qui ce nomme second_num
        double result; // declare la variable double qui ce nomme result
        char operation;// declare la variable char qui ce nomme operation

        private void BTN_1_Click(object sender, RoutedEventArgs e)// partie accessible seulement grace a cette classe, elle execute le code BTN_1_Click et ca nous donne l'information quand le bouton a été cliquer
        {
            display("1");// le bouton 1 = 1
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)// partie accessible seulement grace a cette classe, elle execute le code BTN_2_Click et ca nous donne l'information quand le bouton a été cliquer
        {
            display("2");// bouton 2 = 2
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)// partie accessible seulement grace a cette classe, elle execute le code BTN_3_Click et ca nous donne l'information quand le bouton a été cliquer
        {
            display("3");// bouton 3 = 3
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)// partie accessible seulement grace a cette classe, elle execute le code BTN_4_Click et ca nous donne l'information quand le bouton a été cliquer
        {
            display("4");// bouton 4 = 4
        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)// partie accessible seulement grace a cette classe, elle execute le code BTN_5_Click et ca nous donne l'information quand le bouton a été cliquer
        {
            display("5");// bouton 5 = 5
        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)// partie accessible seulement grace a cette classe, elle execute le code BTN_6_Click et ca nous donne l'information quand le bouton a été cliquer
        {
            display("6");// bouton 6 = 6
        }

        private void BTN_7_Click(object sender, RoutedEventArgs e)// partie accessible seulement grace a cette classe, elle execute le code de BTN_7_Click et ca nous donne l'information quand le bouton a été cliquer
        {
            display("7");// bouton 7 = 7
        }

        private void BTN_8_Click(object sender, RoutedEventArgs e)// partie accessible seulement grace a cette classe, elle execute le codede BTN_8_Click et ca nous donne l'information quand le bouton a été cliquer
        {
            display("8");// bouton 8 = 8
        }

        private void BTN_9_Click(object sender, RoutedEventArgs e)// partie accessible seulement grace a cette classe, elle execute le code de BTN_9_Click et ca nous donne l'information quand le bouton a été cliquer
        {
            display("9");// bouton 9 = 9
        }

        private void BTN_0_Click(object sender, RoutedEventArgs e)// partie accessible seulement grace a cette classe, elle execute le code de BTN_0_Click et ca nous donne l'information quand le bouton a été cliquer
        {
            display("0");// bouton 0 = 0
        }

        private void BTN_Plus_Click(object sender, RoutedEventArgs e)// partie accessible seulement grace a cette classe, elle execute le code de BTN_Plus_Click et ca nous donne l'information quand le bouton a été cliquer
        {
            first_num = double.Parse(TB_Display.Text);//valeur textuelle contenue dans une zone de texte est convertie en un nombre décimal et stockée dans la variable first_num
            TB_Display.Text = "0";// le contenue textuelle affiche 0
            operation = '+';// on utiliser + pour ce code
        }
    

        private void BTN_Moins_Click(object sender, RoutedEventArgs e)// partie accessible seulement grace a cette classe, elle execute le code de BTN_Moins_Click et ca nous donne l'information quand le bouton a été cliquer
        {
            first_num = double.Parse(TB_Display.Text);//valeur textuelle contenue dans une zone de texte est convertie en un nombre décimal et stockée dans la variable first_num
            TB_Display.Text = "0";// le contenue textuelle affiche 0
            operation = '-';// on utiliser - pour ce code
        }

        private void BTN_Multi_Click(object sender, RoutedEventArgs e)// partie accessible seulement grace a cette classe, elle execute le code de BTN_Multi_Click et ca nous donne l'information quand le bouton a été cliquer
        {
            first_num = double.Parse(TB_Display.Text);//valeur textuelle contenue dans une zone de texte est convertie en un nombre décimal et stockée dans la variable first_num
            TB_Display.Text = "0";// le contenue textuelle affiche 0
            operation = '*';// on utiliser * pour ce code
        }

        private void BTN_Div_Click(object sender, RoutedEventArgs e)// partie accessible seulement grace a cette classe, elle execute le code de BTN_Div_Click et ca nous donne l'information quand le bouton a été cliquer
        {
            first_num = double.Parse(TB_Display.Text);// premier numero pris en compte par la variable double
            TB_Display.Text = "0";// le contenue textuelle affiche 0
            operation = '/';// on utiliser / pour ce code
        }
        private void BTN_Cos_Click(object sender, RoutedEventArgs e)// partie accessible seulement grace a cette classe, elle execute le code de BTN_Cos_Click et ca nous donne l'information quand le bouton a été cliquer
        {
            first_num = double.Parse(TB_Display.Text);// premier numero pris en compte par la variable double et convertie en decimale

            result = Math.Cos(first_num);//resultat utilise la fonction Math pour calculer Cos sur le premier numero

            TB_Display.Text = result.ToString();// resultat dans la zone de texte

        }
        private void BTN_Sin_Click(object sender, RoutedEventArgs e)// partie accessible seulement grace a cette classe, elle execute le code de BTN_Sin_Click et ca nous donne l'information quand le bouton a été cliquer
        {
            first_num = double.Parse(TB_Display.Text);//valeur textuelle contenue dans une zone de texte est convertie en un nombre décimal et stockée dans la variable first_num

            result = Math.Sin(first_num);//resultat utilise la fonction Math pour calculer Sin sur le premier numero
            TB_Display.Text = result.ToString();// resultat dans la zone de texte
            
        }
            private void BTN_Tan_Click(object sender, RoutedEventArgs e)// partie accessible seulement grace a cette classe, elle execute le code
        {
            first_num = double.Parse(TB_Display.Text);// premier numero pris en compte par la variable double 

            result = Math.Tan(first_num); //resultat utilise la fonction Math pour calculer Tan sur le premier numero
            TB_Display.Text = result.ToString();//ecrire le resultat en caractères 
        }
        private void BTN_Racinecaree_Click(object sender, RoutedEventArgs e)// partie accessible seulement grace a cette classe, elle execute le code
        {
            first_num = double.Parse(TB_Display.Text);//valeur textuelle contenue dans une zone de texte est convertie en un nombre décimal et stockée dans la variable first_num
            TB_Display.Text = "√";
            operation = 'R';// on utiliser / pour ce code
        }

        private void BTN_result_Click(object sender, RoutedEventArgs e)// partie accessible seulement grace a cette classe, elle execute le code
        {
            second_num = double.Parse(TB_Display.Text);//valeur textuelle contenue dans une zone de texte est convertie en un nombre décimal et stockée dans la variable second_num
            switch (operation)
            {
                case '+':// case +
                    result = first_num + second_num;// result prend la valeur du premier numero plus le second numero
                    TB_Display.Text = result.ToString();// ecrire le resultat dans la zone de texte
                    break; //fin de case 

                case '-':
                    result = first_num - second_num;// resultat est egale au premier numero taper soustrait au second
                    TB_Display.Text = result.ToString();// ecrire le resultat dans la zone de texte
                    break;//fin de case 

                case '*':
                    result = first_num * second_num;// resultat est egale au premier numero taper multiplie au second
                    TB_Display.Text = result.ToString();// ecrire le resultat dans la zone de texte
                    break;//fin de case 

                case '/':
                    result = first_num / second_num;// resultat est egale au premier numero taper divise au second
                    TB_Display.Text = result.ToString();// ecrire le resultat dans la zone de texte
                    break;//fin de case 

                case 'C':// cette action sera effectuer si C est utliser
                    result = first_num - second_num;// resultat est egale au premier numero taper calculer avec Cos au second
                    TB_Display.Text = result.ToString();// ecrire le resultat dans la zone de texte
                    break;//fin de case 

                case 'S':
                    result = first_num - second_num;// resultat est egale au premier numero taper calculer avec Sin au second
                    TB_Display.Text = result.ToString();// ecrire le resultat dans la zone de texte
                    break;//fin de case 

                case 'T':
                    result = first_num - second_num;// resultat est egale au premier numero taper calculer avec Tan au second
                    TB_Display.Text = result.ToString();// ecrire le resultat dans la zone de texte
                    break;//fin de case 

                case 'R'://case R
                    result = first_num - second_num;//result prend la velur du premier numero - le second numero
                    TB_Display.Text = result.ToString();// ecrire le resultat dans la zone de texte 
                    break;//fin de case 
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
