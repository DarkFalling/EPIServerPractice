using AlloyTraining.Models.Pages;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlloyTraining.Models.ViewModels
{
    public class ListingBlockModel
    {
        public string Heading { get; set; }
        public IEnumerable<PageData> Items { get; set; }
    }
}
