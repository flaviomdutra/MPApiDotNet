using System;
using AutoMapper;
using MP.ApiDotNet.Application.DTOs;
using MP.ApiDotNet.Domain.Entities;

namespace MP.ApiDotNet.Application.Mappings
{
    public class DtoToDomainMapping : Profile
    {
        public DtoToDomainMapping()
        {
            CreateMap<PersonDTO, Person>();
        }
    }
}

