using Payment.Models;

namespace Payment.Services
{
    public interface IPaymentService
    {
        public int ProcessPayment(ProcessPaymentInput card);
    }
}
