﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using AlloyTraining.Models.Pages;

namespace AlloyTraining.Controllers
{
    [TemplateDescriptor(Inherited = true)]
    public class PagePartialController : PartialContentController<SitePageData>
    {
        public override ActionResult Index(SitePageData currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return PartialView("/Views/Shared/PagePartials/PagePartial.cshtml", currentPage);
        }
    }
}