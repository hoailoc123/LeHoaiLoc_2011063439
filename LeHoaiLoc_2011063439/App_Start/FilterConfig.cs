﻿using System.Web;
using System.Web.Mvc;

namespace LeHoaiLoc_2011063439
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
