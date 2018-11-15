using AutoMapper;

namespace Car4U.Application.AutoMapper
{
    public interface ITypeConverter<in TSource, TDestination>
    {
        TDestination Convert(TSource source, TDestination destination, ResolutionContext context);
    }
}