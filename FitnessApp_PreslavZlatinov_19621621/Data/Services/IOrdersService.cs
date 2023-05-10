using FitnessApp_PreslavZlatinov_19621621.Models;

namespace FitnessApp_PreslavZlatinov_19621621.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
    }
}
