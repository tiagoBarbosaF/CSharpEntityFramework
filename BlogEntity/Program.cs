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
            // var user = new User
            // {
            //     Name = "Tiago Barbosa",
            //     Email = "tiago@gmail.com",
            //     Bio = "Developer",
            //     Slug = "tiago-barbosa",
            //     Image = "https://",
            //     GitHub = "tiagoBarbosaF",
            //     PasswordHash = "123456"
            // };
            // using var context = new BlogEntityDataContext();
            // context.Users.Add(user);
            // context.SaveChanges();
            // context.Users.Add(new User
            // {
            //     Name = "Tiago Barbosa",
            //     Email = "tiago@gmail.com",
            //     Bio = "Developer",
            //     PasswordHash = "123456",
            //     Image = "http://",
            //     Slug = "tiago-barbosa"
            // });
            // context.SaveChanges();

            // var user = context.Users.FirstOrDefault();
            // var post = new Post
            // {
            //     Author = user,
            //     Body = "Meu novo artigo",
            //     Category = new Category
            //     {
            //         Name = "Backend",
            //         Slug = "backend"
            //     },
            //     Summary = "Vamos conferir como se ...",
            //     Slug = "meu-novo-artigo",
            //     Title = "Meu novo artigo",
            //     CreateDate = DateTime.Now
            // };
            // context.Posts.Add(post);
            // context.SaveChanges();

            // Utilizando Data annotations
            /*var user = new User
            {
                Name = "Tiago Barbosa",
                Slug = "tiago-barbosa",
                Email = "tiago@gmail.com",
                Bio = "Developer",
                Image = "https://avatars.githubusercontent.com/u/63923718?v=4",
                PasswordHash = "123456"
            };
            
            var category = new Category
            {
                Name = "Backend",
                Slug = "backend"
            };
            
            var post = new Post
            {
                Author = user,
                Category = category,
                Body = "<p>Hello</p>",
                Slug = "ef-core",
                Summary = "Aprendendo EF Core",
                Title = "EF Core",
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now
            };
            
            context.Posts.Add(post);
            context.SaveChanges();

            var posts = context
                .Posts
                .AsNoTracking()
                .Include(x=>x.Author)
                .Include(x=>x.Category)
                .OrderByDescending(x => x.LastUpdateDate)
                .ToList();
            
            foreach (var post in posts)
            {
                Console.WriteLine($"\n\n{post.Title} escrito por {post.Author?.Name} em {post.Category.Name}\n\n");
            }

            var post = context
                .Posts
                .Include(x => x.Author)
                .Include(x => x.Category)
                .OrderByDescending(x => x.LastUpdateDate)
                .FirstOrDefault();
            
            post.Author.Name = "Peter Mendonça";
            
            context.Posts.Update(post);
            context.SaveChanges();*/
        }
    }
}