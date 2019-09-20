using Abp;

namespace JK
{
    public abstract class JKServiceBase : AbpServiceBase
    {
        protected JKServiceBase()
        {
            LocalizationSourceName = JKConsts.LocalizationSourceName;
        }
    }
}
