﻿using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace HelpDesk.Web
{
    [Dependency(ReplaceServices = true)]
    public class HelpDeskBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "HelpDesk";
    }
}
