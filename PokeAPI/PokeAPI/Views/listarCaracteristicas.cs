using System;
using RestSharp;
using Newtonsoft.Json;
using PokeWorldApplication;

namespace PokeWorldApplication
{
    public class listarCaracteristicasView
    {
        public async static Task listarCaracteristicas(string nomedoPokemon)
        {
            var options = new RestClientOptions("https://pokeapi.co")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);

            var requestAllPokemons = new RestRequest($"/api/v2/pokemon/{nomedoPokemon}", Method.Get);

            RestResponse response = await client.ExecuteAsync(requestAllPokemons);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var caracteristicas = JsonConvert.DeserializeObject<caracteristicasP>(response.Content);
                Console.WriteLine($"Nome:{nomedoPokemon}");
                Console.WriteLine($"Peso:{caracteristicas.weight}");
                Console.WriteLine($"Altura:{caracteristicas.height}");
                foreach (var pokemon in caracteristicas.abilities)
                {
                    Console.WriteLine($"Habilidade:{pokemon.ability.name}");
                }
            }
            else
            {
                Console.WriteLine("Erro");
            }
        }
    }
}