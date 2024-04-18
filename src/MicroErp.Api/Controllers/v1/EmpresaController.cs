using MediatR;
using MicroErp.Api.Controllers.Bases;
using MicroErp.Application.EmpresaCase.AddEmpresa;
using MicroErp.Domain.Service.Abstract.Dtos.Bases.Responses;
using MicroErp.Infra.CrossCuting;
using Microsoft.AspNetCore.Mvc;

namespace MicroErp.Api.Controllers.v1;

public class EmpresaController : ApiControllerBase
{
    private readonly IMediator _mediator;

    public EmpresaController(IMediator mediator) => _mediator = mediator;
    
    [HttpPost()]
    [ProducesResponseType(typeof(ResponseDto<None>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> PostCampanha([FromBody] AddEmpresaRequest request)
    {
        var response = await _mediator.Send(request);
        return CreateResult(response);
    }
}