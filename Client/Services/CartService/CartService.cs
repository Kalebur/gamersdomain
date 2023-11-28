namespace gamersdomain.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorageService;

        public async Task AddItemToCart(CartItem item)
        {
            var cart = await GetCartItems();
            cart.Add(item);
            await _localStorageService.SetItemAsync<List<CartItem>>("gd-cart", cart);
            await Console.Out.WriteLineAsync(cart.Count.ToString());
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var result = await _localStorageService.GetItemAsync<List<CartItem>>("gd-cart");
            return result;
        }

        public async Task RemoveItemFromCart(CartItem item)
        {
            await RemoveItemFromCart(item.ProductId);

        }

        public async Task RemoveItemFromCart(int productId)
        {
            bool itemInCart = await ItemExistsInCart(productId);
            if (itemInCart)
            {
                var cart = await GetCartItems();
                cart = cart.Where(item => item.ProductId != productId).ToList();
                await SaveLocalCart(cart);
            }
        }

        public async Task<List<CartItem>> InitializeCart()
        {
            bool cartExists = await CartExists();
            if (!cartExists)
            {
                await _localStorageService.SetItemAsync<List<CartItem>>("gd-cart", new());
            }

            var response = await GetCartItems();
            return response;
        }

        public CartService(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        private async Task<bool> CartExists()
        {
            bool response = await _localStorageService.ContainKeyAsync("gd-cart");
            return response;
        }

        private async Task<bool> ItemExistsInCart(int productId)
        {
            bool cartExists = await CartExists();
            // Item can't be in the cart if there is no cart
            if (!cartExists) return false;

            var cart = await GetCartItems();
            if (cart.Any(p => p.ProductId == productId)) return true;
            return false;
        }

        public async Task SaveLocalCart()
        {
            await _localStorageService.SetItemAsync<List<CartItem>>("gd-cart", new());
        }

        public async Task SaveLocalCart(List<CartItem> cart)
        {
            await _localStorageService.SetItemAsync<List<CartItem>>("gd-cart", cart);
        }
    }
}
