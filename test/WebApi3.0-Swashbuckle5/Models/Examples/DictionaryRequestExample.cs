using System.Collections.Generic;
using Swashbuckle.AspNetCore.Filters;

namespace WebApi30_Swashbuckle5.Models.Examples
{
    public class DictionaryRequestExample : IExamplesProvider<Dictionary<string, object>>
    {
        public Dictionary<string, object> GetExamples()
        {
            return new Dictionary<string, object>()
            {
                {"PropertyInt", 1},
                {"PropertyString", "Some string"}
            };
        }
    }
}
