using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceHelper.Models
{
    class User
    {
        [Key]
        public int UserId { get; set; }

        [Column(TypeName ="VarChar"), MaxLength(25)]
        public string UserName { get; set; }

        [Column(TypeName = "VarChar"), MaxLength(50)]
        public string Password { get; set; }
    }
}
