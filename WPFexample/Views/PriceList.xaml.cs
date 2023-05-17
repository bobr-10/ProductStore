using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Excel = Microsoft.Office.Interop.Excel;
using Button = System.Windows.Controls.Button;

namespace WPFexample.Views
{
    /// <summary>
    /// Логика взаимодействия для PriceList.xaml
    /// </summary>
    public partial class PriceList : System.Windows.Window
    {
        public List<Classes.Order> productsOrder;
        List<Classes.Food> products;
        public int MoneyCount { get; set; }
        public int OrderPrice { get; set; }

        public PriceList(List<string> categories, int MoneyCount)
        {
            InitializeComponent();
            categotiesList.ItemsSource = categories;
            this.MoneyCount = MoneyCount;
            MoneyText.Text = $"Money: {MoneyCount}$";
            productsOrder = new List<Classes.Order>();
            OrderPrice = 0;
        }

        private void exit_btn(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.Owner.ShowDialog();
        }

        private void item_sel(object sender, SelectionChangedEventArgs e)
        {
            string categoryName = categotiesList.SelectedItem.ToString();
            string productName; 
            products = new List<Classes.Food>();
            App.Range = App.Book.Sheets[categoryName].Cells;

            Classes.Food product;
            for (int row = 1; App.Range[row, 1].value2 != null; row++)
            {
                product = new Classes.Food();
                product.Name = App.Range.Cells[row, 1].value2;
                productName = product.Name;
                product.Price = (int)App.Range[row, 2].value2;
                product.Photo = $@"{Environment.CurrentDirectory}\img\Fruits\{productName}.png";
                product.Weight = (int)App.Range.Cells[row, 3].value2;
                product.Calories = (int)App.Range.Cells[row, 4].value2;
                products.Add(product);
            }
            ProductsList.ItemsSource = products;
        }

        private void InOrder(object sender, RoutedEventArgs e)
        {
            Classes.Order order;
            Classes.Food food = (sender as Button).DataContext as Classes.Food;
            
            string productName = food.Name;
            int productCost = food.Price;
            if (OrderPrice + productCost <= MoneyCount)
            {
                OrderPrice += productCost;
                TotalPriceOrder.Text = $"Total: {OrderPrice}$";
                int Id = productsOrder.FindIndex(x => x.Name == productName);
                if(Id < 0)
                {
                    order = new Classes.Order();
                    order.Name = productName;
                    order.Price = productCost;
                    order.Count = 1;
                    order.Total = productCost;
                    productsOrder.Add(order);
                }
                else
                {
                    productsOrder[Id].Count++;
                    productsOrder[Id].Total  = productsOrder[Id].Price * productsOrder[Id].Count;
                }
            }
            else
            {
                MessageBox.Show("Not enough money!");
            }
        }

        private void MakeOrder(object sender, RoutedEventArgs e)
        {
            MakeOrder order = new(productsOrder, OrderPrice);
            order.Owner= this;
            this.Hide();
            order.ShowDialog();
        }
    }
}
