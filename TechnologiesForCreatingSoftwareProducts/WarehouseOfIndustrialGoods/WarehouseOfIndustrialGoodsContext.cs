using System.Data.Entity;
using WarehouseOfIndustrialGoods.Models;

namespace WarehouseOfIndustrialGoods
{
    public class WarehouseOfIndustrialGoodsContext : DbContext
    {
        #region Properties

        public DbSet<Product> Products { get; set; }

        #endregion Properties

        #region Constructors

        public WarehouseOfIndustrialGoodsContext() : base("DBConnection")
        { }

        #endregion Constructors
    }
}