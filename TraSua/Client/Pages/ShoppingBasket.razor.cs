using Microsoft.AspNetCore.Components;
using TraSua.Shared;
using System;
using System.Collections.Generic;
using System.Linq;


namespace TraSua.Client.Pages
{
    partial class ShoppingBasket
    {
        [Parameter]
        public IEnumerable<int> Orders { get; set; } = default!;
        [Parameter]
        public EventCallback<int> Selected { get; set; } = default!;
        [Parameter]
        public Func<int, Product> GetPizzaFromId { get; set; } = default!;
        private IEnumerable<(Product product, int pos)> Product { get; set; } = default!;
        private decimal TotalPrice { get; set; } = default!;
        protected override void OnParametersSet()
        {
            Product = Orders.Select((id, pos)
                => (pizza: GetPizzaFromId(id), pos: pos));
            TotalPrice = Product.Select(tuple
                => tuple.product.Price).Sum();
        }
    }
}
