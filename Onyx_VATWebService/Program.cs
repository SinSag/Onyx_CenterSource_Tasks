using Onyx_VATWebService.VATService;
using System;

namespace Onyx_VATWebService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            checkVatPortTypeClient _client = new checkVatPortTypeClient();

            var response = _client.checkVatAsync("DE", "118856456");

            Console.WriteLine(response);
        }
    }
}
