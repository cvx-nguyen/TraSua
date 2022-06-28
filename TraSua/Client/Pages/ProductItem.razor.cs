using Microsoft.AspNetCore.Components;
using TraSua.Shared;

namespace TraSua.Client.Pages
{
    partial class ProductItem
    {
        [Parameter]
        public Product product { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public EventCallback<Product> Selected { get; set; }

        private string PearlImage(Pearl pearl)
            => $"images/{pearl.ToString().ToLower()}.png";
    }
}
