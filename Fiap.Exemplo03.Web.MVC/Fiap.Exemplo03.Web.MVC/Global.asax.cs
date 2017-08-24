﻿using Fiap.Exemplo03.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Fiap.Exemplo03.Web.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public object Databese { get; private set; }

        protected void Application_Start()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Persistencia.LoteriaContext>());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);            
        }
    }
}
