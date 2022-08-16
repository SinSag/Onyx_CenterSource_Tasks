using Onyx_ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VatService;

namespace Onyx_Tests
{
    public class VATService_Tests
    {
        [Test]
        public void VATService_Response_Test()
        {
            //arrange
            string countryCode = "DE";
            string vatNumber = "118856456";
            VatVerifier vatVerifier = new VatVerifier();

            //act
            var response = vatVerifier.VerifyVAT(countryCode, vatNumber);

            //assert;
            Assert.That(response.valid == true);
            
        }
    }
}
