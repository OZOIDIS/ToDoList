var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

#region RoutingDoc

//Endpoint selection middleware for given HTTP request.
//An endpoint in ASP.NET Core is a handler that returns a response. Each endpoint is associated with a URL pattern.
//The WebApplication stores the registered routes and endpoints in a dictionary making them available to the routing middlewares.
//Endpoint routing uses a two-step process. The RoutingMiddleware selects which endpoint to execute, and the EndpointMiddleware executes it.
//If the request URL doesn’t match a route template, the endpoint middleware won’t generate a response.

//Model-Binding
//The RoutingMiddleware is responsible for matching an incoming request to an endpoint and for extracting the route parameter values, but all the values at that point are strings.
//It’s only in the EndpointMiddleware that the string values are converted to the real argument types (such as int) needed to execute the endpoint handler.


#endregion
//Adds an EndpointRoutingMiddleware middleware
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
