using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "ListingBlock", GUID = "12746732-5e2b-4549-88d4-726b1eb9dc07", Description = "")]
    public class ListingBlock : BlockData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string Heading { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual PageReference RootPage { get; set; }

    }
}