using Microsoft.AspNetCore.Components;

namespace gamersdomain.Client.Shared.Components.Products
{
    public partial class ProductListing
    {
        [Parameter]
        public Product? Product { get; set; }
        [Parameter]
        public string Name { get; set; } = string.Empty;
        [Parameter]
        public string Description { get; set; } = string.Empty;
        [Parameter]
        public string Price { get; set; } = string.Empty;
        [Parameter]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
