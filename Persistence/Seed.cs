using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post {
                        Title = "First post",
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labor ",
                        //Date = DateTime.Now.AddDays(-10)
                    },
                    new Post {
                        Title = "Second post",
                        Body = "Enim neque volutpat ac tincidunt vitae semper. Nulla facillisi etiam dignissim diam. Egestas sed ",
                        //Date = DateTime.Now.AddDays(-7)
                    },
                    new Post{
                        Title = "Third post",
                        Body = "Imperdiet dui accumsan sit amet nulla. Ultricies mi eget mauris pharetra et ultrices. nibh ipsum ",
                        //Date = DateTime.Now.AddDays(-4)
                    }
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}