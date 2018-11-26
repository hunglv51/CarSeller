using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Car4U.Application.Intefaces;
using Car4U.Application.ViewModels;
using Car4U.Domain.Entities;
using Car4U.Domain.Exceptions;
using Car4U.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Car4U.Application.Services
{
    public class ViewModelService<TModel, TViewModel, TKey> : IViewModelService<TModel, TViewModel, TKey> where TModel : BaseEntity<TKey>
    {
        // protected readonly IAppLogger<ViewModelService<TModel, TViewModel, TKey>> _logger;
        protected readonly IMapper _mapper;
        protected readonly IRepository<TKey, TModel> _repository;
        protected readonly IUnitOfWork _unitOfWork;
        public ViewModelService(IUnitOfWork uow, IRepository<TKey, TModel> repository, IMapper mapper)
        {
            _unitOfWork = uow;
            _repository = repository;
            _mapper = mapper;
            // _logger = logger;
        }


      public async Task CreateEntity(TViewModel entityViewModel)
        {
            var model = _mapper.Map<TModel>(entityViewModel);
            await _repository.Add(model);
            await _unitOfWork.CommitAsync();
            
        }

        public async Task DeleteEntity(TKey id)
        {
            var model = await GetModel(id);
            _repository.Delete(model);
            await _unitOfWork.CommitAsync();
        }

       

        public async Task<TViewModel> GetEntity(TKey id)
        {
            var model = await GetModel(id);
            var viewModel = _mapper.Map<TViewModel>(model);
            return viewModel;
        }

        public async Task<IEnumerable<TViewModel>> GetListEntities(PageViewModel pageInfo)
        {
           return (await _repository.ListAll()
            .OrderByDescending(x => x.Id)
            .Skip(pageInfo.PageSkip).Take(pageInfo.PageMargin)
            .Select(x => _mapper.Map<TViewModel>(x))
            .ToListAsync());
        }

        public async Task UpdateEntity(TKey id, TViewModel entityViewModel)
        {
            var model = await GetModel(id);
            _mapper.Map<TViewModel, TModel>(entityViewModel, model);
            // model.Id = id;
            _repository.Update(model);
            await _unitOfWork.CommitAsync();
        }

        protected async Task<TModel> GetModel(TKey id)
        {
            var model = await _repository.GetById(id);
            if(model == null)
                throw new EntityNotFoundException<TKey>(id);
            return model;
        }
    }
}