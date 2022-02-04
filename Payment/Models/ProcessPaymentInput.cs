namespace Payment.Models
{
    public class ProcessPaymentInput
    {
        public string CreditCardNumber { get; set; }
        public int CreditLimit { get; set; }
        public int ProcessingCharge { get; set; }
    }
}
