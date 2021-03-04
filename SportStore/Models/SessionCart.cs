using System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using SportStore.Infrastructure;
using SportStore.Models.ViewModels;

namespace SportStoreDal.Models
{
    public class SessionCart : ShoppingCart
    {
        
        public static ShoppingCart GetShoppingCart(IServiceProvider services)
        {
            ISession session =
                services.GetRequiredService<IHttpContextAccessor>()?
                    .HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("ShoppingCart") ?? new SessionCart();
            cart.Session = session;

            return cart;
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(ProductViewModel product, int quantity)
        {
            base.AddItem(product, quantity);
            Session.SetJson("ShoppingCart", this);
        }
        public override void RemoveRecord(int productId)
        {
            base.RemoveRecord(productId);
            Session.SetJson("ShoppingCart", this);
        }
        public override void Clear()
        {
            base.Clear();
            Session.Remove("ShoppingCart");
        }

    }
}
