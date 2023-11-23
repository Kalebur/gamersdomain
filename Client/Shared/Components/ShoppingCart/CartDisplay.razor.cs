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
            bool cartExists = await localStorage.ContainKeyAsync("gd-cart");
            if (!cartExists)
            {
                await localStorage.SetItemAsync<List<CartItem>>("gd-cart", Items);
            }
            else
            {
                List<CartItem> itemsFromCart = await localStorage.GetItemAsync<List<CartItem>>("gd-cart");
                Console.WriteLine($"Item Count: {itemsFromCart.Count}");
            }
        }
    }
}
