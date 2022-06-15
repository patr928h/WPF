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

namespace Buttons05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int countUp;
        public MainWindow()
        {
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random generator = new Random();
            double newHeight = generator.NextDouble() * (ActualHeight - button.ActualHeight);
            double newWidth = generator.NextDouble() * (ActualWidth - button.ActualWidth);
            double result = generator.NextDouble();
            button.Margin = new(newWidth, newHeight, 0.0, 0.0);
            countUp++;
            point.Text = countUp.ToString();
            button.Background = Brushes.Green;
        }
        
    }
}
