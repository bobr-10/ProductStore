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
using System.Windows.Shapes;
using WPFexample.Classes;

namespace WPFexample.Views
{
    /// <summary>
    /// Логика взаимодействия для MakeOrder.xaml
    /// </summary>
    public partial class MakeOrder : Window
    {
        public List<Order> mainOrder;
        public MakeOrder(List<Order> mainOrder, int OrderPrice)
        {
            InitializeComponent();
            this.mainOrder = mainOrder;
            TotalPriceOrder.Text = $"Total: {OrderPrice}$";
            OrderInfo.ItemsSource= mainOrder;
        }

        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.Owner.ShowDialog();
        }

        private void Complete_Order(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for the order!");
            MainWindow main = new();
            main.Owner = this;
            this.Hide();
            main.Show();
        }
    }
}
