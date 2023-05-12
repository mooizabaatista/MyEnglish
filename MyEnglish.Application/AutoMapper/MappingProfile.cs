using AutoMapper;
using MyEnglish.Application.DTOs;
using MyEnglish.Domain;

namespace MyEnglish.Application.AutoMapper;

public class MappingProfile : Profile
{
	public MappingProfile()
	{
		CreateMap<Palavra, PalavraDto>().ReverseMap();
		CreateMap<Palavra, PalavraDtoFlat>().ReverseMap();
	}
}