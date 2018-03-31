using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceHelper.Models
{
    class Category
    {
        public int CategoryId { get; set; }

        [Column(TypeName = "Varchar"), MaxLength(25)]
        public int Description { get; set; }
    }
}
