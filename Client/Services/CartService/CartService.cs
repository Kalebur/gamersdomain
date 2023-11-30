namespace gamersdomain.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorageService;
        private List<CartItem> _items = new();

        public List<CartItem> Items
        {
            get { return _items; }
            set { _items = value; }
        }


        public event Action? OnChange;

        public async Task AddItemToCart(CartItem item)
        {
            Items.Add(item);
            await SaveLocalCart();
            OnChange!.Invoke();
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
                var cart = Items;
                cart = cart.Where(item => item.ProductId != productId).ToList();
                Items = cart;
                await SaveLocalCart();
            }
            OnChange!.Invoke();
        }

        public async Task<List<CartItem>> InitializeCart()
        {
            bool cartExists = await CartExists();
            if (!cartExists)
            {
                await SaveLocalCart();
            }

            var response = await GetCartItems();
            Items = response;
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

            if (Items.Any(p => p.ProductId == productId)) return true;
            return false;
        }

        public async Task SaveLocalCart()
        {
            await _localStorageService.SetItemAsync<List<CartItem>>("gd-cart", Items);
        }
    }
}
