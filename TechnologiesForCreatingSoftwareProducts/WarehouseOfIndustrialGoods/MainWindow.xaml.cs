using System.Collections.Generic;
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

        public Dictionary<string, Page> Pages { get; } = new Dictionary<string, Page>
        {
            { "Main", new MainPage(DB) },
            { "Products", new  }
        };

        #endregion Properties

        #region Constructors

        public MainWindow()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void Window_Initialized(object sender, System.EventArgs e)
        {
            Content = new MainPage(DB);
        }

        #endregion Methods
    }
}