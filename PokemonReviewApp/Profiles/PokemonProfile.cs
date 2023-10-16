using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Profiles
{
    public class PokemonProfile : Profile
    {
        public PokemonProfile() 
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}