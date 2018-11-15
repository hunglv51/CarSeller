namespace Car4U.Application.ViewModels
{
    public class PageViewModel 
    {
        public PageViewModel(int pageMargin)
        {
            PageMargin = pageMargin;
        }
        public int PageMargin { get; set; }
        public int PageIndex { get; set; }

        public int PageSkip { get => (PageIndex  - 1) * PageMargin ;}
    }
}