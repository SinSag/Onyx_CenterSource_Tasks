using VatService;

namespace Onyx_ConsoleApp.Models
{
    public class VatVerifier
    {
        enum VerificationStatus
        {
            Valid,
            Invalid,
            // Unable to get status (e.g. service unavailable)
            Unavailable
        }

        /// <summary>
        /// Verifies the given VAT number for the given country using the EU VIES web service.
        /// </summary>
        /// <param name="countryCode"></param>
        /// <param name="vatNumber"></param>
        /// <returns>Verification status</returns>
        // TODO: Implement Verify method

        /*public async Task<checkVatResponse> VerifyVAT(string countryCode, string vatNumber)
        {
            checkVatPortTypeClient client = new checkVatPortTypeClient();
            checkVatRequest checkVatRequest = new checkVatRequest();

            checkVatRequest.countryCode = countryCode;
            checkVatRequest.vatNumber = vatNumber;

            var response = client.checkVatAsync(checkVatRequest);

            return response;
        }*/
    }
}