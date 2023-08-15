using Microsoft.EntityFrameworkCore;
using DeepThoughtsaaS.Core;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ThoughtDbContext>(opt => 
        opt.UseSqlServer(builder.Configuration.GetConnectionString("ThoughtDb")));
builder.Services.AddTransient<ThoughtManager>();

var app = builder.Build();

app.MapGet("/", async (ThoughtManager thoughtManager) => await thoughtManager.GetRandomThoughtAsync());

app.MapGet("/{id}", async (ThoughtManager thoughtManager, int id) => await thoughtManager.GetThoughtAsync(id));

app.MapGet("/list", async (ThoughtManager thoughtManager) => await thoughtManager.GetThoughtsAsync());

app.MapPut("/{id}", async (ThoughtManager thoughtManager, int id, [FromQuery]bool isUpvote) => await thoughtManager.VoteAsync(id, isUpvote));

app.Run();
