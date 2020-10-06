using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Configuration;
using System.Collections.Specialized;


namespace Transcender.utils
{
    public class Connector
    {
        public static MongoClient client = new MongoClient("mongodb+srv://master:$&C>s~<$7n.U'es\"@cluster0.906uy.mongodb.net/laboratory?retryWrites=true&w=majority");
        public static IMongoDatabase database = client.GetDatabase("dummyDB");
        public static IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("users");

        /*
        var document = new BsonDocument{
                { "_id", "982e5769-0d47-4a2e-8091-8e783aa8ac0e" },
                { "username", "admin"},
                { "password", Tools.Encrypt("123")}
            };

        Connector.collection.InsertOne(document);
        */
    }
}
