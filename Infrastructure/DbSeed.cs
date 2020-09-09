using System;
using Infrastructure;

using Entities;

namespace Infrastructure
{
    public class DbSeed : IDbSeed
    {
        public void SeedDb(TodoContext ctx)
        {
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
            ctx.Tasks.Add(new Todo()
            {
                Id = 1,
                Deadline = new DateTime(2020, 8, 4),
                IsDone = false,
                Description = "Recycling"
            });
            ctx.Tasks.Add(new Todo()
            {
                Deadline = new DateTime(2020, 8, 3),
                Id = 2,
                Description = "Wash clothes and hangi t up",
                IsDone = true
            });

            ctx.SaveChanges();
        }
    }
}