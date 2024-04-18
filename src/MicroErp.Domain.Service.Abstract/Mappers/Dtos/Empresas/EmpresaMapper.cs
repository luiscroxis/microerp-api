using MicroErp.Domain.Entity.Empresas;
using MicroErp.Domain.Service.Abstract.Dtos.Empresas.AddEmpresa;

namespace MicroErp.Domain.Service.Abstract.Mappers.Dtos.Empresas;

public class EmpresaMapper:BaseAutoMapper
{
    public EmpresaMapper()
    {
        CreateMap<AddEmpresaRequestDto, Empresa>()
            .ForMember(x => x.Cliente, opt => opt.MapFrom(x => x.IsCliente))
            .ForMember(x => x.Fornecedor, opt => opt.MapFrom(x => x.IsFornecedor))
            .BeforeMap((s, d) => d.Id = Guid.NewGuid().ToString().ToLower())
            .BeforeMap((s, d) => d.DataCadastro = DateTime.Now)
            .ReverseMap();
    }
}