using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace LAB14WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            
            InitializeComponent();
            
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName="Бананы",
                ProductPrice=100,
                ProductImage="DATA/banan.png",
                ProductCategory=ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProductName = "Яблоки",
                ProductPrice = 150,
                ProductImage = "DATA/apple.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProductName = "Вентилятор",
                ProductPrice = 2500,
                ProductImage = "DATA/fan.jpeg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Телевизор",
                ProductPrice = 50000,
                ProductImage = "DATA/tv.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            listBox.ItemsSource = products;
         }
    }
}
