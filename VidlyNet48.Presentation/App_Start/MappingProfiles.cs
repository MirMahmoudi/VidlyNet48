using AutoMapper;
using VidlyNet48.Presentation.Dto;
using VidlyNet48.Presentation.Models;

namespace VidlyNet48.Presentation.App_Start
{
	public class MappingProfiles : Profile
	{
		public MappingProfiles()
		{
			// Customer
			Mapper.CreateMap<Customer, CustomerDto>();
			Mapper.CreateMap<CustomerDto, Customer>()
				.ForMember(c => c.Id, opt => opt.Ignore());

			// MembershipType
			Mapper.CreateMap<MembershipType, MembershipTypeDto>();

			// Movie
			Mapper.CreateMap<Movie, MovieDto>();
			Mapper.CreateMap<MovieDto, Movie>()
				.ForMember(m => m.Id, opt => opt.Ignore());

			// Genre
			Mapper.CreateMap<Genre, GenreDto>();
		}
	}
}