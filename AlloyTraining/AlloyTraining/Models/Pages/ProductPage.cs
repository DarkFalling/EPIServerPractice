using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "ProductPage", GUID = "e39d02f4-d137-4981-bbb6-e79cafb7aaf1", Description = "Alloy Product Page")]
    public class ProductPage : StandardPage
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 305)]
        [UIHint(UIHint.Textarea)]
        public virtual string UniqueSellingPoints { get; set; }
    }
}