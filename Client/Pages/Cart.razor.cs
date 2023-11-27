using gamersdomain.Client.Services.CartService;

namespace gamersdomain.Client.Pages
{
    public partial class Cart
    {
        public List<CartItem> CartItems { get; set; } = new();
        public decimal TotalPrice { get; set; } = 0;

        protected override async Task OnInitializedAsync()
        {
            CartItems = await CartService.GetCartItems();
            foreach (var item in CartItems)
            {
                IncreaseTotalPrice(item.Product.Price);
            }
        }

        private void IncreaseTotalPrice(decimal price)
        {
            TotalPrice += price;
        }
    }
}
