using library.service.api.Core.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.service.api.Core.ContextMongoDb
{
    public interface IAuthorContext
    {
        IMongoCollection<Author> Authors { get; }
    }
}
