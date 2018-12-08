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

namespace StrategiesForMethods_Begin
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

        private void btnAddNumbers_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int firstNumber;
                int secondNumber;
                int sum;

                if (string.IsNullOrEmpty(txtFirstNumber.Text) == false)
                {
                    firstNumber = int.Parse(txtFirstNumber.Text);

                    if (string.IsNullOrEmpty(txtSecondNumber.Text) == false)
                    {
                        secondNumber = int.Parse(txtSecondNumber.Text);

                        sum = firstNumber + secondNumber;
                        textBlockSum.Text = sum.ToString();
                    }
                    else
                    {
                        throw new Exception("You must specify a value for the input numbers");
                    }
                }
                else
                {
                    throw new Exception("You must specify a value for the input numbers");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error has occured", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
