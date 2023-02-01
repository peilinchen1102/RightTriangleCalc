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
using System.Text.RegularExpressions;

namespace Chen_Peilin_Csharp2_B1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Calculate when input leg and hypotenuse
        private void cmdCalculate1_Click(object sender, RoutedEventArgs e)
        {
            try {
                //Remove everyting except numberic inputs and stores variables
                string inputSidec = Regex.Replace(txtSidec.Text, "[^0-9.]", "");
                string inputSidea = Regex.Replace(txtSidea.Text, "[^0-9.]", "");

                if (inputSidea.Length > 0 && inputSidec.Length > 0)
                {
                    double c = Convert.ToDouble(inputSidec);
                    double a = Convert.ToDouble(inputSidea);
                    if(c < a)
                    {
                        lblError.Content = "Not a Possible Triangle";
                    }

                    double A = 180/Math.PI * (Math.Asin(a / c));
                    double B = 180/Math.PI * (Math.Acos(a / c));
                    double b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));

                    lbloutputSideb.Content = "side b: " + Convert.ToString(b);
                    lbloutputAngleB.Content = "angle B: " + Convert.ToString(B);
                    lbloutputAngleA.Content = "angle A: " + Convert.ToString(A);
                }
                


            }
            catch (FormatException h)
            {
            }
}
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        //Calculate when input leg and leg
        private void cmdCalculate2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string inputSideb2 = Regex.Replace(txtSideb2.Text, "[^0-9.]", "");
                string inputSidea2 = Regex.Replace(txtSidea2.Text, "[^0-9.]", "");

                if (inputSidea2.Length > 0 && inputSideb2.Length > 0)
                {
                    double b = Convert.ToDouble(inputSideb2);
                    double a = Convert.ToDouble(inputSidea2);

                    double A = 180/Math.PI * (Math.Atan(a / b));
                    double B = 180/Math.PI * (Math.Atan(b / a));
                    double c = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(a, 2));

                    lbloutputSidec2.Content = "side c: " + Convert.ToString(c);
                    lbloutputAngleB2.Content = "angle B: " + Convert.ToString(B);
                    lbloutputAngleA2.Content = "angle A: " + Convert.ToString(A);

                }
            }
            catch (FormatException h)
            {
            }
        }

        private void txtSidea1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    }

