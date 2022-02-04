using Microsoft.AspNetCore.Mvc;
using Payment.Models;
using Payment.Services;

namespace Payment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService paymentService;
        public PaymentController(IPaymentService service)
        {
            paymentService = service;
        }

        [HttpPost]
        
        public Microsoft.AspNetCore.Mvc.IActionResult ProcessPayment(ProcessPaymentInput input) 
        {

            //PaymentService provider = new PaymentService();
            int CurrentBalance = paymentService.ProcessPayment(input);
            if (CurrentBalance >= 0)
            {
                return Ok(CurrentBalance);
            }
            else
            {
                return BadRequest("Deduction failed due to low balance or incorrect card details");
            }
        
        }
    }
}
