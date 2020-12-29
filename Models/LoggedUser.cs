using System;
using System.Collections.Generic;
using System.Text;

namespace DrHelperFront.Models
{
    public class LoggedUser
    {
        public int idUser { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string description { get; set; }
        public int idUserType { get; set; }
        public string token { get; set; }
    }
}
