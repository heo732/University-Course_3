using System.ComponentModel.DataAnnotations;

namespace WarehouseOfIndustrialGoods.Models
{
    public class Consumer
    {
        #region Properties

        public int Id { get; set; }

        [ConcurrencyCheck]
        [Required]
        public string Name { get; set; }

        #endregion Properties
    }
}