using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Car4U.Domain.Interfaces;
using Car4U.Application.Intefaces;
using Car4U.Application.ViewModels;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using System;
using Car4U.Domain.Specifications;
using Car4U.Domain.Entities;

namespace Car4U.Application.Services
{
    public class PostViewModelService :ViewModelService<Post, PostViewModel, Guid>, IPostViewModelService
    {

        // private readonly IAppLogger<PostViewModelService> _logger;
        // private readonly IPostRepository _postRepository;
        // private readonly IUnitOfWork _unitOfWork;
        public PostViewModelService(IUnitOfWork uow, IPostRepository postRepository, IMapper mapper) : base (uow, postRepository, mapper)
        {
            // _unitOfWork = uow;
            // _postRepository = postRepository;
            // _logger = logger;
        }

        public async Task<ListPostViewModel> GetByBrandName(string brandName)
        {
            var specification = new PostFilterSpecification(brandName);
            var listPost = new ListPostViewModel();
            var posts = _repository.List(specification)
                        .Select(x => new ListPostItem{
                            CarType = x.Category.CarType.ToString(),
                            City = x.City,
                            CreatedDate = x.CreatedDate,
                            DrivenDistance = x.Car.DrivenDistance,
                            Id = x.Id.ToString(),
                            Images = x.Car.Images,
                            IsImported = x.Category.IsImported,
                            IsUsed = x.Category.IsUsed,
                            ManufactureYear = x.Car.ManufactureYear,
                            Phone = x.User.PhoneNumber,
                            Price = x.Car.Price,
                            Title = x.Title,
                            Tranmission = x.Category.Transmission.ToString()
                        });
            listPost.Items =  await posts.ToListAsync();
            return listPost;            
        }

        // public async Task<IEnumerable<PostViewModel>> GetByUser(UserViewModel user, PageViewModel pageViewModel)
        // {
        //     // var specification = new PostFilterSpecification(user.Email);
        //     // return (await _repository.List(specification)
        //     // .Skip(pageViewModel.PageSkip).Take(pageViewModel.PageMargin)
        //     // .Select(x => _mapper.Map<PostViewModel>(x))
        //     // .ToListAsync());
        // }

        public async Task<ListPostViewModel> GetNewestPostViewModel(PageViewModel pageInfo)
        {
            var listPost = new ListPostViewModel();
            var posts = _repository.ListAll()
                            .Skip(pageInfo.PageSkip).Take(pageInfo.PageMargin)
                            .Select(x => new ListPostItem{
                                CarType = x.Category.CarType.ToString(),
                                City = x.City,
                                CreatedDate = x.CreatedDate,
                                DrivenDistance = x.Car.DrivenDistance,
                                Id = x.Id.ToString(),
                                Images = x.Car.Images,
                                IsImported = x.Category.IsImported,
                                IsUsed = x.Category.IsUsed,
                                ManufactureYear = x.Car.ManufactureYear,
                                Phone = x.User.PhoneNumber,
                                Price = x.Car.Price,
                                Title = x.Title,
                                Tranmission = x.Category.Transmission.ToString()

                            });
            listPost.Items =  await posts.ToListAsync();
            return listPost;
        }

         

   
    }
}