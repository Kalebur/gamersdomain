namespace gamersdomain.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorageService;

        public Task AddItemToCart(CartItem item)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var result = await _localStorageService.GetItemAsync<List<CartItem>>("gd-cart");
            return result;
        }

        public Task RemoveItemFromCart(CartItem item)
        {
            throw new NotImplementedException();
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
    }
}
