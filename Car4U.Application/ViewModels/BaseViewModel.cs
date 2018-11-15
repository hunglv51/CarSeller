namespace Car4U.Application.ViewModels
{
    public abstract class BaseViewModel<TKey>
    {
        public TKey Id { get; set; }
    }
}