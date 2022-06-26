using TraSua.Shared;
using Microsoft.AspNetCore.Components;
namespace TraSua.Client.Pages
{
    partial class CustomerEntry
    {
        [Parameter]
        public string Title { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public Customer Customer { get; set; } = default!;
        [Parameter]
        public EventCallback ValidSubmit { get; set; } = default!;
        [Parameter]
        public EventCallback<Customer> CustomerChanged { get; set; }
        private void FieldChanged(string fieldName)
        {
            CustomerChanged.InvokeAsync(Customer);
            isInvalid = !inputWather.Validate();
        }
        private InputWather inputWather = default!;
        bool isInvalid = true;
    }
}
