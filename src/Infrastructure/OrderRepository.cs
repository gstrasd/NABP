using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Domain;

namespace Infrastructure
{
    internal class OrderRepository : IOrderRepository
    {
        public async Task<List<Order>> GetOrdersAsync(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
