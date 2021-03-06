﻿using System.ComponentModel;

namespace WebApi30_Swashbuckle5.Models
{
    public class PeopleRequest
    {
        public Title Title { get; set; }

        public int Age { get; set; }

        [Description("The first name in a list")]
        public string FirstName { get; set; }

        public decimal? Income { get; set; }
    }
}