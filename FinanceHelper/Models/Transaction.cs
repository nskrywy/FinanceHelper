using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceHelper.Models
{
    class Transaction
    {
        [Key]
        public UInt32 TransactionId { get; set; }
        public int UserId { get; set; }
        public DateTime TransactionDate { get; set; }

        [Column(TypeName = "Varchar"), MaxLength(100)]
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public byte TransactionType { get; set; }
        public int VendorId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }

    }
}
