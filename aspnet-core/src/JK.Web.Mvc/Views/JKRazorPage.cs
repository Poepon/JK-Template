using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace JK.Web.Views
{
    public abstract class JKRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        public string CurrentPageName
        {
            set { ViewBag.CurrentPageName = value; }
            get { return ViewBag.CurrentPageName; }
        }

        protected JKRazorPage()
        {
            LocalizationSourceName = JKConsts.LocalizationSourceName;
        }
    }
}
