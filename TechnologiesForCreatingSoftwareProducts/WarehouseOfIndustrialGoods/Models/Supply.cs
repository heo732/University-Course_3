using System;
using System.ComponentModel.DataAnnotations;

namespace WarehouseOfIndustrialGoods.Models
{
    public class Supply
    {
        #region Properties

        public int Id { get; set; }

        [ConcurrencyCheck]
        [Required]
        public int EmployeeId { get; set; }

        [ConcurrencyCheck]
        [Required]
        public Employee Employee { get; set; }

        [ConcurrencyCheck]
        [Required]
        public int SupplierId { get; set; }

        [ConcurrencyCheck]
        [Required]
        public Supplier Supplier { get; set; }

        [ConcurrencyCheck]
        [Required]
        public int ProductId { get; set; }

        [ConcurrencyCheck]
        [Required]
        public Product Product { get; set; }

        [ConcurrencyCheck]
        [Required]
        public int CountOfProduct { get; set; }

        [ConcurrencyCheck]
        [Required]
        public DateTime DateTime { get; set; }

        #endregion Properties
    }
}