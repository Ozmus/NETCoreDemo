using System.Collections.Generic;
using NETCoreDemo.Models;

namespace NETCoreDemo.Data
{
    public interface INETCoreDemoRepo
    {
        IEnumerable<Move> GetAppMoves();

        Move getMoveById(int id);
    }
}
