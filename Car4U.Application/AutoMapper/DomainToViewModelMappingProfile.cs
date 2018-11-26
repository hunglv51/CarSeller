using System.Collections.Generic;
using AutoMapper;
using Car4U.Application.ViewModels;
using Car4U.Domain.Entities;

namespace Car4U.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ICollection<Post>, int>().ConvertUsing(x => x.Count);
            
            CreateMap<Notification, NotificationViewModel>();
            CreateMap<PostCategory, PostCategoryViewModel>();
            CreateMap<Post,PostViewModel>();
            CreateMap<AppUser, UserViewModel>();
        }
    }
}