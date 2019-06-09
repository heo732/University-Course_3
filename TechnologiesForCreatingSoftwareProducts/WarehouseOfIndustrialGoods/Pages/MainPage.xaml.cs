using System.Windows;
using System.Windows.Controls;

namespace WarehouseOfIndustrialGoods.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private MainWindow MainWindow { get; }

        public MainPage(MainWindow window)
        {
            InitializeComponent();
            WindowTitle = "Склад - промислові товари";
            MainWindow = window;
        }

        private void SuppliesButton_Click(object sender, RoutedEventArgs e)
        {
            //
        }
    }
}