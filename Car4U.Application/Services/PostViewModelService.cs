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

        

        public async Task<IEnumerable<PostViewModel>> GetByUser(UserViewModel user, PageViewModel pageViewModel)
        {
            var specification = new PostFilterSpecification(user.Email);
            return (await _repository.List(specification)
            .Skip(pageViewModel.PageSkip).Take(pageViewModel.PageMargin)
            .Select(x => _mapper.Map<PostViewModel>(x))
            .ToListAsync());
        }

        

   
    }
}