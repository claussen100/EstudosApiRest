using EstudosApiRest.Data;
using EstudosApiRest.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudosApiRest.Routes
{
    public static class PersonRoute
    {
        public static void PersonRoutes(this WebApplication app)
        {
            var route = app.MapGroup("/person");

            route.MapGet("/", 
                async (AppDbContext context) =>
            {
                return await context.People.ToListAsync();
            });

            route.MapPost("/", 
                async (PersonRequest req, AppDbContext context) =>
            {
                var person = new PersonModel (req.name);
                await context.AddAsync(person);
                await context.SaveChangesAsync();
            });

            route.MapPut("/{id:guid}", 
                async (Guid id, PersonRequest req, AppDbContext context) =>
            {
                var person = await context.People.FindAsync(id);
                if (person is null)
                {
                    return Results.NotFound();
                }
                person.Name = req.name;
                context.Update(person);
                await context.SaveChangesAsync();
                return Results.Ok();
            });

            route.MapDelete("/{id:guid}", 
                async (Guid id, AppDbContext context) =>
            {
                var person = await context.People.FindAsync(id);
                if (person is null)
                {
                    return Results.NotFound();
                }
                context.Remove(person);
                await context.SaveChangesAsync();
                return Results.Ok();
            });
        }
    }
}
