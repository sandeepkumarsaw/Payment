using Payment.Models;
using Payment.Repository;

namespace Payment.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPayerRepository repository;
        public PaymentService(IPayerRepository  payerRepository)
        {
            repository = payerRepository;
        }
        
        public int ProcessPayment(ProcessPaymentInput card)
        {

            PayerCardDetails cardDetails = repository.GetCardDetails(card);
            if(cardDetails==null)
            {
                return -1;
            }
            if (cardDetails.Balance >= card.ProcessingCharge)
            {
                cardDetails.Balance = cardDetails.Balance-card.ProcessingCharge;
                return cardDetails.Balance;
            }
            
            return -1;
        }
    }

}
