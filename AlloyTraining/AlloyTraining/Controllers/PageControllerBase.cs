﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using AlloyTraining.Models.Pages;
using System.Web.Security;

namespace AlloyTraining.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T>
        where T : SitePageData
    {
        public ActionResult logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}