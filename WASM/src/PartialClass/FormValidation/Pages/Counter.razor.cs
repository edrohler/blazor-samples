namespace FormValidation
{
    using Microsoft.AspNetCore.Components;

    public partial class CounterBase : ComponentBase
    {
        protected int currentCount = 0;

        protected void IncrementCount()
        {
            currentCount++;
        }
    }
}