﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9_MongoDB_Order.Entity
{
    public class Order
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]//otomoatik artan yapıyor
        public string OrderId { get; set; }
        public string  CustomerName{ get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public decimal TotalPrice { get; set; }



    }
}
