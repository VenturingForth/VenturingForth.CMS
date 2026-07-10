using VenturingForth.CMS.Application;
using VenturingForth.CMS.Application.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IContentAuthoringService, ContentAuthoringService>();

var app = builder.Build();

app.Run();