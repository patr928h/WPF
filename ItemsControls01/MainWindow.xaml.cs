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

namespace ItemsControls01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private List<Product> products = new()
        {
            new() { Name = "Vand", Description = "Vand er en drikkevare", Category = "Drikkevarer", Amount = 1, Price = 12001, CreationDate = new(31, 5, 22), Isexpired = true, Id = 13213 },
            new() { Name = "Te", Description = "Te er en drikkevare", Category = "Drikkevarer", Amount = 1, Price = 20, CreationDate = new(31, 5, 22), Isexpired = false, Id = 13214 },
            new() { Name = "Kaffe", Description = "Kaffe er en drikkevare", Category = "Drikkevarer", Amount = 1, Price = 20, CreationDate = new(31, 5, 22), Isexpired = false, Id = 13215 },
            new() { Name = "Taske", Description = "En taske er en accesory", Category = "Accesory", Amount = 1, Price = 300, CreationDate = new(12, 4, 18), Isexpired = false, Id = 12345 },
            new() { Name = "Solbriller", Description = "Solbriller er en accesory", Category = "Accesory", Amount = 1, Price = 150, CreationDate = new(12, 4, 18), Isexpired = false, Id = 12356},
            new() { Name = "Hat", Description = "En hat er en accesory", Category = "Accesory", Amount = 1, Price = 200, CreationDate = new(12, 4, 18), Isexpired = false, Id = 12365},
            new() { Name = "Ring", Description = "En ring er en accesory", Category = "Accesory", Amount = 1, Price = 1400, CreationDate = new(12, 4, 18), Isexpired = false, Id = 12375},
            new() { Name = "Stål", Description = "Stål er et byggemateriale", Category = "Byggematerialer", Amount = 1, Price = 300, CreationDate = new(13, 4, 18), Isexpired = false, Id = 14354},
            new() { Name = "Træ", Description = "Træ er et byggemateriale", Category = "Byggematerialer", Amount = 1, Price = 300, CreationDate = new(13, 4, 18), Isexpired = false, Id = 14355},
            new() { Name = "Glas", Description = "Glas er et byggemateriale", Category = "Byggematerialer", Amount = 1, Price = 300, CreationDate = new(13, 4, 18), Isexpired = false, Id = 14355}


        };


        public MainWindow()
        {
            InitializeComponent();
            products = products.OrderBy(p => p.Name).ToList();
            listBoxProducts.ItemsSource = products;
        }

        private void listBoxProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (listBoxProducts.SelectedItem != null)
            {
                


                Product selectedProduct = (Product)listBoxProducts.SelectedItem;
                text.Text = selectedProduct.Name;
                listBoxProducts.ItemsSource = null;
                listBoxProducts.ItemsSource = products;
                datePickerCreationDate.SelectedDate = selectedProduct.CreationDate;

                
                
                


            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string name = text.Text;
            

            

            string newCategory = "";
            if (Drikkevarer.IsChecked == true)
            {
                newCategory = "Drikkevarer";
            }
            else if (Accesories.IsChecked == true)
            {
                newCategory = "Accesories";
            }
            else if (Byggematerialer.IsChecked == true)
            {
                newCategory = "Byggematerialer";
            }
            
            Product p = new() { Name = name, Category = newCategory};

            products.Add(p);
            products = products.OrderBy(p => p.Name).ToList();

            listBoxProducts.ItemsSource = null;
            listBoxProducts.ItemsSource = products;

            DateTime creationdate = datePickerCreationDate.SelectedDate.Value;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
          

           
        }
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
           

            
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            

           
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
