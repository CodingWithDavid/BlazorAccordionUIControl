using Microsoft.AspNetCore.Components;

namespace AccordianComponent.Components.UI.Accordion;

public class AccordionItem
{
    public string Label { get; set; } = string.Empty;
    public RenderFragment Content { get; set; } = default!;

    public bool IsExpanded { get; set; }
}
