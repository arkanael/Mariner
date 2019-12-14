using AutoMapper;
using Mariner.Data.Entities;
using Mariner.Services.ViewModels;

namespace Mariner.Services.Mappings
{
    public class ModelToEntityMap : Profile
    {
        public ModelToEntityMap()
        {
            CreateMap<FuncionarioCadastroModel, Funcionario>();
            CreateMap<Funcionario, FuncionarioEdicaoModel>();
        }
    }
}