﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Data.Implementation
{
    public class IngredientService : IIngredientService
    {
        private const string uri = "https://localhost:5001/ingredient";
        private readonly HttpClient client;
        
        public IngredientService()
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) =>
            {
                return true;
            }; 
            client = new HttpClient(clientHandler);
        }
        
        public async Task<IList<Ingredient>> GetAllIngredientsAsync()
        {
            HttpResponseMessage response = await client.GetAsync(uri + "/getallingredients");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
            
            string result = await response.Content.ReadAsStringAsync();
            List<Ingredient> ingredients = JsonSerializer.Deserialize<List<Ingredient>>(result, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return ingredients;
        }

        public async Task<Ingredient> GetIngredientAsync(int ingredientId)
        {
            var ingredientAsJson = await client.GetStringAsync($"{uri}/getingredient?id={ingredientId}");
            var ingredient = JsonSerializer.Deserialize<Ingredient>(ingredientAsJson, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return ingredient;
        }

        public async Task CreateIngredientAsync(Ingredient ingredient)
        {
            var ingredientAsJson = JsonSerializer.Serialize(ingredient);
            HttpContent content = new StringContent(ingredientAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage response = await client.PostAsync(uri, content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task RemoveIngredientAsync(Ingredient ingredient)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(uri),
                Content = new StringContent(JsonSerializer.Serialize(ingredient), Encoding.UTF8, "application/json")
            };
            await client.SendAsync(request);
        }

        public async Task UpdateIngredientAsync(Ingredient ingredient)
        {
            // TODO
            var ingredientAsJson = JsonSerializer.Serialize(ingredient);
            HttpContent content = new StringContent(ingredientAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage response = await client.PutAsync($"{uri}/", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }
    }
}