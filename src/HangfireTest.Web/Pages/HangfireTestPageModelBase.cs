using HangfireTest.Localization.HangfireTest;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace HangfireTest.Pages
{
    public abstract class HangfireTestPageModelBase : AbpPageModel
    {
        protected HangfireTestPageModelBase()
        {
            LocalizationResourceType = typeof(HangfireTestResource);
        }
    }
}