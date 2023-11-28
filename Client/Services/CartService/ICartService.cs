namespace gamersdomain.Client.Services.CartService
{
    public interface ICartService
    {
        public Task AddItemToCart(CartItem item);
        public Task<List<CartItem>> GetCartItems();
        public Task RemoveItemFromCart(CartItem item);
        public Task RemoveItemFromCart(int productId);
        public Task<List<CartItem>> InitializeCart();
        public Task SaveLocalCart();
        public Task SaveLocalCart(List<CartItem> cart);
    }
}
