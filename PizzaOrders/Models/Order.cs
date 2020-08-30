using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace PizzaOrders.Models
{
    public class Order
    {
        public string firstName{get;set;}
        public string lastName{get;set;}
        public string streetNumber{get;set;}
        public string streetname{get;set;}
        public string email{get;set;}
        public string telNumber{get;set;}
        public string numberOfPizzas{get;set;}
        public string size{get;set;}
        public string dough{get;set;}
        public string sauce{get;set;}
        public string cheese{get;set;}
        public string toppings{get;set;}
    }
}