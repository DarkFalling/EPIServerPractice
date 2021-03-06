﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using AlloyTraining.Models.Blocks;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "NewsPage", GUID = "40f88cf5-ddfb-4afa-9f3d-5b7fbe458801", Description = "")]
    public class NewsPage : StandardPage
    {
        [Display(
            Name = "Main Listing",
            Description = "A listing of news pages",
            GroupName = SystemTabNames.Content,
            Order = 315)]
        public virtual ListingBlock MainListing { get; set; }
    }
}