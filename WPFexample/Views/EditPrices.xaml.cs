using Microsoft.Office.Interop.Excel;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using System.Xml.Linq;
using WPFexample.Classes;
using Excel = Microsoft.Office.Interop.Excel;

namespace WPFexample.Views
{
    /// <summary>
    /// Логика взаимодействия для EditPrices.xaml
    /// </summary>
    public partial class EditPrices : System.Windows.Window
    {
        List<string> categories = new();
        List<string> productNames = new();
        string fileImagePath;
        public EditPrices(List<string> categories)
        {
            InitializeComponent();
            this.categories = categories;
            EditCategories.ItemsSource = categories;
        }

        private void exit_btn(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.Owner.ShowDialog();
        }

        private void sel_Category(object sender, SelectionChangedEventArgs e)
        {
            string categoryName = EditCategories.SelectedItem.ToString();
            List<Food> EdItems = new();
            App.Range = App.Book.Sheets[categoryName].Cells;

            for (int row = 1; App.Range[row, 1].Value2 != null; row++)
            {
                string productName = App.Range.Cells[row, 1].Value2;
                int price = Convert.ToInt32(App.Range.Cells[row, 2].Value2);
                int weight = Convert.ToInt32(App.Range.Cells[row, 3].Value2);
                int calories = Convert.ToInt32(App.Range.Cells[row, 4].Value2);

                Food food = new()
                {
                    Name = productName,
                    Price = price,
                    Weight = weight,
                    Calories = calories
                };

                EdItems.Add(food);
            }
            EditItems.ItemsSource = EdItems;
        }

        private void category_Add(object sender, RoutedEventArgs e)
        {
            string newCategoryName = CategoryName.Text;

            // Проверить, что новое имя категории не является пустым или уже существующим именем категории
            if (!string.IsNullOrEmpty(newCategoryName) && !EditCategories.Items.Contains(newCategoryName))
            {
                // Добавить новую категорию в коллекцию источника данных
                categories.Add(newCategoryName);

                // Обновить ListBox, чтобы отобразить новый элемент
                EditCategories.Items.Refresh();

                // Добавить новую категорию в файл Excel
                App.worksheet = App.ExcelApp.Worksheets.Add();
                App.worksheet.Name = newCategoryName;
                App.Book.Save();
            }
            else
            {
                MessageBox.Show("Wrong category name!");
            }
        }

        private void ItemsSel(object sender, SelectionChangedEventArgs e)
        {
            String ProductName;
            if (EditItems.SelectedItem != null)
            {
                // Получить выбранный товар
                Food selectedFood = (Food)EditItems.SelectedItem;

                // Установить значения текстовых полей
                ProductName = selectedFood.Name.ToString();
                string imagePath = $@"{Environment.CurrentDirectory}\img\Fruits\{ProductName}.png";

                if (!File.Exists(imagePath))
                {
                    // Если фотография не существует, установить путь к фотографии по умолчанию
                    imagePath = $@"{Environment.CurrentDirectory}\img\No_Img.png";
                }

                ItemImage.Source = new BitmapImage(new Uri(imagePath));
                PriceText.Text = selectedFood.Price.ToString();
                WeightText.Text = selectedFood.Weight.ToString();
                CaloriesText.Text = selectedFood.Calories.ToString();
            }
        }

        private void ItemAdd(object sender, RoutedEventArgs e)
        {
            string categoryName = EditCategories.SelectedItem.ToString();
            App.worksheet = App.ExcelApp.Worksheets[categoryName];
            string productName = ItemName.Text;
            int price = Convert.ToInt32(PriceText.Text);
            int weight = Convert.ToInt32(WeightText.Text);
            int calories = Convert.ToInt32(CaloriesText.Text);

            // Проверка, что категория товаров выбрана
            if (!string.IsNullOrEmpty(categoryName))
            {
                // Проверка, что название товара не пустое
                if (!string.IsNullOrEmpty(productName))
                {
                    // Создание нового объекта Food с полученными характеристиками
                    Food newProduct = new Food
                    {
                        Name = productName,
                        Price = price,
                        Weight = weight,
                        Calories = calories
                    };

                    // Добавление нового товара в категорию в файле Excel
                    App.worksheet = App.ExcelApp.Worksheets[categoryName];

                    App.worksheet.Cells[EditItems.Items.Count + 1, 1].Value2 = newProduct.Name;
                    App.worksheet.Cells[EditItems.Items.Count + 1, 2].Value2 = newProduct.Price;
                    App.worksheet.Cells[EditItems.Items.Count + 1, 3].Value2 = newProduct.Weight;
                    App.worksheet.Cells[EditItems.Items.Count + 1, 4].Value2 = newProduct.Calories;

                    UpdateProductList(categoryName);

                    // Очистка текстовых полей после добавления товара
                    ItemName.Text = "";
                    PriceText.Text = "";
                    WeightText.Text = "";
                    CaloriesText.Text = "";

                    // Обновление списка товаров
                    App.Book.Save();
                }
                else
                {
                    // Вывести сообщение об ошибке, если название товара пустое
                    MessageBox.Show("Введите название товара.");
                }
            }
            else
            {
                // Вывести сообщение об ошибке, если категория товаров не выбрана
                MessageBox.Show("Выберите категорию товаров.");
            }
        }

        private void UpdateProductList(string categoryName)
        {
            List<Food> categoryProducts = new();

            App.Range = App.Book.Sheets[categoryName].Cells;

            for (int row = 1; App.Range[row, 1].Value2 != null; row++)
            {
                string productName = App.Range.Cells[row, 1].Value2;
                int price = Convert.ToInt32(App.Range.Cells[row, 2].Value2);
                int weight = Convert.ToInt32(App.Range.Cells[row, 3].Value2);
                int calories = Convert.ToInt32(App.Range.Cells[row, 4].Value2);

                Food product = new()
                {
                    Name = productName,
                    Price = price,
                    Weight = weight,
                    Calories = calories
                };

                categoryProducts.Add(product);
            }

            EditItems.ItemsSource = categoryProducts;
            EditItems.Items.Refresh();
        }

        private void cat_Del(object sender, RoutedEventArgs e)
        {
            string categoryName = EditCategories.SelectedItem.ToString();

            // Проверка, что категория выбрана
            if (!string.IsNullOrEmpty(categoryName))
            {
                // Удаление категории из списка и из файла Excel
                categories.Remove(categoryName);
                App.ExcelApp.Worksheets[categoryName].Delete();
            }
            else
            {
                MessageBox.Show("Выберите категорию для удаления.");
            }
        }

        private void add_Img(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ItemName.Text))
            {
                OpenFileDialog openFileDialog = new()
                {
                    Filter = "Изображения (*.png, *.jpg, *.jpeg)|*.png;*.jpg;*.jpeg"
                };

                if (openFileDialog.ShowDialog() == true)
                {
                    fileImagePath = openFileDialog.FileName;
                    // Отображение выбранной картинки в элементе Image или присваивание пути к выбранной картинке в переменную для использования при добавлении товара
                    ItemImage.Source = new BitmapImage(new Uri(fileImagePath));

                    string fileName = $"{ItemName.Text}.png";
                    string destinationPath = $@"{Environment.CurrentDirectory}\img\Fruits\{fileName}";
                    File.Copy(openFileDialog.FileName, destinationPath);
                }
            } else
            {
                MessageBox.Show("Введите название товара");
            }
        }

        private void del_Item(object sender, RoutedEventArgs e)
        {
            string categoryName = EditCategories.SelectedItem.ToString();

            if (EditItems.SelectedItem != null)
            {
                // Получение выбранного товара
                Food selectedProduct = (Food)EditItems.SelectedItem;

                // Удаление товара из листа Excel
                App.Range = App.Book.Sheets[categoryName].Cells;
                int rowCount = App.Range.Rows.Count;

                for (int row = 1; row <= rowCount; row++)
                {
                    string productName = App.Range.Cells[row, 1].Value2?.ToString();

                    if (productName == selectedProduct.Name)
                    {
                        App.Range.Rows[row].Delete();
                        break;
                    }
                }

                // Обновление списка товаров после удаления
                UpdateProductList(categoryName);
            }
            else
            {
                // Вывести сообщение об ошибке, если нет выбранного товара для удаления
                MessageBox.Show("Выберите товар для удаления.");
            }
        }
    }
}