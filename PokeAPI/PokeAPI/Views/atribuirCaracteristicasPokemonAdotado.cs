using System;
using PokeWorldApplication;

namespace PokeWorldApplication
{
	public class atribuirCaracteristicasPokemonAdotadoView
    {
        public static void atribuirCaracteristicasPokemonAdotado(string nomePokemonEscolhido, pokemonAdotado pokemonAdotado, Random niveisRandom)
        {
            pokemonAdotado.nome = nomePokemonEscolhido;
            pokemonAdotado.nivelDeSono = niveisRandom.Next(11);
            pokemonAdotado.alimentacao = niveisRandom.Next(11);
            pokemonAdotado.humor = niveisRandom.Next(11);
        }
    }
}
