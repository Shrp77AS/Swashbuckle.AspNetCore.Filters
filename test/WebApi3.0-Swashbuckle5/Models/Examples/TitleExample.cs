using Swashbuckle.AspNetCore.Filters;

namespace WebApi30_Swashbuckle5.Models.Examples
{
    internal class TitleExample : IExamplesProvider<Title?>
    {
        public Title? GetExamples()
        {
            return Title.Miss;
        }
    }
}