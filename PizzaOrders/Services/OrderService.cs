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
            _orders = database.GetCollection<Order>(settings.CollectionName);
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

        public List<Order> Get() =>
            _orders.Find(order => true).ToList();

        public Order GetOrder(string id) =>
            _orders.Find(order => order.orderId == id).FirstOrDefault();

        public void Update(string id, Order orderIn)=>
            _orders.ReplaceOne(order => order.orderId == id, orderIn);

        public void Remove(Order orderIn)=>
            _orders.DeleteOne(order=>order.orderId == orderIn.orderId);
        public void Remove(string id)=>
            _orders.DeleteOne(order=>order.orderId == id);
        
        
    }
}