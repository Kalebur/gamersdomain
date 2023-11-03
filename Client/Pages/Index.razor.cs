using Microsoft.AspNetCore.Components;

namespace gamersdomain.Client.Pages
{
    public partial class Index
    {
        [Parameter]
        public string? CategoryName { get; set; }
    }
}
