using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Context:DbContext
    {
        public DbSet<Token> Tokens { get; set; }
        public DbSet<SymbolTable> SymbolTable { get; set; }
    }
}
