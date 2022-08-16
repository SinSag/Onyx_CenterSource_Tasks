using Onyx_ConsoleApp.Models;

public class Program
{
    //entry point
    static void Main(String[] args)
    {
        //creates an instance of TestData class
        TestData newTestData = new TestData();
        //gets the test data
        var invoiceGroups = newTestData.Get();

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

        //VatVerifier vatVerifier = new VatVerifier();
        //var response = vatVerifier.VerifyVAT("DE", "118856456");
        //Console.WriteLine(response);
    }
}