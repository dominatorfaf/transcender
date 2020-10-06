using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using System.Configuration;
using System.Collections.Specialized;


namespace Transcender.utils
{
    public class Connector
    {
        private static IMongoDatabase Database;
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        public static IMongoDatabase makeDBConnection() { 
            var client = new MongoClient(connectionString + "true&w=majority");
            return Database = client.GetDatabase("laboratory");
        }
    }
}
