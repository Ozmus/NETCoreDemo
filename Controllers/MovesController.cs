using System.Collections.Generic;
using NETCoreDemo.Models;
using NETCoreDemo.Data;
using Microsoft.AspNetCore.Mvc;

namespace NETCoreDemo.Controllers
{
    [Route("api/moves")]
    [ApiController]
    public class MovesController : ControllerBase
    {
        private readonly MockMoveRepo _repository = new MockMoveRepo();

        [HttpGet]
        public ActionResult <IEnumerable<Move>> GetAllMoves()
        {
            var moveItems = _repository.GetAppMoves();
            return Ok(moveItems);
        }

        [HttpGet("{id}")]
        public ActionResult <Move> GetMoveById(int id)
        {
            var moveItem = _repository.getMoveById(id);
            return Ok(moveItem);
        }

    }
}