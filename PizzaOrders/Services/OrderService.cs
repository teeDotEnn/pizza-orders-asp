/* File Name: OrderService.cs
 * Purpose: To provide CRUD functionality to the
 *          webapp when it is working in the orders collection
 * Rev History:
 *     Created Aug 2020 by Tim Nigh
 */
using System.Collections.Generic;
using MongoDB.Driver;
using PizzaOrders.Models;

namespace PizzaOrders.Services
{
    public class OrderService
    {
        private readonly IMongoCollection<Order> _orders;

        public OrderService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _orders = database.GetCollection<Order>("orders");
        }
    }
}