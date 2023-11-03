using gamersdomain.Client.Services.CategoryService;

namespace gamersdomain.Client.Shared
{
    public partial class ShopNavMenu
    {

        public List<Category> Categories { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            Categories = await CategoryService.GetAllCategories();
        }
    }
}
