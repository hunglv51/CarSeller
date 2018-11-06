using System.Threading.Tasks;
using Car4U.ApplicationCore.Interfaces;
using Car4U.Infrastructure.Data.Repositories;
using Car4U.WebAPI.Intefaces;
using Car4U.WebAPI.ViewModels;
using System;
namespace Car4U.WebAPI.Services

{
    public class NotificationViewModelService : INotificationViewModelService
    {

        private readonly UnitOfWork _unitOfWork;
        private readonly INotificationRepository _notificationRepository;
        public NotificationViewModelService(UnitOfWork uow, INotificationRepository repository)
        {
            _unitOfWork = uow;
            _notificationRepository = repository;
        }

        public Task<NewestNotificationViewModel> NewestNotification => throw new NotImplementedException();

        public Task<NewestNotificationViewModel> GetNewestNotification()
        {
            throw new NotImplementedException();
        }
    }
}