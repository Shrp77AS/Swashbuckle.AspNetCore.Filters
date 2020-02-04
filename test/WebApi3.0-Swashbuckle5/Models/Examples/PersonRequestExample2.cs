using Swashbuckle.AspNetCore.Filters;

namespace WebApi30_Swashbuckle5.Models.Examples
{
    internal class PersonRequestExample2 : IExamplesProvider<PersonRequest>
    {
        public PersonRequest GetExamples()
        {
            return new PersonRequest { Title = Title.Miss, Age = 32, FirstName = "Angela", Income = null };
        }
    }
}