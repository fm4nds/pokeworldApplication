using System;
using PokeWorldApplication;

namespace PokeWorldApplication
{
public class menuPrincipalView
{
    public static int menuPrincipal(string nomeUsuario)
    {
        var selecaoMenuPrincipal = 0;
        Console.WriteLine("-------------------------------- MENU PRINCIPAL --------------------------------");
        Console.WriteLine($"{nomeUsuario}, você deseja:");
        Console.WriteLine("1. Adotar um Pokémon <3");
        Console.WriteLine("2. Ver meus Pokémons :D");
        Console.WriteLine("3. Sair");

        selecaoMenuPrincipal = Console.Read();
        Console.ReadLine();

        return (selecaoMenuPrincipal);

    }
}
}
