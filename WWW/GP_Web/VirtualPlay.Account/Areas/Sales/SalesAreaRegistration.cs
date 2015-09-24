﻿using System.Web.Mvc;

namespace VirtualPlay.MyAccount.Areas.Sales
{
    public class SalesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Sales";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Sales",
                "Sales",
                new { controller = "Payment", action = "Sale" },
                namespaces: new[] { "VirtualPlay.MyAccount.Areas.Sales.Controllers" }
            );

            context.MapRoute(
                "SalesDetails",
                "Sales/{id}",
                new { controller = "Payment", action = "Details", id = UrlParameter.Optional },
                namespaces: new[] { "VirtualPlay.MyAccount.Areas.Sales.Controllers" }
            );

            context.MapRoute(
                "CashReceipts",
                "CashReceipts",
                new { controller = "CashReceipts", action = "Index" },
                namespaces: new[] { "VirtualPlay.MyAccount.Areas.Sales.Controllers" }
            );

            context.MapRoute(
                "Dashboard",
                "Dashboard",
                new { controller = "Dashboard", action = "Index" },
                namespaces: new[] { "VirtualPlay.MyAccount.Areas.Sales.Controllers" }
            );
        }
    }
}