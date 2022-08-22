using System;
using System.Collections.Generic;
using System.Text;
using CoreWebAPI2.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace CoreWebAPI2.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Text>().HasData(new Text
            {
                TextId = 1,
                TextString = "Numbers and alphabets are the basic teachings that a child learns in the house even before his steps reach the door of the school. This is the main foundation of their learning process. As the child starts going to school, he/she discovers how to spell words and numbers. They learn to differentiate the sounds and pronunciation of the words and numbers. And finally, they understand why we use numbers and words. These simple components become an undeniable part of their existence then and in the years to come. Be it anywhere in life, numbers are a facet no one can wave away. Be it in everyday usage or in making important decisions, numbers have a chance in representing facts which wouldn’t be possible otherwise. ",

            });
        }
        public DbSet<Text> TextTable { get; set; }
    }
}
