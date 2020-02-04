namespace WebApi30_Swashbuckle5.Models
{
    public class PersonRequest
    {
        public Title Title { get; set; }

        /// <summary>
        /// The person's Age, in years
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// The first name of the person
        /// </summary>
        public string FirstName { get; set; }

        public decimal? Income { get; set; }
    }
}