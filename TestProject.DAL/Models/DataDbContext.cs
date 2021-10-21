using Bogus;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.DAL.Models
{
    public partial class DataDbContext: DbContext
    {
        public DataDbContext()
        {
        }

        public DataDbContext(DbContextOptions<DataDbContext> options)
            :base(options)
        {
        }

        public virtual DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DataSeed(modelBuilder);
        }

        private void DataSeed(ModelBuilder modelBuilder)
        {
            var random = new Random();
            var faker = new Faker<Item>()
                .RuleFor(i => i.ItemId, f => f.IndexFaker+1)
                .RuleFor(i => i.Title, f => f.Lorem.Sentence(random.Next(1, 6)))
                .RuleFor(i => i.Description, f => f.Lorem.Paragraph())
                .RuleFor(i => i.ImageUrl, f => f.Image.PicsumUrl())
                .RuleFor(i => i.PublicationTime, f => f.Date.Recent());



            modelBuilder.Entity<Item>().HasData(
                faker.Generate(1000)
                );
        }

    }
}
