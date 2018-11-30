using System;
using System.Collections.Generic;
using AutoMapper;
using Car4U.Application.ViewModels;
using Car4U.Domain.Entities;
using Car4U.Domain.Enums;

namespace Car4U.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            // CreateMap<string, CarTypes>().ConvertUsing(MappingFunction<CarTypes>);
            
            // CreateMap<string, DriveTypes>().ConvertUsing(MappingFunction<DriveTypes>);
            // CreateMap<string, PostTypes>().ConvertUsing(MappingFunction<PostTypes>);
            // CreateMap<string, Status>().ConvertUsing(MappingFunction<Status>);
            // CreateMap<string, TransmissionTypes>().ConvertUsing(MappingFunction<TransmissionTypes>);
            CreateMap<NotificationViewModel, Notification>();
            CreateMap<PostViewModel, Post>();
            CreateMap<PostCategoryViewModel, PostCategory>()
                // .ForMember(model => model.CarType, opt => opt.MapFrom(viewModel => MappingFunction<CarTypes>(viewModel.CarType)))
                // .ForMember(model => model.DriveType, opt => opt.MapFrom(viewModel => MappingFunction<CarTypes>(viewModel.DriveType)));
                .ForMember(model => model.Posts, opt => opt.MapFrom((src) => new List<Post>()));
            CreateMap<UserViewModel, AppUser>();

        }

        private TEnum MappingFunction<TEnum>(string source) where TEnum : struct
        {
            // Enum.TryParse<TEnum>(source, out TEnum result);
            // return result;
            return default(TEnum);
        }


    }
}