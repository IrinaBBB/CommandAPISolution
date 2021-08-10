using CommandAPI.Data;
using CommandAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandAPIRepo _repo;

        public CommandsController(ICommandAPIRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            return Ok(_repo.GetAllCommands()); 
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repo.GetCommmandById(id);
            if (commandItem == null)
            {
                return NotFound();
            }
            return Ok(commandItem);
        }
    }
}