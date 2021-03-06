﻿using Swashbuckle.AspNetCore.Filters;

namespace WebApi30_Swashbuckle5.Models.Examples
{
    internal class NotFoundResponseExample : IExamplesProvider<ErrorResponse>
    {
        public ErrorResponse GetExamples()
        {
            return new ErrorResponse { ErrorCode = 404, Message = "The entity was not found" };
        }
    }
}