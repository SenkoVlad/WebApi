using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using WebApi;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<HelloService>(new HelloService());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/", () => "Hello World!");
app.MapGet("/hi", () => "Hi World!");
app.MapGet("/hello", (HttpContext context, HelloService helloService) => helloService.SayHello(context.Request.Query["name"].ToString()));

app.Run();
