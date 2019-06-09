using System.Windows;
using System.Data.Entity;
using WarehouseOfIndustrialGoods.Pages;

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

        private void Window_Initialized(object sender, System.EventArgs e)
        {
            Content = new MainPage(DB);
        }

        #endregion Methods
    }
}