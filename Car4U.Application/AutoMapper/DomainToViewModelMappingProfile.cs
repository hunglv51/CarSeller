using AutoMapper;
using Car4U.Application.ViewModels;
using Car4U.Domain.Entities;

namespace Car4U.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Notification, NotificationViewModel>();
            CreateMap<PostCategory, PostCategoryViewModel>();
            CreateMap<Post,PostViewModel>();
            CreateMap<AppUser, UserViewModel>();
        }
    }
}