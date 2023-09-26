using System;

namespace PokeWorldApplication
{
    public class adotarUmPokemonView
    {
        public static string adotarUmPokemon()
        {
            Console.WriteLine("-------------------------------- ADOTAR UM POKÉMON --------------------------------");
            Console.WriteLine("Escreva o nome do Pokémon escolhido:");
            var nomePokemonEscolhido = Console.ReadLine();

            return (nomePokemonEscolhido);
        }

    }
}
