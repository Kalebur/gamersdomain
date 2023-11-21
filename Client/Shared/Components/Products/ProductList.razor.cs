using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace gamersdomain.Client.Shared.Components.Products
{
    public partial class ProductList
    {
        [Parameter]
        public List<Product>? Products { get; set; } = null;
        [Parameter]
        public string? ProductCategory { get; set; }

        //protected override async Task OnInitializedAsync()
        //{
        //    if (ProductCategory is null)
        //    {
        //        ProductCategory = "All Products";
        //        Products = await ProductService.GetAllProducts();
        //    }
        //}

        protected override async Task OnParametersSetAsync()
        {
            if (ProductCategory is null)
            {
                ProductCategory = "All Products";
                Products = await ProductService.GetAllProducts();
            } else
            {
                Products = await ProductService.GetProductsByCategory(ProductCategory);
            }
        }
    }
}
