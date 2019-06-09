using System.Windows;
using System.Windows.Controls;

namespace WarehouseOfIndustrialGoods.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private WarehouseOfIndustrialGoodsContext DB { get; }

        public MainPage(WarehouseOfIndustrialGoodsContext db)
        {
            InitializeComponent();
            WindowTitle = "Склад - промислові товари";
            DB = db;
        }

        private void SuppliesButton_Click(object sender, RoutedEventArgs e)
        {
            //
        }
    }
}