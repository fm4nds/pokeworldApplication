using System;
using RestSharp;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Markup;
using System.Net.NetworkInformation;

namespace PokeWorldApplication
{
    class PokeWorld
    {
        static async Task Main(string[] args)
        {
            user User = new user();
            User.pokemonsAdotados = new List<pokemonAdotado>();
            var nomeUsuario = boasVindasView.boasVindas();
            User.nome = nomeUsuario;
            await menuController.Menu(User);

        }
    }
}