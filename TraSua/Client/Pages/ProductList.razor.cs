using Microsoft.AspNetCore.Components;
using TraSua.Shared;
using System.Collections.Generic;

namespace TraSua.Client.Pages
{
    partial class ProductList
    {
        [Parameter]
        public string Title { get; set; } = default!;
        [Parameter]
        public IEnumerable<Product> Items { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public EventCallback<Product> Selected { get; set; }

 
    }
}
