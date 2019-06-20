using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using HangfireTest.Localization.HangfireTest;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace HangfireTest.Pages
{
    public abstract class HangfireTestPageBase : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<HangfireTestResource> L { get; set; }
    }
}
