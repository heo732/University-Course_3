﻿using System.Data.Entity;
using System.Windows;
using WarehouseOfIndustrialGoods.Windows;

namespace WarehouseOfIndustrialGoods
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Properties

        private WarehouseOfIndustrialGoodsContext DB { get; } = new WarehouseOfIndustrialGoodsContext();

        #endregion Properties

        #region Constructors

        public MainWindow()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private async void Window_Initialized(object sender, System.EventArgs e)
        {
            await DB.Products.LoadAsync();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new SuppliesWindow(DB).Show();
        }

        #endregion Methods
    }
}