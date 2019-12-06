namespace FormValidation
{
    using Microsoft.AspNetCore.Components;

    public partial class SurveyPromptBase : ComponentBase
    {
        // Demonstrates how a parent component can supply parameters
        [Parameter]
        public string Title { get; set; }
    }
}