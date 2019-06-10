using System.Data.Entity;
using System.Windows.Controls;

namespace WarehouseOfIndustrialGoods.Pages
{
    /// <summary>
    /// Interaction logic for ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
        #region Constructors

        public ProductsPage(MainWindow mainWindow)
        {
            InitializeComponent();
            WindowTitle = "Продукти";
            MainWindow = mainWindow;
            productsListView.ItemsSource = MainWindow.DB.Products.Local.ToBindingList();
        }

        #endregion Constructors

        #region Properties

        private MainWindow MainWindow { get; }

        #endregion Properties

        #region Methods

        private void ProductsBackButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainWindow.SwitchPage("Main");
        }

        #endregion Methods
    }
}