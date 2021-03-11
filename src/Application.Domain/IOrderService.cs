using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Domain;

namespace Application.Domain
{
    public interface IOrderService
    {
        Task<List<Order>> GetOrdersAsync(int userId);
    }
}
