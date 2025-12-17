using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;


namespace DataLayer.Services
{
    public class SymboleTableRepository : IsymboleRepositry
    {
        private Context db;
        public SymboleTableRepository(Context context)
        {

            db = context;

        }
        public bool DeleteSymbol(SymbolTable symbol)
        {
            try
            {
                db.Entry(symbol).State=EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public bool DeleteSymbolById(int id)
        {
            try
            {
                var symbol = GetSymbolById(id);
                DeleteSymbol(symbol);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

      

        public SymbolTable GetSymbolById(int id)
        {
            throw new NotImplementedException();
        }

        public SymbolTable GetSymbolByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool InsertSymbol(SymbolTable symbol)
        {
            throw new NotImplementedException();
        }

        

        public bool UpdateSymbol(SymbolTable symbol)
        {
            throw new NotImplementedException();
        }
    }
}
