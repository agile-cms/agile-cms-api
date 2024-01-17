using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Agile.Cms.Core;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CoreHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class CoreConsoleApiClientModule : AbpModule
{

}
