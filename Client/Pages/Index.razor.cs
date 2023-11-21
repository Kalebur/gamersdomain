using Microsoft.AspNetCore.Components;

namespace gamersdomain.Client.Pages
{
    public partial class Index
    {
        [Parameter]
        public string? CategoryName { get; set; } = null;
        public List<Product>? Products { get; set; }

        public async Task UpdateProductListing()
        {
            var result = await ProductService.GetProductsByCategory(CategoryName!);
            Products = result;
            StateHasChanged();
        }

        protected override async Task OnParametersSetAsync()
        {
            var result = await ProductService.GetProductsByCategory(CategoryName!);
            Products = result;
        }
    }
}
