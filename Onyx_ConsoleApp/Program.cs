//imports necessary libraries
using Onyx_ConsoleApp.Models;
using VatService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    //entry point
    static void Main(String[] args)
    {
        var invoiceGroups = new List<InvoiceGroup>();

        //random testdata
        invoiceGroups.Add(new InvoiceGroup { IssueDate = new DateTime(2015, 10, 10), NumberOfNights = 4, TravelAgent = "Norwegian", GuestName = "Sindre Sagdalen" });
        invoiceGroups.Add(new InvoiceGroup { IssueDate = new DateTime(2016, 10, 10), NumberOfNights = 3, TravelAgent = "SAS", GuestName = "Sindre Sagdalen" });
        invoiceGroups.Add(new InvoiceGroup { IssueDate = new DateTime(2018, 10, 10), NumberOfNights = 6, TravelAgent = "RyanAir", GuestName = "Sindre Sagdalen" });
        invoiceGroups.Add(new InvoiceGroup { IssueDate = new DateTime(2015, 10, 10), NumberOfNights = 8, TravelAgent = "SAS", GuestName = "Henrik Sagdalen" });
        invoiceGroups.Add(new InvoiceGroup { IssueDate = new DateTime(2015, 10, 10), NumberOfNights = 2, TravelAgent = "Norwegian", GuestName = "Adrian Mikkelsen" });
        invoiceGroups.Add(new InvoiceGroup { IssueDate = new DateTime(2012, 10, 10), NumberOfNights = 5, TravelAgent = "Norwegian", GuestName = "Adrian Mikkelsen" });

        //a) linq-expression repeated guest names
        IEnumerable<string> repeatedGuestNames = invoiceGroups.GroupBy(x => x.GuestName)
                                                              .Where(g => g.Count() > 1)
                                                              .Select(x => x.Key);

        //b) linq-expression totalnumberofnights per travelagent
        IEnumerable<TravelAgentInfo> numberOfNightsByTravelAgent = invoiceGroups.Where(h => h.IssueDate.Year == 2015)
                                                                                .GroupBy(x => x.TravelAgent)
                                                                                .Select(y => new TravelAgentInfo
                                                                                {
                                                                                    TravelAgent = y.First().TravelAgent,
                                                                                    TotalNumberOfNights = y.Sum(x => x.NumberOfNights),
                                                                                }).ToList();

        //writes result for task a
        Console.WriteLine("Task a): ");
        Console.WriteLine("Repeated guest names are: " + String.Join(",", repeatedGuestNames));

        //writes result for task b
        Console.WriteLine(Environment.NewLine + "Task b): ");
        foreach (var agent in numberOfNightsByTravelAgent)
        {
            Console.WriteLine("Total number of nights for " + agent.TravelAgent + " are: " + agent.TotalNumberOfNights);
        }

        VatVerifier vatVerifier = new VatVerifier();
        //var response = vatVerifier.VerifyVAT("DE", "118856456");
        //Console.WriteLine(response);
    }
}