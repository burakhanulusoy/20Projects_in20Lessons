using MongoDB.Bson;
using MongoDB.Driver;
using Project9_MongoDB_Order.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9_MongoDB_Order.Services
{
    public class OrderOperation
    {
        public void AddOrder(Order order)
        {
            var connection = new MongoDBconnection();
            var ordercollection = connection.GetOrdersCollection();


            var document = new BsonDocument
            {
                { "CustomerName", order.CustomerName },
                { "District", order.District },
                { "City", order.City },
                { "TotalPrice", order.TotalPrice }
            };


            ordercollection.InsertOne(document);
        }



        public List<Order> GetAllOrders()
        {

            var connection = new MongoDBconnection();
            var ordercollection = connection.GetOrdersCollection();

            var orders = ordercollection.Find(new BsonDocument()).ToList();

            List<Order> orderList = new List<Order>();
            foreach (var item in orders)
            {
                Order order = new Order
                {
                    OrderId = item["_id"].ToString(),
                    CustomerName = item["CustomerName"].ToString(),
                    District = item["District"].ToString(),
                    City = item["City"].ToString(),
                    TotalPrice = item["TotalPrice"].ToDecimal()
                };
                orderList.Add(order);
            }

            return orderList;


        }

        public void DeleteOrder(string orderId)
        {
            var collection = new MongoDBconnection();
            var orderCollection = collection.GetOrdersCollection();

            var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(orderId));

            orderCollection.DeleteOne(filter);

        }
    
    
    
    public void updateOrder(Order order)
        {
            var connection = new MongoDBconnection();
            var orderCollection = connection.GetOrdersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(order.OrderId));
            var update = Builders<BsonDocument>.Update
                .Set("CustomerName", order.CustomerName)
                .Set("District", order.District)
                .Set("City", order.City)
                .Set("TotalPrice", order.TotalPrice);
            orderCollection.UpdateOne(filter, update);
        }




    }
}
