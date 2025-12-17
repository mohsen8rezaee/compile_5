using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IsymboleRepositry
    {
        IEnumerable<SymbolTable> GetAllSymbol();
        SymbolTable GetSymbolById(int id);
        bool InsertSymbol(SymbolTable symbol);
        bool DeleteSymbol(SymbolTable symbol);
        bool DeleteSymbolById(int id);
        bool UpdateSymbol(SymbolTable symbol);
    }
}
