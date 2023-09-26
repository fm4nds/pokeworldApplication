using System;
using RestSharp;
using Newtonsoft.Json;
using PokeWorldApplication;


namespace PokeWorldApplication
{
    public class listarPokemonsView
    {
        public async static Task<List<string>> listarPokemons()
        {
            var options = new RestClientOptions("https://pokeapi.co")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);

            var requestAllPokemons = new RestRequest("/api/v2/pokemon", Method.Get);

            RestResponse response = await client.ExecuteAsync(requestAllPokemons);

            List<string> nomesPokemons = new List<string>();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var conteudo = JsonConvert.DeserializeObject<listadePokemons>(response.Content);
                foreach (var pokemon in conteudo.results)
                {
                    Console.WriteLine($"► {pokemon.name}");
                    nomesPokemons.Add(pokemon.name);
                }
            }
            else
            {
                Console.WriteLine("Erro");
            }

            return nomesPokemons;
        }
    }
}