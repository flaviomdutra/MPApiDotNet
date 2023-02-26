using System;
using AutoMapper;
using MP.ApiDotNet.Application.DTOs;
using MP.ApiDotNet.Domain.Entities;

namespace MP.ApiDotNet.Application.Mappings
{
	public class DomainToDtoMapping : Profile
	{
		public DomainToDtoMapping()
		{
			CreateMap<Person, PersonDTO>();
			CreateMap<Product, ProductDTO>();
		}
	}
}

