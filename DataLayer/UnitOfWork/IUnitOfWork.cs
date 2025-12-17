using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IUnitOfWork : IDisposable
    {
        IsymboleRepositry symbolRepositry { get; }
        ITokenRepository tokenRepository { get; }

        void Save();
    }
}
