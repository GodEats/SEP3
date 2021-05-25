// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApp.Pages.Admin.ListView
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/ListView/ManageRecipes.razor"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/ListView/ManageRecipes.razor"
using WebApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/ListView/ManageRecipes.razor"
           [Authorize(Policy = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/managerecipes")]
    public partial class ManageRecipes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/ListView/ManageRecipes.razor"
       
    private IList<Recipe> allRecipes = new List<Recipe>();
    private IList<Recipe> recipesToShow = new List<Recipe>();

    private string? filterByName = "";
    private int? filterByCalories = 0;
    private NutritionType? filterByType;


    protected override async Task OnInitializedAsync()
    {
        allRecipes = await RecipeService.GetAllRecipesAsync();
        recipesToShow = allRecipes;
    }

    private void RemoveRecipe(int Id)
    {
        Recipe recipeToRemove = allRecipes.First(t => t.Id == Id);
        RecipeService.RemoveRecipeAsync(recipeToRemove);
        allRecipes.Remove(recipeToRemove);
        recipesToShow.Remove(recipeToRemove);
    }

    private void FilterByName(ChangeEventArgs changeEventArgs)
    {
        filterByName = null;
        try
        {
            filterByName = changeEventArgs.Value.ToString();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        ExecuteFilter();
    }

    private void FilterByCalories(ChangeEventArgs changeEventArgs)
    {
        filterByCalories = null;
        try
        {
            filterByCalories = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        ExecuteFilter();
    }

    // private void FilterByType(ChangeEventArgs changeEventArgs)
    // {
    //     filterByType = null;
    //     try
    //     {
    //         filterByType = changeEventArgs.Value.ToString();
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e);
    //     }
    //     ExecuteFilter();
    // }

    private void ExecuteFilter()
    {
        recipesToShow = allRecipes.Where(t =>
            (!filterByName.Equals("") && t.Name.Contains(filterByName) || filterByName.Equals("")) &&
            (filterByCalories != 0 && t.Calories == filterByCalories || filterByCalories == null)
            ).ToList();
    }

    private void EditRecipe(int id)
    {
        NavigationManager.NavigateTo($"/editrecipe/{id}");
    }

    private void AddRecipe()
    {
        NavigationManager.NavigateTo("/addrecipe");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecipeService RecipeService { get; set; }
    }
}
#pragma warning restore 1591
