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
         
        public IEnumerable<SymbolTable> GetAllSymbol()
        {
            return db.SymbolTable.ToList();
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

                return false;
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

                return false;
            }
        }

      

        public SymbolTable GetSymbolById(int id)
        {
            return db.SymbolTable.Find(id);
        }

      
        public bool InsertSymbol(SymbolTable symbol)
        {
            try
            {
                db.SymbolTable.Add(symbol);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        

        public bool UpdateSymbol(SymbolTable symbol)
        {
            try
            {
                db.Entry(symbol).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
