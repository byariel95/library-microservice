using library.service.api.Core.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.service.api.Core.ContextMongoDb
{
    public class AuthorContext : IAuthorContext

    {
        private readonly IMongoDatabase _db; 
        public AuthorContext(IOptions<MongoSettings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.ConnectionString);
            
        }
        public IMongoCollection<Author> Authors => _db.GetCollection<Author>("Author");
    }
}
