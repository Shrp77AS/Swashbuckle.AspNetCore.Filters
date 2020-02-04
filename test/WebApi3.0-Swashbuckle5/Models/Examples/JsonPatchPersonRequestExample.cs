using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch.Operations;
using Swashbuckle.AspNetCore.Filters;

namespace WebApi30_Swashbuckle5.Models.Examples
{
    public class JsonPatchPersonRequestExample : IExamplesProvider<IEnumerable<Operation>>
    {
        public IEnumerable<Operation> GetExamples()
        {
            return new[]
            {
                new Operation
                {
                    op = "replace",
                    path = "/firstname",
                    value = "Steve"
                },
                new Operation
                {
                    op = "remove",
                    path = "/income"
                }
            };
        }
    }
}
