using System;
using PokeWorldApplication;

namespace PokeWorldApplication
{
    public class menuController
    {
        public async static Task Menu(user User)
        {
            var menuPrincipalSelecao = 0;

            do
            {
                menuPrincipalSelecao = menuPrincipalView.menuPrincipal(User.nome);

                if (menuPrincipalSelecao == '1')
                {
                    var pokemons = await listarPokemonsView.listarPokemons();
                    var nomePokemonEscolhido = adotarUmPokemonView.adotarUmPokemon();
                    if (pokemons.Contains(nomePokemonEscolhido))
                    {
                        var opcaoPokemonEscolhido = await menuPokemonEscolhidoView.menuPokemonEscolhido(nomePokemonEscolhido);
                        if (opcaoPokemonEscolhido == '2')
                        {
                            Random niveisRandom = new Random();
                            pokemonAdotado pokemonAdotado = new pokemonAdotado();
                            atribuirCaracteristicasPokemonAdotadoView.atribuirCaracteristicasPokemonAdotado(nomePokemonEscolhido, pokemonAdotado, niveisRandom);
                            User.pokemonsAdotados.Add(pokemonAdotado);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nome inválido");
                    }
                }
                else if (menuPrincipalSelecao == '2')
                {
                    Console.WriteLine("-------------------------------- VER MEUS POKÉMONS --------------------------------");
                    if (User.pokemonsAdotados.Count != 0)
                    {
                        Console.WriteLine("Estes são os seus Pokémons:");
                        foreach (var pokemonsdaLista in User.pokemonsAdotados)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(pokemonsdaLista.nome);
                            Console.WriteLine("");
                        }
                        Console.WriteLine("----------------------------- INSIRA O NOME DO POKÉMON QUE VOCÊ DESEJA INTERAGIR -----------------------------");
                        var nomedoPokemonInserido = Console.ReadLine();
                        var pokemonExiste = false;
                        foreach (var pokemons in User.pokemonsAdotados)
                        {
                            if (pokemons.nome == nomedoPokemonInserido)
                            {
                                pokemonExiste = true;
                                statusPokemonView.statusPokemon(pokemons); 
                                menuPokemonEscolhidoInteracaoView.menuPokemonEscolhidoInteracao(pokemons);
                            }
                        } if (pokemonExiste == false)
                        {
                            Console.WriteLine("Você não adotou nenhum Pokémon com esse nome");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Você ainda não adotou nenhum Pokémon :(");
                    }

                }
                else if (menuPrincipalSelecao == '3')
                {
                    Console.WriteLine("Até mais!...");
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
            } while (menuPrincipalSelecao != '3');

        }
    }
}                                                                                                                                                                                                                                                                                                                                   