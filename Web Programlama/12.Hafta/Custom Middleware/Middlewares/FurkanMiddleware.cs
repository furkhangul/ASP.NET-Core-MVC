using Microsoft.AspNetCore.Mvc;

namespace Project.Middlewares
{
    public class FurkanMiddlware
    {
        RequestDelegate _next;
        public FurkanMiddlware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("Furkan Baba geldi");
            await _next.Invoke(context);
            Console.WriteLine("Furkan Baba gitti");
        }
    }
}
