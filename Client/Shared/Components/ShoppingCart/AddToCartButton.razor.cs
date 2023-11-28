using Microsoft.AspNetCore.Components;

namespace gamersdomain.Client.Shared.Components.ShoppingCart
{
    public partial class AddToCartButton : IDisposable
    {
        [Parameter]
        public Product? Product { get; set; }

        public async Task AddToCart()
        {
            var cart = await CartService.GetCartItems();
            if (cart.Any(item => item.ProductId == Product!.ProductId))
            {
                var cartItem = cart.First(item => item.ProductId == Product!.ProductId);
                cartItem.Quantity++;
                await Console.Out.WriteLineAsync($"Product Quantity: {cartItem.Quantity}");
                await LocalStorage.SetItemAsync<List<CartItem>>("gd-cart", cart);
            }
            else
            {
                CartItem cartItem = new()
                {
                    Product = Product!,
                    Quantity = 1,
                    ProductId = Product!.ProductId
                };
                cartItem.TotalPrice = cartItem.Quantity * Product!.Price;
                await CartService.AddItemToCart(cartItem);
            }
        }

        public void Dispose()
        {
            CartService.OnChange -= StateHasChanged;
            GC.SuppressFinalize(this);
        }

        protected override void OnInitialized()
        {
            CartService.OnChange += StateHasChanged;
        }

    }
}
