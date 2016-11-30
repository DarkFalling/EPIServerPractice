using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "TeaserBlock", GUID = "0c7f9f61-7cd4-4bdf-9245-efea3e2a8726", Description = "")]
    public class TeaserBlock : BlockData
    {
        [Display(
                    GroupName = SystemTabNames.Content,
                    Order = 100)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference TeaserImage { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual string TeaserHeading { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 300)]
        [UIHint(UIHint.Textarea)]
        public virtual string TeaserText { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 400)]
        public virtual PageReference TeaserLink { get; set; }
    }
}