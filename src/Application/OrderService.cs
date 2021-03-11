using Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Domain;

namespace Application
{
    internal class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Order>> GetOrdersAsync(int userId)
        {
            return await _repository.GetOrdersAsync(userId);
        }
    }
}
