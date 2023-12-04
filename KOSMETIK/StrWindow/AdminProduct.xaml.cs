﻿using KOSMETIK.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KOSMETIK.StrWindow
{
    /// <summary>
    /// Логика взаимодействия для AdminProduct.xaml
    /// </summary>
    public partial class AdminProduct : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void Invalidate()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ProductList"));
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("ProductList"));
        }

        private int SortType = 0;
        private int FilterType = 0;
        public List<Manufacturer> FilterList { get; set; }
        public string[] SortList { get; set; } = 
            {
                "Без сортировки",
                "Стоимость по возростанию",
                "Стоимость по убыванию"
            };
        private string SearchFilter = "";
        private IEnumerable<Product> _ProductList;
        public IEnumerable<Product> ProductList
        {
            get
            {
                var Result = _ProductList;

                if (FilterType > 0)
                    Result = Result.Where(i => i.Manufacturer.ManufacturerID == FilterType);

                switch (SortType)
                {
                    case 1:
                        _ProductList = KosmetikEntities.GetContext().Product.OrderBy(p => p.ProductCost);
                        break;
                    case 2:
                        _ProductList = KosmetikEntities.GetContext().Product.OrderByDescending(p => p.ProductCost);
                        break;
                }
                if (SearchFilter != "")
                    Result = Result.Where(
                        p => p.ProductName.IndexOf(SearchFilter, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        p.ProductDescription.IndexOf(SearchFilter, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        p.ProductStatus.IndexOf(SearchFilter, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        p.ProductUnit.IndexOf(SearchFilter, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        p.ProductSupplier.IndexOf(SearchFilter, StringComparison.OrdinalIgnoreCase) >= 0);

                return Result.Take(1000);
            }
            set
            {
                _ProductList = value;
                Invalidate();
            }
        }

        public AdminProduct()
        {
            InitializeComponent();
            DataContext = this;
            ProductList = KosmetikEntities.GetContext().Product.ToList();
            FilterList = KosmetikEntities.GetContext().Manufacturer.ToList();
            FilterList.Insert(0, new Manufacturer { ManufacturerName = "Все производители" });
        }


        private void ProductTypeFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FilterType = (ProductTypeFilter.SelectedItem as Manufacturer).ManufacturerID;
            Invalidate();
        }

        private void SortTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SortType = SortTypeComboBox.SelectedIndex;
            Invalidate();
        }

        private void SearchFilterTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            SearchFilter = SearchFilterTextBox.Text;
            Invalidate();
        }

        private void BtnAdd1(object sender, RoutedEventArgs e)
        {
            AddProduct addproduct = new AddProduct(null);
            addproduct.ShowDialog();
            if (addproduct.IsActive == false)
            {
                ProductListView.ItemsSource = KosmetikEntities.GetContext().Product.ToList();
                Invalidate();
            }
        }

        private void BtnEditS(object sender, RoutedEventArgs e)
        {
            AddProduct addproduct = new AddProduct((sender as Button).DataContext as Product);
            addproduct.ShowDialog();
            if (addproduct.IsActive == false)
            {
                ProductListView.ItemsSource = KosmetikEntities.GetContext().Product.ToList();
                Invalidate();
            }
        }

        private void BtnDelete1(object sender, RoutedEventArgs e)
        {
            var productForRenoving = ProductListView.SelectedItems.Cast<Product>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {productForRenoving.Count()} элементы?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    KosmetikEntities.GetContext().Product.RemoveRange(productForRenoving);
                    KosmetikEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    ProductListView.ItemsSource = KosmetikEntities.GetContext().Product.ToList();
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка, возможно продукт присутствует в заказе");
                }
            }
        }
    }
}