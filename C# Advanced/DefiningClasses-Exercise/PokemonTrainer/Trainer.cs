using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public string name;
        public int numberBadges = 0;
        public List<Pokemon> pokemons;

        public Trainer(string name)
        {
            this.name = name;
            this.numberBadges = 0;
            this.pokemons = new List<Pokemon>();
        }
    }
}
