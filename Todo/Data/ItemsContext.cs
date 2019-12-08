﻿using Microsoft.EntityFrameworkCore;
using Todo.Model;

namespace Todo.Data
{
    public class ItemsContext : DbContext
    {
        public ItemsContext(DbContextOptions<ItemsContext> options) : base(options)
        {
            
        }

        public DbSet<Item> Items { get; set; }
        
    }
}