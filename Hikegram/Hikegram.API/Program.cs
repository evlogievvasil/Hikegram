using Hikegram.API.Configuration;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ServicesContainer.RegisterServices(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
PipelineConfiguration.Configure(app);