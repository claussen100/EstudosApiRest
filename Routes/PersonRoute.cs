using EstudosApiRest.Models;

namespace EstudosApiRest.Routes
{
    public static class PersonRoute
    {
        public static void PersonRoutes(this WebApplication app)
        {
            app.MapGet("/person", () =>
            {
                return new PersonModel("Patrick Claussen");
            });
        }
    }
}
