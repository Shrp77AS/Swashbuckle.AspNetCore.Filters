using Swashbuckle.AspNetCore.Filters;

namespace WebApi30_Swashbuckle5.Models.Examples
{
    internal class ListPeopleRequestExample : IExamplesProvider<PeopleRequest>
    {
        public PeopleRequest GetExamples()
        {
            return new PeopleRequest { Title = Title.Mr, Age = 24, FirstName = "Dave in a list", Income = null };
        }
    }
}