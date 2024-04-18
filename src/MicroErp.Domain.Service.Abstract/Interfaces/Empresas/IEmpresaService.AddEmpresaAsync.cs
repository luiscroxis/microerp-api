using MicroErp.Domain.Service.Abstract.Dtos.Bases.Responses;
using MicroErp.Domain.Service.Abstract.Dtos.Empresas.AddEmpresa;
using MicroErp.Infra.CrossCuting;

namespace MicroErp.Domain.Service.Abstract.Interfaces.Empresas;

public interface IEmpresaService
{
    Task<ResponseDto<None>> AddEmpresaAsync(AddEmpresaRequestDto request, CancellationToken cancellationToken);
}