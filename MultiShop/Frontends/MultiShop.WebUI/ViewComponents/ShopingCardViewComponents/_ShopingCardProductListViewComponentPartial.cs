﻿using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.BasketServices;

namespace MultiShop.WebUI.ViewComponents.ShopingCardViewComponents
{
    public class _ShopingCardProductListViewComponentPartial:ViewComponent
    {
        private readonly IBasketService _basketService;

        public _ShopingCardProductListViewComponentPartial(IBasketService basketService)
        {
            _basketService = basketService;
        }

        public async Task< IViewComponentResult> InvokeAsync()
        {
            var basketTotal = await _basketService.GetBasket();
            var basketItems = basketTotal.BasketItems; 
            return View(basketItems);
        }
    }
}
