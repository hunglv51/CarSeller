namespace Car4U.WebAPI.ViewModels
{
    public class PageViewModel
    {
        public int PageMargin { get; set; }
        private int pageIndex;

        public int PageSkip { get => (pageIndex - 1) * PageMargin;  }
    }
}