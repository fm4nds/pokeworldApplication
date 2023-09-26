using System;
using PokeWorldApplication;

namespace PokeWorldApplication
{
	public class menuPokemonEscolhidoInteracaoView
	{
        public static void menuPokemonEscolhidoInteracao(pokemonAdotado pokemon)
        {
            Console.WriteLine("-------------------------------- VOCÊ DESEJA: --------------------------------");
            Console.WriteLine($"1. Brincar com {pokemon.nome}");
            Console.WriteLine($"2. Alimentar {pokemon.nome}");
            Console.WriteLine($"3. Pôr {pokemon.nome} para dormir");
            Console.WriteLine($"4. Voltar");
            var escolhaInteracaoPokemon = Console.ReadLine();

            if (escolhaInteracaoPokemon == "1")
            {
                brincarComPokemonView.brincarComPokemon(pokemon);

            }
            else if (escolhaInteracaoPokemon == "2")
            {
                alimentarPokemonView.alimentarPokemon(pokemon);

            }
            else if (escolhaInteracaoPokemon == "3")
            {
                porParaDormirPokemonView.porParaDormirPokemon(pokemon);
            }
            else
            {
                Console.WriteLine("Aguarde...");
            }

        }
    }
}
