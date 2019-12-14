using AutoMapper;
using Mariner.Data.Entities;
using Mariner.Services.ViewModels;

namespace Mariner.Services.Mappings
{
    public class EntityToModelMap : Profile
    {
        public EntityToModelMap()
        {
            CreateMap<Funcionario, FuncionarioConsultaModel>();
        }
    }
}
