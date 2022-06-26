using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace TraSua.Client.Pages
{
    public class InputWather : ComponentBase
    {
        private EditContext editContext = default!;
        [CascadingParameter]
        public EditContext EditContext
        {
            get => this.editContext;
            set
            {
                this.editContext = value;
                EditContext.OnFieldChanged += async (Sender, e) =>
                {
                    await FieldChaged.InvokeAsync(e.FieldIdentifier.FieldName);
                };
            }
        }
        [Parameter]
        public EventCallback<string> FieldChaged { get; set; }
        public bool Validate()
            => EditContext?.Validate() ?? false;
    }
}
