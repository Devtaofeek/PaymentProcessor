using App.Features.Payment.Command;
using App.Features.Payment.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentProcessor
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<CreatePaymentCommand, CreatePaymentDto>().ReverseMap();
            CreateMap<CreatePaymentResponse, Domain.Entities.Payment>().ReverseMap();
        }
    }
}
