﻿using System.Diagnostics.CodeAnalysis;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using MicroErp.Domain.Service.Abstract.Dtos.Bases;
using MicroErp.Domain.Service.Abstract.Dtos.Bases.Responses;

namespace MicroErp.Application.Bases;


[ExcludeFromCodeCoverage]
public class FailRequestBehaviorWithResponseHandler<TRequest, TResponse> : IPipelineBehavior<TRequest, ResponseDto<TResponse>>
    where TRequest : IRequest<ResponseDto<TResponse>>
{
    private readonly IEnumerable<IValidator> _validators;

    public FailRequestBehaviorWithResponseHandler(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }   

    private static Task<ResponseDto<TResponse>> Errors(IEnumerable<ValidationFailure> failures)
        => Task.FromResult(ResponseDto<TResponse>.Fail(failures.Select(x =>
            ErrorResponse.CreateError(x.ErrorMessage)
                .WithDeveloperMessage(x.ToString()))
        ));

    public Task<ResponseDto<TResponse>> Handle(TRequest request, RequestHandlerDelegate<ResponseDto<TResponse>> next, CancellationToken cancellationToken)
    {
        var context = new ValidationContext<TRequest>(request);

        var failures = _validators
            .Select(v => v.Validate(context))
            .SelectMany(result => result.Errors)
            .Where(f => f != null)
            .ToList();

        return failures.Any()
            ? Errors(failures)
            : next();
    }
}