using System.Reflection.Metadata.Ecma335;

namespace gamersdomain.Client.Shared.Components.ShoppingCart
{
    public partial class CartDisplay : IDisposable
    {
        public int TotalItems { get; set; }
        public decimal TotalPrice { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await CartService.InitializeCart();
        }

        protected override void OnInitialized()
        {
            CartService.OnChange += StateHasChanged;
        }

        public void Dispose()
        {
            CartService.OnChange -= StateHasChanged;
            GC.SuppressFinalize(this);
        }
    }
}
