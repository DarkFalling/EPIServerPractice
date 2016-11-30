using AlloyTraining.Models.Pages;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlloyTraining.Models.ViewModels
{
    public class BlockEditPageViewModel : IPageViewModel<SitePageData>
    {
        public BlockEditPageViewModel(PageData pageData, IContent content)
        {
            previewBlock = new PreviewBlock(pageData, content);
            CurrentPage = pageData as SitePageData;
        }

        public PreviewBlock previewBlock { get; set; }
        public SitePageData CurrentPage { get; set; }
    }
}
