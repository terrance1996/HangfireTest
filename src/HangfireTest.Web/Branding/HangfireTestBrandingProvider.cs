using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace HangfireTest.Branding
{
    [Dependency(ReplaceServices = true)]
    public class HangfireTestBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "HangfireTest";
    }
}
