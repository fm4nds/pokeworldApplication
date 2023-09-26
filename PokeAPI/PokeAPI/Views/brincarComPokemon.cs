using System;
using PokeWorldApplication;

namespace PokeWorldApplication
{
	public class brincarComPokemonView

    {
        public static void brincarComPokemon(pokemonAdotado pokemon)
        {

            Console.WriteLine($"Brincando com {pokemon.nome}...");
            string brincar = @"
                                                            
                                            ##                                          
                                        #########                        ####            
                                          ####                                          
                                                            
                                                                                ###      
                                ####                  ########                ########  
                                ####            ######        ######            ####    
                                            ####                    ####                
                                          ##                            ##              
                                        ##                                ##            
                                      ##                                    ##          
                                    ####      ####                ####      ####        
                                    ##      ##    ##            ##    ##      ##        
                                  ####    ##        ##        ##        ##    ##        
                                  ##      ##        ##        ##        ##      ##      
                                  ##                                            ##      
                                  ##                                            ##      
                                  ##      ################################      ##      
                                  ##      ##                            ##      ##      
                                  ##      ##                            ##      ##      
                                  ##      ##        ############        ##      ##      
                                    ##      ##    ####        ####    ##      ##        
                                    ##      ######                ######      ##        
                                      ##      ####                ####      ##          
                                      ####      ######        ######      ####          
                                        ####        ############        ####            
                                          ####                        ####              
                                            ######                ######                
                                                ####################                    ";
            Console.WriteLine(brincar);
            if (pokemon.humor == 10)
            {
                Console.WriteLine($"{pokemon.nome} não pode brincar agora, pois seu nível de humor está muito alto");
            }
            pokemon.humor = Math.Min(pokemon.humor + 2, 10);
            pokemon.nivelDeSono = Math.Min(pokemon.nivelDeSono + 2, 10);
            pokemon.alimentacao = Math.Max(pokemon.alimentacao - 1, 0);
            statusPokemonView.statusPokemon(pokemon);
        }
    }
}
