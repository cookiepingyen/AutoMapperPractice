using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper練習
{
    public class Mapper
    {

        public static Dest Map<Source, Dest>(Source source, Action<IMappingExpression<Source, Dest>> action)
        {
            var config = new MapperConfiguration(cfg =>
            {
                var expression = cfg.CreateMap<Source, Dest>();
                action.Invoke(expression);
                expression.ReverseMap();
            });



            var mapper = config.CreateMapper();
            var result = mapper.Map<Source, Dest>(source);
            return result;
        }

        public static Dest Map<Source, Dest, MappingProfile>(Source source) where MappingProfile : Profile, new()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());

            var mapper = config.CreateMapper();
            var result = mapper.Map<Source, Dest>(source);
            return result;
        }

    }
}
