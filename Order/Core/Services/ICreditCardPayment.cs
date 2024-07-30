﻿using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface ICreditCardPayment
    {
        Task<InvoiceDto> PaymentWithCreditCard(int OrderId);

    }
}
