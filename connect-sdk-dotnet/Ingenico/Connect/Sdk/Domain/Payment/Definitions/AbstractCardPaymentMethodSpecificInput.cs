/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class AbstractCardPaymentMethodSpecificInput : AbstractPaymentMethodSpecificInput
    {
        public string AuthorizationMode { get; set; } = null;

        public string CustomerReference { get; set; } = null;

        public string RecurringPaymentSequenceIndicator { get; set; } = null;

        public bool? RequiresApproval { get; set; } = null;

        public bool? SkipAuthentication { get; set; } = null;

        public bool? SkipFraudService { get; set; } = null;

        public string Token { get; set; } = null;

        public bool? Tokenize { get; set; } = null;

        public string TransactionChannel { get; set; } = null;

        public string UnscheduledCardOnFileIndicator { get; set; } = null;

        public string UnscheduledCardOnFileRequestor { get; set; } = null;
    }
}
