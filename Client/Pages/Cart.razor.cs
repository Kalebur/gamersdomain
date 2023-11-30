using Microsoft.AspNetCore.Components;

namespace gamersdomain.Client.Pages
{
    public partial class Cart
    {
        public List<CartItem> CartItems { get; set; } = new();
        public decimal TotalPrice { get; set; } = 0;

        protected override async Task OnInitializedAsync()
        {
            CartItems = await CartService.GetCartItems();
            CalculateTotalPrice();
        }

        private void IncreaseTotalPrice(decimal price)
        {
            TotalPrice += price;
        }

        private void CalculateTotalPrice()
        {
            TotalPrice = 0;
            foreach (var item in CartItems)
            {
                IncreaseTotalPrice(item.Product.Price * item.Quantity);
            }
            StateHasChanged();
        }

        private static string GetCurrencyFormattedString(decimal price)
        {
            return string.Format("{0:C}", price);
        }

        private async Task RemoveItem(CartItem item)
        {
            await CartService.RemoveItemFromCart(item);
            CartItems = await CartService.GetCartItems();
            CalculateTotalPrice();
            StateHasChanged();
        }
    }
}
