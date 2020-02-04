using System.Collections.Generic;
using Swashbuckle.AspNetCore.Filters;

namespace WebApi30_Swashbuckle5.Models.Examples
{
    public class DictionaryResponseExample : IExamplesProvider<Dictionary<string, object>>
    {
        public Dictionary<string, object> GetExamples()
        {
            return new Dictionary<string, object>()
            {
                {"PropertyInt", 5},
                {"PropertyString", "Another string"}
            };
        }
    }
}
