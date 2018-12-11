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

namespace StrategiesForMethods_End
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

private bool AreInputFieldsMissing()
{
    return (string.IsNullOrEmpty(txtFirstNumber.Text) == false
        || string.IsNullOrEmpty(txtSecondNumber.Text) == false);
}

private int ComputeSum()
{
    int firstNumber = int.Parse(txtFirstNumber.Text);
    int secondNumber = int.Parse(txtSecondNumber.Text);
    return firstNumber + secondNumber;
}

private void btnAddNumbers_Click(object sender, RoutedEventArgs e)
{
    try
    {
        if (AreInputFieldsMissing())
        {
            throw new Exception("You must specify a value for the input numbers");
        }

        var sum = ComputeSum();
        textBlockSum.Text = sum.ToString();
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message, "An error has occured", MessageBoxButton.OK, MessageBoxImage.Error);
    }
}
    }
}
