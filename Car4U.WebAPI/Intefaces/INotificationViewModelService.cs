using System.Threading.Tasks;
using Car4U.WebAPI.ViewModels;

namespace Car4U.WebAPI.Intefaces
{
    public interface INotificationViewModelService
    {
         Task<NewestNotificationViewModel> GetNewestNotification();
    }
}