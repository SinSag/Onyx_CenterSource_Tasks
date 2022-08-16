using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Onyx_ConsoleApp.Models
{
    internal class TestData
    {
        public List<Observation> observations = new List<Observation>
        {
            new Observation { TravelAgent = "Norwegian", GuestName = "Sindre Sagdalen", NumberOfNights = 5 },
            new Observation { TravelAgent = "SAS", GuestName = "Henrik Sagdalen", NumberOfNights = 6 },
            new Observation { TravelAgent = "Norwegian", GuestName = "Mari Snildal", NumberOfNights = 5 },
            new Observation { TravelAgent = "RyanAir", GuestName = "Tore Knudsen", NumberOfNights = 3 }
        };

        public List<Observation> GetObservations()
        {
            return observations;
        }
    }
}
