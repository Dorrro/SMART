using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Razor;

namespace SMART
{
    public class ViewLocationExpander : IViewLocationExpander
    {
        public void PopulateValues(ViewLocationExpanderContext context)
        {
        }

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context,
            IEnumerable<string> viewLocations)
        {
            return new[]
            {
                "Sites/{1}/Views/{0}.cshtml"
            };
        }
    }
}