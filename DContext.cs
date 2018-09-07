using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using PeopleSearch.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleSearch.Models
{
    public class DContext : DbContext
    {
        //public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        private IMongoDatabase _db;
        public DContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<People> People => _db.GetCollection<People>("People");
    
        public DbSet<People> poeple { get; set; }
    }
}
