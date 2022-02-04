using Payment.Models;

namespace Payment.Repository
{
    public interface IPayerRepository
    {
        public PayerCardDetails GetCardDetails(ProcessPaymentInput card);
    }
}
