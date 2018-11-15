
using System;
using AutoMapper;

namespace Car4U.Application.AutoMapper
{
    public class EnumTypeConverter<TEnum> : ITypeConverter<string, TEnum>
    {
        public TEnum Convert(string source, TEnum destination, ResolutionContext context)
        {
            var result = Enum.Parse(destination.GetType(), source);
            // return System.Convert.ChangeType(destination.GetType(), result);
            return (TEnum) result;
        }

        
    }
}