using Swashbuckle.AspNetCore.Filters;

namespace WebApi30_Swashbuckle5.Models.Examples
{
    internal class MaleRequestExample : IExamplesProvider<MaleRequest>
    {
        public MaleRequest GetExamples()
        {
            return new MaleRequest { Title = Title.Mr, Age = 24, FirstName = "Steve Auto", Income = null };
        }
    }
}
