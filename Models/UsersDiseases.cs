using System;

namespace DrHelperFront.Models
{
    public class UsersDiseases
    {
        public int idUsersDiseases { get; set; }
        public int idUser { get; set; }
        public int idDisease { get; set; }
        public string occurrenceDate { get; set; }
        public string description { get; set; }
    }
}
