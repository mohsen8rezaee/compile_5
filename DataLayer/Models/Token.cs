using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Token
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="please choose a name for token")]

        public string name { get; set; }
        [Required(ErrorMessage = "please choose a attr for token")]

        public string attribute { get; set; }
    }
}
