using System.Text.Json.Serialization;

namespace gamersdomain.Shared
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = new();
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
