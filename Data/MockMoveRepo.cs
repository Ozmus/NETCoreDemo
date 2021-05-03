using System.Collections.Generic;
using NETCoreDemo.Models;
namespace NETCoreDemo.Data
{
    public class MockMoveRepo : INETCoreDemoRepo
    {

        public IEnumerable<Move> GetAppMoves()
        {
            var moves = new List<Move>
            {
                new Move{Id = 0, Name = "Front Hand Shoot", HowTo = "Move your primary hand to front from back." },
                new Move{Id = 1, Name = "Back Hand Shoot", HowTo = "Move your both hands to front from back." },
                new Move{Id = 2, Name = "Service", HowTo = "Use your body as an elastic thing to gain more power." }
            };

            return moves;
        }
        public  Move getMoveById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}