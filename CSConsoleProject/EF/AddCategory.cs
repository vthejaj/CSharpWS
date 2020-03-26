﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleProject.EF
{
    class AddCategory
    {
        static void Main(string[] args)
        {
            var ctx = new InventoryContext();
            ctx.Database.Log = Console.WriteLine;

            var cat = new Category { Code = "c1", Description = "Category1" };

            ctx.Categories.Add(cat); // Added
            ctx.SaveChanges();  // Insert 
            ctx.Dispose(); // Detached 
        }
    }
}
