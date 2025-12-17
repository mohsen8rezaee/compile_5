using DataLayer.Services;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
        public UnitOfWork(Context context)
        {
            _context = context;
        }
        //---------------------------------------------------------------------------
        private IsymboleRepositry _symboleRepositry;
        public IsymboleRepositry symbolRepositry
        {
            get
            {
                if (_symboleRepositry == null)
                {
                    _symboleRepositry = new SymboleTableRepository(_context);
                }
                return _symboleRepositry;
            }
        }
        //---------------------------------------------------------------------------
        private ITokenRepository _tokenRepository;
        public ITokenRepository tokenRepository
        {
            get
            {
                if (_tokenRepository == null)
                {
                    _tokenRepository = new TokenTableRepository(_context);
                }
                return _tokenRepository;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
