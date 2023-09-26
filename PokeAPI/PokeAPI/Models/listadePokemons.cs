using System;

namespace PokeWorldApplication
{ 

    public class listadePokemons
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<nomeEUrl> results { get; set; }

    }
}