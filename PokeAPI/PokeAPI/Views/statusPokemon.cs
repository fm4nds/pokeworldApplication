using System;

namespace PokeWorldApplication
{
	public class statusPokemonView
	{
        public static void statusPokemon(pokemonAdotado pokemons)
        {
            Console.WriteLine($"- Nível de humor: {pokemons.humor}");
            Console.WriteLine($"- Nível de alimentação: {pokemons.alimentacao}");
            Console.WriteLine($"- Nível de sono: {pokemons.nivelDeSono}");
        }
    }
}