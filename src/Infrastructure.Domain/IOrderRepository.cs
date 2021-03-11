using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Domain
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetOrdersAsync(int userId);
    }
}
