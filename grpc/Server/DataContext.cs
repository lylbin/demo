﻿using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Server
{
    public class DataContext : IDataContext
    {
        public IMongoDatabase Database { get; set; }

        public DataContext(IConfigurationRoot config)
        {
            var client = new MongoClient(config.GetConnectionString("mongodb"));
            Database = client.GetDatabase("aSQ0cWkEshl8NiVn");
        }
    }
}
