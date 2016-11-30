using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "SearchPage", GUID = "ac9eb7ab-2e3a-4fa9-abeb-b7e47e80625b", Description = "")]
    public class SearchPage : SitePageData
    {
    }
}