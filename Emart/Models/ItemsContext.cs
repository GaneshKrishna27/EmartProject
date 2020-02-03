using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emart.Models
{
    public class ItemsContext:DbContext
    {
        public ItemsContext(DbContextOptions<ItemsContext> options) : base(options) { }

        public DbSet<Items> items { get; set; }
    }
}
