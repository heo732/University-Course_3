using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WarehouseOfIndustrialGoods.Models
{
    public class Product
    {
        #region Properties

        public int Id { get; set; }

        [ConcurrencyCheck]
        [Required]
        public string Name { get; set; }

        public ICollection<Supply> Supplies { get; set; }

        public ICollection<ProductMoving> ProductMovings { get; set; }

        #endregion Properties

        #region Constructors

        public Product()
        {
            Supplies = new List<Supply>();
            ProductMovings = new List<ProductMoving>();
        }

        #endregion Constructors
    }
}