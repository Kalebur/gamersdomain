using Microsoft.AspNetCore.Components;

namespace gamersdomain.Client.Shared.Components.ShoppingCart
{
    public partial class AddToCartButton
    {
        [Parameter]
        public Product? Product { get; set; }

        public async Task AddToCart()
        {
            CartItem cartItem = new();
            cartItem.Product = Product!;
            cartItem.Quantity = 1;
            cartItem.ProductId = Product!.ProductId;
            cartItem.TotalPrice = cartItem.Quantity * Product!.Price;
            await CartService.AddItemToCart(cartItem);
        }

    }
}
