using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "EditorialBlock", GUID = "9b3cf771-ab17-4945-b4f1-417136d664d8", Description = "")]
    public class EditorialBlock : BlockData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
    }
}