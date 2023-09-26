using System;
using PokeWorldApplication;

namespace PokeWorldApplication
{
	public class alimentarPokemonView
    {
        public static void alimentarPokemon(pokemonAdotado pokemon)
        {

            Console.WriteLine($"Alimentando {pokemon.nome}...");
            string alimentar = @"
                                     
                                    ##########      ##                          
                                              MM..@@                            
                                    ##  @@##    ####                            
                                    ....    ##mm  ##                            
                                      ##        ####                            
                                        @@##++++####                            
                                                  ##                            
                                    ##  MM####  ####@@  ####++..##              
                                  ##      ++      ##      ##      ##            
                                  mm        --            ++      ##            
                                  ##      ++      ##      ##      ##            
                                    ##  MM####  ##@@@@  ####++  ##              
                                      MM      ..      MM      ##                
                                      ++              ++      ##                
                                      ##      ##      ##      ##                
                                        ######  ######  ######                  
                                          ..              mm                    
                                          mm      ++      ##                    
                                          ##      ##    ..@@                    
                                            ..##..  ::##                        
                                               #      ##                        
                                              ##      ##                        
                                              ::##::##                                                                                              
                                                           ";
            Console.WriteLine(alimentar);
            if (pokemon.alimentacao == 10)
            {
                Console.WriteLine($"{pokemon.nome} não pode comer agora, pois seu nível de alimentação está muito alto");
            }
            pokemon.humor = Math.Min(pokemon.humor + 2, 10);
            pokemon.nivelDeSono = Math.Min(pokemon.nivelDeSono + 3, 10);
            pokemon.alimentacao = Math.Min(pokemon.alimentacao + 2, 10);
            statusPokemonView.statusPokemon(pokemon);
        }
    }
}
