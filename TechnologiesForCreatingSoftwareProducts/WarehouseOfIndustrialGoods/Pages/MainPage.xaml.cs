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
using System.Windows.Navigation;
using System.Windows.Shapes;

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
