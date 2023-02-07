namespace FirstWebApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.MapGet("/",async (context) =>
            {
                await context.Response.WriteAsync("<h1>Welcome To Bajaj Ltd.</h1><hr/><h6>Finance Development Company!</h6");
            });
            app.MapGet("/home", async (context) =>
            {
                await context.Response.WriteAsync("<h1>Welcome To Bajaj Home!</h1><hr/><h6>List of Finance Products from Bajaj!</h6");
            });
            app.MapGet("/about", async (context) =>
            {
                await context.Response.WriteAsync("<h1>Welcome To Bajaj - About Page</h1><hr/><h6>Bajaj is Biggest NBFC in India</h6");
            });
            app.MapGet("/contact", async (context) =>
            {
                await context.Response.WriteAsync("<h1>Welcome To Bajaj - Contact Page</h1><hr/><h6>Contact Email: customer@bajajfinserv.in.</h6");
            });
            app.Run();
        }
    }
}
