using WebShop.Shared;
using WebShop.Shared.Models;

namespace WebShop.Server.Services.CartService;

public interface ICartService
{
    Task<ServiceResponse<List<CartProductResponse>>> GetCartProducts(List<CartItem> cartItems);
}
