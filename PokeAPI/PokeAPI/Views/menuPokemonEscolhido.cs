using PokeWorldApplication;
using System;
using System.Reflection.Metadata.Ecma335;

namespace PokeWorldApplication
{
    public class menuPokemonEscolhidoView
    {
        public async static Task<int> menuPokemonEscolhido(string nomePokemonEscolhido)
        {
            var opcaoPokemonEscolhido = 0;
            do
            {
                Console.WriteLine("-------------------------------- VOCÊ DESEJA: --------------------------------");
                Console.WriteLine($"1. Saber mais sobre {nomePokemonEscolhido}");
                Console.WriteLine($"2. Adotar {nomePokemonEscolhido}");
                Console.WriteLine("3. Voltar");
                opcaoPokemonEscolhido = Console.Read();
                Console.ReadLine();
                if (opcaoPokemonEscolhido == '1')
                {
                    await listarCaracteristicasView.listarCaracteristicas(nomePokemonEscolhido);

                }
                else if (opcaoPokemonEscolhido == '2')
                {
                    Console.WriteLine($"Parabéns! Você adotou {nomePokemonEscolhido}! O ovo está chocando, por favor, aguarde...");
                    string ovinho = @"                                                                                                                                                                          
                                                                 
                                                ##                  
                                            ##      ##              
                                          MM          ##            
                                        @@          ##  ##          
                                      ##            ##    ##        
                                                    mm              
                                    ##....                  ##      
                                    ........                        
                                  ####++....      ..##        ##    
                                  ##......##      ##  ......  ##    
                                  ##  ..      ##      ........##    
                                  ##              ##  ........##    
                                  ##                  ........##    
                                    ..          ##    ....----      
                                    ##..----  ##      ..----##      
                                      ##------............##        
                                        ##----....##....##          
                                          ##--..##..--##                              
                                                                                                                                                                                
                       ";
                    Console.WriteLine(ovinho);

                }
                else
                {
                    Console.WriteLine("Aguarde");
                }
            } while (opcaoPokemonEscolhido == '1');
            return (opcaoPokemonEscolhido);
        }
    }
}