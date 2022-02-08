using System;
using Xunit;
using Payment.Repository;
using Payment.Models;
using Payment.Services;
using Payment.Controllers;

namespace Payment_Test
{
    public class PaymentTest
    {

        private PayerRepository repo;
        private PaymentService service;
        private PaymentController controller;
        public PaymentTest()
        {
            repo = new PayerRepository();
            service = new PaymentService(repo);
            controller = new PaymentController(service);
        }

        [Fact]
        public void GetCardDetails()
        {
            PayerCardDetails data = repo.GetCardDetails(new ProcessPaymentInput { CreditCardNumber="admincard", CreditLimit=100, ProcessingCharge=500 });
            Assert.NotNull(data);
        }

        [Fact]
        public void Test_generate_token()
        {
            int d = service.ProcessPayment(new ProcessPaymentInput { CreditCardNumber = "admincard", CreditLimit = 100, ProcessingCharge = 500 });
            Assert.NotEqual(d, -1);
        }
        [Fact]
        public void Test_ProcessPayment()
        {
            var d = controller.ProcessPayment(new ProcessPaymentInput { CreditCardNumber = "admincard", CreditLimit = 100, ProcessingCharge = 500 });
            Assert.NotNull(d);
        }
    }
}
