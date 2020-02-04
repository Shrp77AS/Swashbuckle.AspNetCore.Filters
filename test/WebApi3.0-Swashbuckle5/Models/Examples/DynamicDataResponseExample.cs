using Swashbuckle.AspNetCore.Filters;

namespace WebApi30_Swashbuckle5.Models.Examples
{
    public class DynamicDataResponseExample : IExamplesProvider<DynamicData>
    {
        public DynamicData GetExamples()
        {
            var ret = new DynamicData();
            ret.Payload.Add("DynamicProp", 12);
            ret.Payload.Add("Another", "String data");
            return ret;
        }
    }
}
