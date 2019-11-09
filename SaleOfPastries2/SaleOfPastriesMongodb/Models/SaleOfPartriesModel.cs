using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SaleOfPastriesMongodb.Models
{
    public class Product
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string ProductNumber { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        [BsonRepresentation(BsonType.Decimal128)]
        public string UnitPrice { get; set; }
        public int QuantityOnHand { get; set; }
        public int QuantitySold { get; set; }
    }

    public class Order
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public int OrderNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string EmailAddress { get; set; }
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime OrderDate { get; set; }
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal OrderTotal { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }

    public class OrderDetail
    {
        [BsonId]
        public ObjectId ProductId { get; set; }
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal UnitPrice { get; set; }
        public int OrderQuantity { get; set; }
    }
}
