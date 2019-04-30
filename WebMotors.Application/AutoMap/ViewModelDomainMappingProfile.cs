﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotors.Application.ViewModels;
using WebMotors.Domain;

namespace WebMotors.Application.AutoMap
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AnuncioViewModel, Anuncio>();
        }
    }
}
