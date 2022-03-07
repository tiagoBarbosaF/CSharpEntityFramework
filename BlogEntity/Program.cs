using System;
using System.Linq;
using BlogEntity.Data;
using BlogEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogEntityDataContext())
            {
                // var tag = new Tag { Name = "ASP.NET", Slug = "aspnet"};
                // context.Tags.Add(tag);
                // context.SaveChanges();
                // var tag2 = new Tag { Name = "NET", Slug = "dotnet"};
                // context.Tags.Add(tag2);
                // context.SaveChanges();

                // var tag = context.Tags.FirstOrDefault(x => x.Id == 4);
                // tag.Name = ".NET";
                // tag.Slug = "dotnet";
                
                // context.Update(tag);
                // context.SaveChanges();

                // var tag = context.Tags.FirstOrDefault(x => x.Id == 2);
                // context.Remove(tag);
                // context.SaveChanges();

                // var tags = context.Tags.AsNoTracking().ToList();
                // foreach (var tag in tags)
                // {
                //     Console.WriteLine(tag.Name);
                // }

                var tags = context.Tags.AsNoTracking().FirstOrDefault(x => x.Id == 3);
                Console.WriteLine($"Tags: {tags.Name}");
            }
        }
    }
}