#pragma checksum "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4f0f392caa99ba80ef3195ac0c7fbe3d2796df8"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages.Admin.AddView
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 2 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
using WebApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
           [Authorize(Policy = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addrecipe")]
    public partial class AddRecipe : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "id", "leftblock");
            __builder.AddMarkupContent(4, "<h3>Add Recipe</h3>\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                      newRecipe

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                                                 AddNewRecipe

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, " Name:<br>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                                    newRecipe.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newRecipe.Name = __value, newRecipe.Name))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newRecipe.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, " Picture (URL):<br>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                                    newRecipe.Image

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newRecipe.Image = __value, newRecipe.Image))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newRecipe.Image));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.AddMarkupContent(31, " Description:<br>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(32);
                __builder2.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                                        newRecipe.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newRecipe.Description = __value, newRecipe.Description))));
                __builder2.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newRecipe.Description));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\n        ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, " Minutes to make:<br>\n            ");
                __Blazor.WebApp.Pages.Admin.AddView.AddRecipe.TypeInference.CreateInputNumber_0(__builder2, 40, 41, 
#nullable restore
#line 27 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                                      newRecipe.MinutesToMake

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newRecipe.MinutesToMake = __value, newRecipe.MinutesToMake)), 43, () => newRecipe.MinutesToMake);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\n        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, " Type:<br>\n            ");
                __Blazor.WebApp.Pages.Admin.AddView.AddRecipe.TypeInference.CreateInputSelect_1(__builder2, 48, 49, 
#nullable restore
#line 30 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                                      newRecipe.Type

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newRecipe.Type = __value, newRecipe.Type)), 51, () => newRecipe.Type, 52, (__builder3) => {
#nullable restore
#line 31 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                 foreach (var type in Enum.GetValues(typeof(NutritionType)))
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(53, "option");
                    __builder3.AddAttribute(54, "value", 
#nullable restore
#line 33 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                                    type

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(55, 
#nullable restore
#line 33 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                                           type

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 34 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\n        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.AddMarkupContent(59, " Price:<br>\n            ");
                __Blazor.WebApp.Pages.Admin.AddView.AddRecipe.TypeInference.CreateInputNumber_2(__builder2, 60, 61, 
#nullable restore
#line 38 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                                      newRecipe.Price

#line default
#line hidden
#nullable disable
                , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newRecipe.Price = __value, newRecipe.Price)), 63, () => newRecipe.Price);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\n        ");
                __builder2.AddMarkupContent(65, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Add recipe</button></p>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n    ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "id", "rightblock");
            __builder.AddMarkupContent(69, "<h4>Add Ingredients</h4>\n        ");
            __builder.AddMarkupContent(70, "<b>Added:</b>");
#nullable restore
#line 48 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
         if (recipeIngredients == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(71, "<p><em>Loading...</em></p>");
#nullable restore
#line 53 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
        }
        else if (!recipeIngredients.Any())
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(72, "<p><em>No ingredients added yet.</em></p>");
#nullable restore
#line 59 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
             foreach (Ingredient item in recipeIngredients)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(73, "ul");
            __builder.OpenElement(74, "li");
            __builder.AddContent(75, 
#nullable restore
#line 65 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                          item.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(76, " ");
            __builder.AddContent(77, 
#nullable restore
#line 65 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                                         item.UnitOfMeasure

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(78, " ");
            __builder.AddContent(79, 
#nullable restore
#line 65 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                                                             item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 67 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(80);
            __builder.AddAttribute(81, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 69 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                          ingredient

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 69 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                                                      AddIngredientToRecipe

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(83, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(84);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(86);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\n            ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "form-group");
                __builder2.AddMarkupContent(90, " Ingredients: <br>\n                ");
                __Blazor.WebApp.Pages.Admin.AddView.AddRecipe.TypeInference.CreateInputSelect_3(__builder2, 91, 92, 
#nullable restore
#line 73 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                                          ingredientName

#line default
#line hidden
#nullable disable
                , 93, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ingredientName = __value, ingredientName)), 94, () => ingredientName, 95, (__builder3) => {
#nullable restore
#line 74 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                     foreach (Ingredient item in ingredients)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(96, "option");
                    __builder3.AddAttribute(97, "value", 
#nullable restore
#line 76 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                                        item

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(98, 
#nullable restore
#line 76 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                                               item.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(99, " - (");
                    __builder3.AddContent(100, 
#nullable restore
#line 76 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                                                             item.UnitOfMeasure

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(101, ")");
                    __builder3.CloseElement();
#nullable restore
#line 77 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\n            ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "form-group");
                __builder2.AddMarkupContent(105, " Quantity:<br>\n                ");
                __Blazor.WebApp.Pages.Admin.AddView.AddRecipe.TypeInference.CreateInputNumber_4(__builder2, 106, 107, 
#nullable restore
#line 81 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
                                          ingredientQuantity

#line default
#line hidden
#nullable disable
                , 108, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ingredientQuantity = __value, ingredientQuantity)), 109, () => ingredientQuantity);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\n            ");
                __builder2.AddMarkupContent(111, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Add</button></p>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "/Users/satish/Downloads/SEP3/Presentation Tier/WebApp/Pages/Admin/AddView/AddRecipe.razor"
       
    private Recipe newRecipe;
    private Ingredient ingredient;
    private int ingredientQuantity;
    private string ingredientName;
    private IList<Ingredient> ingredients = new List<Ingredient>();
    private IList<Ingredient> recipeIngredients = new List<Ingredient>();

    protected override async Task OnInitializedAsync()
    {
        SetupIngredient();
        SetupNewRecipe();
        ingredients = await IngredientService.GetAllIngredientsAsync();
        await base.OnInitializedAsync();
    }

    private async Task SetupNewRecipe()
    {
        newRecipe = new Recipe();
        newRecipe.Id = 0;
        newRecipe.Name = "";
        newRecipe.Image = "";
        newRecipe.Description = "";
        newRecipe.Price = 0;
        newRecipe.MinutesToMake = 0;
    }

    private async Task SetupIngredient()
    {
        ingredient = new Ingredient("", "", 0);
    }

    private void AddNewRecipe()
    {
        newRecipe.Ingredient = recipeIngredients;
        RecipeService.CreateRecipeAsync(newRecipe);
        NavigationManager.NavigateTo("/managerecipes");
    }

    private void AddIngredientToRecipe()
    {
        ingredient = ingredients.Single(i => i.Name.Equals(ingredientName));
        ingredient.Quantity = ingredientQuantity;
        recipeIngredients.Add(ingredient);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IIngredientService IngredientService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecipeService RecipeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.WebApp.Pages.Admin.AddView.AddRecipe
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
