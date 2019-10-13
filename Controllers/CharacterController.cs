using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using simpsons_net_web_api.Modules;
using simpsons_net_web_api.Dependencies;
using Microsoft.AspNetCore.Cors;

namespace simpsons_net_web_api.Controllers
{
    [Route("simpsons/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class CharacterController : ICharacter
    {
        List<Character> listOfCharacters => new List<Character>
        {
            new Character
            {
                FirstName = "Homer",
                SecondName = "Jay",
                LastName = "Simpson",
                Age = 39,
                Photo="controllers/images/Homer_Simpson.png"
            },
            new Character
            {
                FirstName = "Marjorie ",
                SecondName = "J.",
                LastName = "Bouvier Simpson",
                Age = 34
            },
            new Character
            {
                FirstName = "Bartholomew ",
                SecondName = "Jojo",
                LastName = "Simpson",
                Age = 10
            },
            new Character
            {
                FirstName = "Lisa",
                SecondName = "Marie",
                LastName = "Simpson",
                Age = 10
            },
            new Character
            {
                FirstName = "Margaret",
                SecondName = "",
                LastName = "Simpson",
                Age = 8
            },
            new Character
            {
                FirstName = "Santa's",
                SecondName = "Little",
                LastName = "Helper",
                Age = 7
            },
            
        };
        [HttpGet("{id}")]
        public Character GetCharacter(int id)
        {
            return listOfCharacters[id];
        }

        [HttpGet]
        public List<Character> GetCharacterList()
        {
            return listOfCharacters;
        }
    }
}