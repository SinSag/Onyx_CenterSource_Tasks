//testdata class, to generate testdata

namespace Onyx_ConsoleApp.Models
{
    internal class TestData
    {
        public List<InvoiceGroup> invoiceGroups = new List<InvoiceGroup>
        {
            new InvoiceGroup { IssueDate = new DateTime(2015, 10, 10), NumberOfNights = 4, TravelAgent = "Norwegian", GuestName = "Sindre Sagdalen" },
            new InvoiceGroup { IssueDate = new DateTime(2016, 10, 10), NumberOfNights = 3, TravelAgent = "SAS", GuestName = "Sindre Sagdalen" },
            new InvoiceGroup { IssueDate = new DateTime(2018, 10, 10), NumberOfNights = 6, TravelAgent = "RyanAir", GuestName = "Sindre Sagdalen" },
            new InvoiceGroup { IssueDate = new DateTime(2015, 10, 10), NumberOfNights = 8, TravelAgent = "SAS", GuestName = "Henrik Sagdalen" },
            new InvoiceGroup { IssueDate = new DateTime(2015, 10, 10), NumberOfNights = 2, TravelAgent = "Norwegian", GuestName = "Adrian Mikkelsen" },
            new InvoiceGroup { IssueDate = new DateTime(2012, 10, 10), NumberOfNights = 5, TravelAgent = "Norwegian", GuestName = "Adrian Mikkelsen" }
        };

        //random testdata
        public List<Observation> observations = new List<Observation>
        {
            new Observation { TravelAgent = "Norwegian", GuestName = "Sindre Sagdalen", NumberOfNights = 5 },
            new Observation { TravelAgent = "SAS", GuestName = "Henrik Sagdalen", NumberOfNights = 6 },
            new Observation { TravelAgent = "Norwegian", GuestName = "Mari Snildal", NumberOfNights = 5 },
            new Observation { TravelAgent = "RyanAir", GuestName = "Tore Knudsen", NumberOfNights = 3 }
        };

        public List<InvoiceGroup> Get()
        {
            return invoiceGroups;
        }
    }
}
