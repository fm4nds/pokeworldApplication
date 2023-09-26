using System;


namespace PokeWorldApplication
{
    public class boasVindasView
    {
        public static string boasVindas()
        {
            string logo = @"  
                                                                           ####                                                              
                                                                                                                        
                      ##########        ########        ##    mm##::    ########    ######      ####++      ########        ####    ::##    
                      ####  --##@@    ####----####      ##    ####      ##MM        ######      ####++    ####::--####      ####++  ::##    
                      ####    ####  mm##        ##@@    ##  ####        ##MM        ######::  mm####++  ::##        ####    ######  ::##    
                      ##########    ####        ####    ######          ########    ####@@##  ##--##++  MM##        ####    ##--####::##    
                      ####          ::##        ##MM    ##  ####        ##MM        ####  ##  ##  ##++  --##--      ##@@    ##--  ######    
                      ####            ############      ##    ####      ####::::    ####  ####@@  ##++    ######@@####      ##--  --####    
                      ####              @@####@@        ##    ..####    ########    ####  ..##    ##++      ++######        ##--    ####    
                ";
            Console.WriteLine(logo);
            Console.WriteLine("Olá!");
            Console.WriteLine("Seja bem vindo! Qual o seu nome?");
            var nomeUsuario = Console.ReadLine();

            return (nomeUsuario);
        }
    }
}