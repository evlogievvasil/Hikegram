using Hikegram.API.Configuration;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
HikegramServiceContainer.RegisterServices(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
HikegramPipelineConfiguration.Configure(app);