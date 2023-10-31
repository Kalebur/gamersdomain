using Microsoft.AspNetCore.Components;

namespace gamersdomain.Client.Shared.Components.HeroProduct
{
    public partial class HeroProduct
    {
        [Parameter]
        public string? ImageUrl { get; set; } = string.Empty;

        [Parameter]
        public string? ProductName { get; set; } = string.Empty;
        [Parameter]
        public string? Description { get; set; } = string.Empty;
        [Parameter]
        public string? Price { get; set; } = string.Empty;
    }
}
