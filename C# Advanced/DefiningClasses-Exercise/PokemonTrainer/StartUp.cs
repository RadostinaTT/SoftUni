using System;
using System.Linq;
using System.Collections.Generic;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Tournament")
                {
                    break;
                }
                var parts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var trainerName = parts[0];
                var pokemonName = parts[1];
                var pokemonElement = parts[2];
                var pokemonHealth = int.Parse(parts[3]);

                if (!trainers.Any(x => x.name == trainerName))
                {
                    trainers.Add(new Trainer(trainerName));
                }

                var trainer = trainers.First(t => t.name == trainerName);
                trainer.pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
            }

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                foreach (var trainer in trainers)
                {
                    if (trainer.pokemons.Any(e => e.element == command))
                    {
                        trainer.numberBadges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.pokemons)
                        {
                            pokemon.health -= 10;
                        }
                        trainer.pokemons = trainer.pokemons.Where(h => h.health > 0).ToList();
                    }
                }
                
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.numberBadges))
            {
                Console.WriteLine($"{trainer.name} {trainer.numberBadges} {trainer.pokemons.Count}");
            }
            
        }
    }
}
