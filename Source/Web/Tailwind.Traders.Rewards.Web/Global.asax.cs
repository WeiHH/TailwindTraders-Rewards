﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Tailwind.Traders.Rewards.Web.data;
using Tailwind.Traders.Rewards.Web.Migrations;

namespace Tailwind.Traders.Rewards.Web
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var migrator = new System.Data.Entity.Migrations.DbMigrator(new Configuration());
            migrator.Update();
        }
    }
}