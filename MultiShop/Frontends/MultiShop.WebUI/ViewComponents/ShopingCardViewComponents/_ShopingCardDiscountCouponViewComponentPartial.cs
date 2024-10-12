using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.ViewComponents.ShopingCardViewComponents
{
    public class _ShopingCardDiscountCouponViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
