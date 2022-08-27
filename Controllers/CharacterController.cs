using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Id = 1,Name = "Sam"}
        };
        [HttpGet("GetAllCharacter")]
        // Returns multiple lists
        public ActionResult<List<Character>> Get(){
            return Ok(characters);
        }
        [HttpGet("{id}")]
        // Returns single list or value
        public ActionResult<Character> GetSingle(int id){
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }
    }
}