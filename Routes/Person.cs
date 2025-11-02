namespace EstudosApiRest.Routes
{
    public static class Person
    {
        public static void PersonRoutes(this WebApplication app)
        {
            app.MapGet("/person", () =>
            {
                return Results.Ok("Get Person");
            });
            app.MapPost("/person", () =>
            {
                return Results.Ok("Post Person");
            });
            app.MapPut("/person", () =>
            {
                return Results.Ok("Put Person");
            });
            app.MapDelete("/person", () =>
            {
                return Results.Ok("Delete Person");
            });
        }
    }
}
