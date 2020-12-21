using System;

namespace DrHelperFront.Models
{
    public class Timeblock
    {
        public int idTimeblock { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public bool avaliable { get; set; }
        public int idUser { get; set; }
        public int idAppointment { get; set; }
    }
}
