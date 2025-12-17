using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface ITokenRepository
    {
        bool InsertToken(Token token);
        bool DeleteAllTokens();


    }
}
