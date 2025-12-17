using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TokenTableRepository : ITokenRepository
    {
        private Context db;
        public TokenTableRepository(Context context)
        {
            db = context;
        }
        public bool DeleteAllTokens()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Token> GetAllTokens()
        {
            throw new NotImplementedException();
        }

        public bool InsertToken(Token token)
        {
            throw new NotImplementedException();
        }
    }
}
