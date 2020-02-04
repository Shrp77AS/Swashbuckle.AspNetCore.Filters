using Swashbuckle.AspNetCore.Filters;

namespace WebApi30_Swashbuckle5.Models.Examples
{
    internal class PersonResponseExample : IExamplesProvider<PersonResponse>
    {
        public PersonResponse GetExamples()
        {
            return new PersonResponse { Id = 123, Title = Title.Dr, FirstName = "John", LastName = "Doe", Age = 27, Income = null };
        }
    }
}