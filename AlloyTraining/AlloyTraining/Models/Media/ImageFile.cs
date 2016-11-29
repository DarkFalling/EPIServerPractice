using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "ImageFile", GUID = "f13946b5-05fe-4326-9754-f816fe9328c1", Description = "")]
    /*[MediaDescriptor(ExtensionString = "pdf,doc,docx")]*/
    public class ImageFile : ImageData
    {
        [CultureSpecific]
        [Editable(true)]
        [Display(
            Name = "Description",
            Description = "Description field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Description { get; set; }
    }
}