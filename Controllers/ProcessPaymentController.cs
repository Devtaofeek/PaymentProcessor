using App.Features.Payment.Command;
using App.Features.Payment.Models;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentProcessor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessPaymentController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public ProcessPaymentController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> ProcessPayment(CreatePaymentDto createPaymentDto)
        {
            var createpaymentcommand = new CreatePaymentCommand {
             Amount = createPaymentDto.Amount,
              CardHolder = createPaymentDto.CardHolder,
               CreditCardNumber = createPaymentDto.CreditCardNumber,
                ExpirationMonth = createPaymentDto.ExpirationMonth,
                 ExpirationYear = createPaymentDto.ExpirationYear,
                  SecurityCode = createPaymentDto.SecurityCode
            };


            var response = await _mediator.Send(createpaymentcommand);
            return Ok(response);
        }

      
    }
}
