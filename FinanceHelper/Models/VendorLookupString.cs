using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceHelper.Models
{
    class VendorLookupString
    {
        [Key,Column(TypeName = "VarChar"), MaxLength(50)]
        public string LookupString { get; set; }
        public int VendorID { get; set; }
    }
}
