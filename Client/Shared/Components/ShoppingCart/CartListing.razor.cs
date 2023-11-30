using Microsoft.AspNetCore.Components;
using System.Reflection.Metadata.Ecma335;

namespace gamersdomain.Client.Shared.Components.ShoppingCart
{
    public partial class CartListing
    {
        [Parameter]
        public CartItem CartItem { get; set; } = new();
        [Parameter]
        public Action? TotalPriceHandler { get; set; }
        [Parameter]
        public EventCallback HandleRemove { get; set; }

        public async void HandleChange(ChangeEventArgs e)
        {
            int newQuantity;
            try
            {
                newQuantity = int.Parse(e.Value!.ToString()!);
            }
            catch
            {
                newQuantity = 1;
            }
            if (newQuantity < 1)
            {
                e.Value = 1;
                newQuantity = 1;
            }
            CartItem.Quantity = newQuantity;
            CartService.Items.Where(item => item.ProductId == CartItem.ProductId).First().Quantity = CartItem.Quantity;
            TotalPriceHandler!.Invoke();
            await CartService.SaveLocalCart();
            StateHasChanged();
        }

        private string CalculateTotalCost()
        {
            decimal totalCost = CartItem.Quantity * CartItem.Product.Price;
            return string.Format("{0:C}", totalCost);
        }
    }
}
