using Payment.Models;
using System.Collections.Generic;

namespace Payment.Repository
{
    public class PayerRepository : IPayerRepository
    {
        private static List<PayerCardDetails> cards = new List<PayerCardDetails>()
        {
            new PayerCardDetails() { CreditCardNumber="admincard",Balance=50000 },
            new PayerCardDetails() { CreditCardNumber="usercard",Balance=1000 }
        };

        public PayerRepository()
        {
            //initialise the dbContext
        }
        public PayerCardDetails GetCardDetails(ProcessPaymentInput card)
        {
            PayerCardDetails details = cards.Find(c => card.CreditCardNumber == c.CreditCardNumber);
            return details;
        }
    }
}
