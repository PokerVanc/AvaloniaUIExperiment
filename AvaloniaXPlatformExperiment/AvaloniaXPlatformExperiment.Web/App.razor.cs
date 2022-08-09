using Avalonia.Web.Blazor;

namespace AvaloniaXPlatformExperiment.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        
        WebAppBuilder.Configure<AvaloniaXPlatformExperiment.App>()
            .SetupWithSingleViewLifetime();
    }
}