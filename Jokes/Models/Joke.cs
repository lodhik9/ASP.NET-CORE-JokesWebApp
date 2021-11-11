using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jokes.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestion{ get; set; }
        public string JokeAnswer { get; set; }

        public Joke()
        {

        }
    }
}
