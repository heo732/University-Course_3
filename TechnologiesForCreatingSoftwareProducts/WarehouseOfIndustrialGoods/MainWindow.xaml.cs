using System.Collections.Generic;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;
using WarehouseOfIndustrialGoods.Pages;

namespace WarehouseOfIndustrialGoods
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Properties

        public static WarehouseOfIndustrialGoodsContext DB { get; } = new WarehouseOfIndustrialGoodsContext();

        public Dictionary<string, Page> Pages { get; }

        #endregion Properties

        #region Constructors

        public MainWindow()
        {
            InitializeComponent();

            Pages = new Dictionary<string, Page>
            {
                { "Main", new MainPage(this) },
                { "Products", new  ProductsPage(this)}
            };

            SwitchPage("Main");
        }

        #endregion Constructors

        #region Methods

        public void SwitchPage(string page)
        {
            Content = Pages[page];
        }

        private async void Window_Initialized(object sender, System.EventArgs e)
        {
            await DB.Consumers.LoadAsync();
            await DB.Employees.LoadAsync();
            await DB.Preparations.LoadAsync();
            await DB.Products.LoadAsync();
            await DB.ProductMovings.LoadAsync();
            await DB.Shipments.LoadAsync();
            await DB.Suppliers.LoadAsync();
            await DB.Supplies.LoadAsync();
            await DB.WarehousePlaces.LoadAsync();
        }

        #endregion Methods
    }
}