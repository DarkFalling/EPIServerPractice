﻿using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlloyTraining.Models.Pages
{
    public class SitePageData : PageData
    {
        [Display(
            GroupName = "SEO",
            Order = 100)]
        public virtual string MetaTitle { get; set; }

        [Display(
            GroupName = "SEO",
            Order = 200)]
        public virtual string MetaKeywords { get; set; }

        [Display(
            GroupName = "SEO",
            Order = 300)]
        [UIHint(UIHint.Textarea)]
        public virtual string MetaDescription { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 100)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference PageImage { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 200)]
        [UIHint(UIHint.Textarea)]
        public virtual string TeaserText { get; set; }
    }
}