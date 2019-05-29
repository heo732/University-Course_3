using System.Data.Entity;

namespace WarehouseOfIndustrialGoods
{
    public class WarehouseOfIndustrialGoodsContext : DbContext
    {
        #region Constructors

        public WarehouseOfIndustrialGoodsContext() : base("DBConnection")
        { }

        #endregion Constructors
    }
}