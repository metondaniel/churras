using AutoMapper;
using ChurrasApplication.ViewModel;
using ChurrasDomain.Domain;
using System;

namespace ChurrasApplication
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ChurrasViewModel, Churrasco>();
            CreateMap<Churrasco, ChurrasViewModel>();
            CreateMap<UserViewModel, User>();
            CreateMap<User, UserViewModel>();
            CreateMap<ChurrasParticipanteViewModel, ChurrasParticipante>();
            CreateMap<ChurrasParticipante, ChurrasParticipanteViewModel>();
            CreateMap<ParticipanteViewModel, Participante>();
            CreateMap<Participante, ChurrasParticipanteViewModel>();
        }
    }
}
