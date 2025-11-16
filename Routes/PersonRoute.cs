using EstudosApiRest.Data;
using EstudosApiRest.Models;

namespace EstudosApiRest.Routes
{
    public static class PersonRoute
    {
        public static void PersonRoutes(this WebApplication app)
        {
            var route = app.MapGroup("/person");

            route.MapPost("/", 
                async (PersonRequest req, AppDbContext context) =>
            {
                var person = new PersonModel (req.name);
                await context.AddAsync(person);
                await context.SaveChangesAsync();
            });
        }
    }
}
