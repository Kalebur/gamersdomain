using Microsoft.AspNetCore.Components;
using System.Reflection.Metadata.Ecma335;

namespace gamersdomain.Client.Shared.Components.ShoppingCart
{
    public partial class CartListing
    {
        [Parameter]
        public CartItem CartItem { get; set; } = new();

        public async void HandleChange(ChangeEventArgs e)
        {
            int newQuantity = int.Parse(e.Value!.ToString()!);
            if (newQuantity < 1)
            {
                e.Value = 1;
                newQuantity = 1;
            }
            CartItem.Quantity = newQuantity;
            CartService.Items.Where(item => item.ProductId == CartItem.ProductId).First().Quantity = CartItem.Quantity;
            await CartService.SaveLocalCart();
            await Console.Out.WriteLineAsync("WOOF!");
            await Console.Out.WriteLineAsync($"The current WOOF! counter is: {e.Value}");
            await Console.Out.WriteLineAsync($"The current QUANTITY is: {CartItem.Quantity}");
        }

        private string CalculateTotalCost()
        {
            decimal totalCost = CartItem.Quantity * CartItem.Product.Price;
            return string.Format("{0:C}", totalCost);
        }
    }
}
