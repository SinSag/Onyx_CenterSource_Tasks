using System.ComponentModel.DataAnnotations;
using WASM_VatService;

namespace VATWebApp.Models
{
    public class VAT_Form_Verifier
    {

        [Required(ErrorMessage = "Please enter a country code.")]
        public string countryCode;
        [Required(ErrorMessage = "Please enter a VAT-number.")]
        public string vatNumber;

        public async Task<string> VerifyVAT(string countryCode, string vatNumber)
        {
            checkVatPortTypeClient client = new checkVatPortTypeClient();
            checkVatRequest checkVatRequest = new checkVatRequest();

            checkVatRequest.countryCode = countryCode;
            checkVatRequest.vatNumber = vatNumber;

            var response = await client.checkVatAsync(checkVatRequest);

            return response.vatNumber;

        }

    }
}
