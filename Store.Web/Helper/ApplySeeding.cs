﻿using Microsoft.EntityFrameworkCore;
using Store.Data.Contexts;
using Store.Repository;

namespace Store.Web.Helper
{
    public class ApplySeeding
    {

        public static async Task ApplySeedingAsync(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var loggerFactory = services.GetRequiredService<ILoggerFactory>();
                try
                {
                    var context = services.GetRequiredService<StoreDbContext>();

                    await context.Database.MigrateAsync(); // if you have A problem in igration(you Give the code to another person with out the data base)

                    await StoreContextSeed.SeedAsync(context, loggerFactory);
                }
                catch (Exception ex)
                {
                    var logger = loggerFactory.CreateLogger<ApplySeeding>();
                    logger.LogError(ex.Message);
                }
            }
        }
    }
}
