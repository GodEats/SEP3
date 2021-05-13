﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Data
{
    public interface IOrderService
    {
        Task<IList<Order>> GetAllOrdersAsync();
        Task<Order> GetOrderAsync(int id);
        Task<IList<Order>> GetOrdersByUserAsync(User user);
        Task CreateOrderAsync(Order order);
        Task RemoveOrderAsync(int orderId);
        Task UpdateOrderAsync(int orderId);
    }
}