using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Incident.Models
{
    public class Incident
    {
        public int Id { get; set; }
        public string Type { get; set; } //change this to an enum
        public DateTime DateOfIncident { get; set; }
        public TimeSpan TimeOfIncident { get; set; }
        public string Description { get; set; }
        public string RaisedUser { get; set; }
    }
}
