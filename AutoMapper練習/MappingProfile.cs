﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper練習
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, User>()
                .ForMember(x => x.School_Name, y => y.MapFrom(o => o.schoolName))
                .ForMember(x => x.Class_Name, y => y.MapFrom(o => o.className));


        }
    }
}
