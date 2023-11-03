using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace gamersdomain.Client.Shared.Components.Products
{
    public partial class ProductList
    {
        [Parameter]
        public List<Product>? Products { get; set; } = null;

        //protected override async Task OnInitializedAsync()
        //{
        //    Products = await ProductService.GetAllProducts();
        //}
    }
}
