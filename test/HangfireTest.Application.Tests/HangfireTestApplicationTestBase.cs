using Volo.Abp;

namespace HangfireTest
{
    public abstract class HangfireTestApplicationTestBase : AbpIntegratedTest<HangfireTestApplicationTestModule>
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}
