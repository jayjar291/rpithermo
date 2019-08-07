using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Schedule
    {
        public int ID { get; set; }
        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        public TimeSpan Start_Time { get; set; }
        [Display(Name = "End Time")]
        [DataType(DataType.Time)]
        public TimeSpan End_Time { get; set; }

        public DayOfWeek Day { get; set; }
        public int Temperature { get; set; }
    }
}
