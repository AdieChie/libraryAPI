using BookLibraryApi.data.models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    { 
                        Title ="Book Title",
                        Authour = "Adie",
                        ReleaseDate = DateTime.Now,
                        Category = "Technology",
                        isBorrowed = false,

                    });

                    
                    context.SaveChanges();
                }
               
                

            }
        }
    }
}
