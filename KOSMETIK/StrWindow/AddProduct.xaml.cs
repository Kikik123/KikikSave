using KOSMETIK.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace KOSMETIK.StrWindow
{
    /// <summary>
    /// Логика взаимодействия для AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window, INotifyPropertyChanged
    {
        private Product _currentproduct = new Product();
        public event PropertyChangedEventHandler PropertyChanged;
        public AddProduct(Product selectedProduct)
        {
            InitializeComponent();
            DataContext = this;
            ComboType1.ItemsSource = KosmetikEntities.GetContext().Category.ToList();
            ComboType2.ItemsSource = KosmetikEntities.GetContext().Manufacturer.ToList();
            if (selectedProduct != null)
                _currentproduct = selectedProduct;

            DataContext = _currentproduct;
        }


        private void BtnSClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog GetImageDialog = new OpenFileDialog();
            GetImageDialog.Filter = "Файлы изображений: (*.png, *.jpg, *.jpeg)|*.png; *.jpg; *.jpeg";
            if (GetImageDialog.ShowDialog() == true)
            {
                _currentproduct.ProductPhoto = GetImageDialog.FileName.Substring(Environment.CurrentDirectory.Length - 10);
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("_currentproduct"));
                }

            }
        }

        private void BtnSaveClick(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentproduct.ProductName))
                errors.AppendLine("Укажите наименование продукта");
            if (string.IsNullOrWhiteSpace(_currentproduct.ProductDescription))
                errors.AppendLine("Укажите описание продукта");
            if (string.IsNullOrWhiteSpace(_currentproduct.ProductArticleNumber))
                errors.AppendLine("Укажите артикль продукта");
            if (_currentproduct.ProductCost < 0)
                errors.AppendLine("Цена продукта не может быть отрицательной");
            if (_currentproduct.ProductQuantityInStock < 0)
                errors.AppendLine("Количество продукта не может быть отрицательным");
            if (string.IsNullOrWhiteSpace(_currentproduct.ProductSupplier))
                errors.AppendLine("Укажите поставщика продукта");
            if (string.IsNullOrWhiteSpace(_currentproduct.ProductUnit))
                errors.AppendLine("Укажите ед. измерения продукта");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentproduct.ProductID == 0)
                KosmetikEntities.GetContext().Product.Add(_currentproduct);
            try
            {
                KosmetikEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                this.Close();
            }
            catch 
            {
                MessageBox.Show("Произошла ошибка, повторите попытку позже");
            }
        }

    }
}


