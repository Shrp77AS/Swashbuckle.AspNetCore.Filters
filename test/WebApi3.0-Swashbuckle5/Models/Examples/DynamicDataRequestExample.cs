using Swashbuckle.AspNetCore.Filters;

namespace WebApi30_Swashbuckle5.Models.Examples
{
    public class DynamicDataRequestExample : IExamplesProvider<DynamicData>
    {
        public DynamicData GetExamples()
        {
            var ret = new DynamicData();
            ret.Payload.Add("DynamicProp", 1);
            return ret;
        }
    }
}
