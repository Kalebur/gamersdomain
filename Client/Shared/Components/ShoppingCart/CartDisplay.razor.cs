using System.Reflection.Metadata.Ecma335;

namespace gamersdomain.Client.Shared.Components.ShoppingCart
{
    public partial class CartDisplay
    {
        public int TotalItems { get; set; }
        public decimal TotalPrice { get; set; }
        public List<CartItem> Items { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            Items = await CartService.InitializeCart();
        }
    }
}
