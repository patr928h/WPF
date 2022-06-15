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

namespace RadioButton01
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

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Red;
        }

        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            Background = Brushes.White;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Yellow;
        }

        private void RadioButton_Unchecked_1(object sender, RoutedEventArgs e)
        {
            Background = Brushes.White;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            Background = Brushes.Green;
        }

        private void RadioButton_Unchecked_2(object sender, RoutedEventArgs e)
        {
            Background = Brushes.White;
        }
    }
}
