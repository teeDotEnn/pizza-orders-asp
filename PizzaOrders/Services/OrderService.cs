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

        ///<summary>
        /// Inserts a new order object into the db
        ///</summary>
        ///<params>
        /// the order object to be inserted
        ///</params>

        public Order Create(Order order)
        {
            _orders.InsertOne(order);
            return order;
        }

        public IList<Order> Read()=> 
            _orders.Find(sub => true).ToList();

        public Order Find(string telNumber) =>
            _orders.Find(sub => sub.telNumber == telNumber).SingleOrDefault();
        
        public void Update(Order order)=>
            _orders.ReplaceOne(sub => sub.telNumber == order.telNumber, order);
        
        
    }
}