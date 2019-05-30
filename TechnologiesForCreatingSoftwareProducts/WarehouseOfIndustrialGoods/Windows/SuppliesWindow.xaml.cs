using System.Data.Entity;
using System.Windows;

namespace WarehouseOfIndustrialGoods.Windows
{
    /// <summary>
    /// Interaction logic for SuppliesWindow.xaml
    /// </summary>
    public partial class SuppliesWindow : Window
    {
        #region Constructors

        public SuppliesWindow(WarehouseOfIndustrialGoodsContext db)
        {
            InitializeComponent();
            DB = db;
        }

        #endregion Constructors

        #region Properties

        private WarehouseOfIndustrialGoodsContext DB { get; }

        #endregion Properties

        #region Methods

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await DB.Supplies.LoadAsync();
            await DB.Products.LoadAsync();
            await DB.Employees.LoadAsync();
            await DB.Suppliers.LoadAsync();
            listViewSupplies.ItemsSource = DB.Supplies.Local.ToBindingList();
        }

        #endregion Methods
    }
}