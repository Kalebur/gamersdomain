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
            foreach (var item in CartItems)
            {
                IncreaseTotalPrice(item.Product.Price);
            }
        }

        private void IncreaseTotalPrice(decimal price)
        {
            TotalPrice += price;
        }

        private string GetTotalItemCostAsString(decimal price, int quantity)
        {
            CalculateTotalPrice();
            return GetCurrencyFormattedString(price * quantity);
        }

        private void CalculateTotalPrice()
        {
            TotalPrice = 0;
            foreach (var item in CartItems)
            {
                IncreaseTotalPrice(item.Product.Price * item.Quantity);
            }
        }

        private static string GetCurrencyFormattedString(decimal price)
        {
            return string.Format("{0:C}", price);
        }

        private async void RemoveItem(CartItem item)
        {
            await CartService.RemoveItemFromCart(item);
            CartItems = await CartService.GetCartItems();
            StateHasChanged();
        }

        private async Task UpdateLocalCart(ChangeEventArgs e)
        {
            Console.WriteLine(e.Value);
            Console.WriteLine(CartItems.First().Quantity);
            CartService.Items = CartItems;
            await CartService.SaveLocalCart();
        }

        private void Test()
        {
            Console.WriteLine("WOOF!");
        }
    }
}
