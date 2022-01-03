﻿namespace Hikegram.API.Configuration
{
  public static class PipelineConfiguration
  {
    public static void Configure(WebApplication app)
    {
      if (app.Environment.IsDevelopment())
      {
        app.UseSwagger();
        app.UseSwaggerUI();
      }

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthentication();
      app.UseAuthorization();

      app.MapControllers();

      app.Run();
    }
  }
}
