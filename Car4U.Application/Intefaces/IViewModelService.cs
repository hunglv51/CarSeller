using System.Collections.Generic;
using System.Threading.Tasks;
using Car4U.Application.ViewModels;
using Car4U.Domain.Entities;

namespace Car4U.Application.Intefaces
{
    public interface IViewModelService<TModel, TViewModel, TKey> where TModel : BaseEntity<TKey>
    {
        Task<IEnumerable<TViewModel>> GetListEntities(PageViewModel pageInfo);
        Task<TViewModel> GetEntity(TKey id);
        Task CreateEntity(TViewModel entityViewModel);
        Task UpdateEntity(TKey id, TViewModel entityViewModel);
        Task DeleteEntity(TKey id);


    }
}