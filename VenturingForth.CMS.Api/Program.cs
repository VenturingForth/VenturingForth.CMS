var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScope<IContentAuthoringService, ContentAuthoringService>();