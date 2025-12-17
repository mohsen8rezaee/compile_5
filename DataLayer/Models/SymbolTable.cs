using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SymbolTable
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="please choose a value for symbol")]

        public string name { get; set; }
    }
}
