﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroErp.Domain.Service.Abstract.Dtos.Bases;

public class ErrorResponse
{
    private ErrorResponse()
    {

    }
    public string? DeveloperMessage { get; protected set; } = null;
    public string? UserMessage { get; protected set; } = null;
    public string? ErrorCode { get; protected set; } = null;
    public string? MoreInfo { get; protected set; } = null;
    public string? StackTrace { get; protected set; } = null;
    public string? Exception { get; protected set; } = null;

    public static ErrorResponse CreateError(string userMessage)
    {
        return new ErrorResponse() { UserMessage = userMessage };
    }

    public ErrorResponse WithDeveloperMessage(string? message)
    {
        DeveloperMessage = message;
        return this;
    }

    public ErrorResponse WithErrorCode(string? errorCode)
    {
        ErrorCode = errorCode;
        return this;
    }

    public ErrorResponse WithMoreInfo(string? moreInfo)
    {
        MoreInfo = moreInfo;
        return this;
    }

    public ErrorResponse WithStackTrace(string? stackTrace)
    {
        StackTrace = stackTrace;
        return this;
    }

    public ErrorResponse WithException(string? exeption)
    {
        Exception = exeption;
        return this;
    }
}