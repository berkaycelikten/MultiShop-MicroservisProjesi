using MultiShop.DtoLayer.OrderDtos.OrderingDtos;

namespace MultiShop.WebUI.Services.OrderServices.OrderOrderingServices
{
    public interface IOrderOrderingService
    {
        Task<List<ResultOrderingByUserIdto>> GetOrderingByUserId(string userId);
    }
}
