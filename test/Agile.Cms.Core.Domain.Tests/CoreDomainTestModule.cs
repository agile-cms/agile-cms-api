using Volo.Abp.Modularity;

namespace Agile.Cms.Core;

[DependsOn(
    typeof(CoreDomainModule),
    typeof(CoreTestBaseModule)
)]
public class CoreDomainTestModule : AbpModule
{

}
