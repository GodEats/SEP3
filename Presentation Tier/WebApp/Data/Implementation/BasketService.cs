﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Microsoft.JSInterop;
using WebApp.Models;

namespace WebApp.Data
{
    public class BasketService : IBasketService
    {
        private ILocalStorageService localStorage;
        private IList<BasketItem> basketItems;
        private IRecipeService recipeService;
        private IList<Recipe> allRecipes;
        private int localStorageSize;

        public BasketService(ILocalStorageService localStorage)
        {
            this.localStorage = localStorage;
            basketItems = new List<BasketItem>();
            recipeService = new RecipeService();
        }

        public async Task<IList<BasketItem>> GetAllBasketItems()
        {
            try
            {
                localStorageSize = await localStorage.LengthAsync();
                
                for (int i = 0; i < localStorageSize; i++)
                {
                    var key = await localStorage.KeyAsync(i);
                    var item = await localStorage.GetItemAsync<string>(key);
                    BasketItem basketItem = JsonSerializer.Deserialize<BasketItem>(item);
                    basketItems.Add(basketItem);
                }
                return basketItems;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public async Task AddRecipe(BasketItem basketItem)
        {
            try
            {
                string basketItemAsJson = JsonSerializer.Serialize(basketItem);
                await localStorage.SetItemAsync(basketItem.RecipeId.ToString(), basketItemAsJson);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public async Task RemoveRecipe(BasketItem basketItem)
        {
            try
            {
                // localStorageSize--;
                await localStorage.RemoveItemAsync(basketItem.RecipeId.ToString());
                // await jsRuntime.InvokeVoidAsync("localStorage.setItem", "localStorageSize", localStorageSize.ToString());
                // await jsRuntime.InvokeVoidAsync("localStorage.removeItem", basketItem.RecipeId.ToString(), basketItem.Amount.ToString());
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        public async Task Clear()
        {
            await localStorage.ClearAsync();
        }
    }
}