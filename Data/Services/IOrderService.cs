﻿using ETickets.Models;

namespace ETickets.Data.Services
{
    public interface IOrderService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userID, string userEmailAdress);
        Task<List<Order>> GetOrdersByUserIDAndRoleAsync(string userID, string userRole);
    }
}
