using System;
using PokeWorldApplication;

namespace PokeWorldApplication
{
	public class porParaDormirPokemonView
    {
        public static void porParaDormirPokemon(pokemonAdotado pokemon)
        {

            Console.WriteLine($"Pôndo {pokemon.nome} para dormir...");
            string dormir = @"
        
                                                                                      
                                                      ################              
                                              ########                ##                
                                            ##                          ##              
                                          ##                              ##            
                                      ####                       ######      ##        
                                      ##                ######      ##          #        
                                    ##        ########      ##    ##            ##      
                                    ##            ##      ##    ########        ##      
                                    ##           ##      ######                 #         
                                      ##        ######                        ##        
                                        ##                                   ##          
                                           #                               ##            
                                            ##                        ####              
                                                ##::##        ########                  
                                                       mm####                            
                                                ###
                                              ##   ##                                        
                                              ##   ##                                                     
                                                ###   
                                            ###
                                          ##   ##                                        
                                          ##   ##                                                     
                                            ###               
                                                                                                ";
            Console.WriteLine(dormir);
            if (pokemon.nivelDeSono == 0)
            {
                Console.WriteLine($"{pokemon.nome} não pode dormir agora, pois seu nível de sono está muito baixo");
            }
            pokemon.humor = Math.Max(pokemon.humor - 1, 0);
            pokemon.nivelDeSono = Math.Max(pokemon.nivelDeSono - 3, 0);
            pokemon.alimentacao = Math.Max(pokemon.alimentacao - 2, 0);
            statusPokemonView.statusPokemon(pokemon);
        }
    }
}
