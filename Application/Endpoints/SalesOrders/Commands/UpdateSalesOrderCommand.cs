﻿using Application.Models;
using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.SalesOrders.Commands
{
    public class UpdateSalesOrderCommand : IRequest<EndpointResult<SalesOrderViewModel>>
    {
        public int? Id { get; set; }
        public string OrderType { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string PaymentType { get; set; }
        public ICollection<OrderDetailCommand> OrderDetails { get; set; }
    }
}
