using System.Threading.Tasks;
using Car4U.Domain.Interfaces;
using Car4U.Infrastructure.Data.Repositories;
using Car4U.Application.Intefaces;
using Car4U.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Car4U.Domain.Entities;
using Car4U.Domain.Exceptions;

namespace Car4U.Application.Services

{
    public class NotificationViewModelService :  ViewModelService<Notification, NotificationViewModel, Guid>,INotificationViewModelService
    {

        public NotificationViewModelService(UnitOfWork uow, INotificationRepository repository, IMapper mapper) : base(uow, repository, mapper)
        {
           
        }

        
    }
}