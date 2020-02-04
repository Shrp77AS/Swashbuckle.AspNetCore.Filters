using Swashbuckle.AspNetCore.Filters;

namespace WebApi30_Swashbuckle5.Models.Examples
{
    internal class PersonResponseExample2 : IExamplesProvider<PersonResponse>
    {
        public PersonResponse GetExamples()
        {
            return new PersonResponse { Id = 123, Title = Title.Dr, FirstName = "Hank", LastName = "Thomas", Age = 27, Income = null };
        }
    }
}