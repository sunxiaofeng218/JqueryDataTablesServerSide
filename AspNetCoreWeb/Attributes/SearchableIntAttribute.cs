using JqueryDataTables.ServerSide.AspNetCoreWeb.Providers;
using System;

namespace JqueryDataTables.ServerSide.AspNetCoreWeb.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SearchableIntAttribute:SearchableAttribute
    {
        public SearchableIntAttribute()
        {
            ExpressionProvider = new IntSearchExpressionProvider();
        }
    }
}
