namespace Project.Extensions
{
    static public class Extensions
    {
        public static IApplicationBuilder UseFurkan(this IApplicationBuilder app)
        {
            return app.UseMiddleware<Middlewares.FurkanMiddlware>();
        }
    }
}
