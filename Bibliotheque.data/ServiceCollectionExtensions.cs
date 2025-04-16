using Bibliotheque.data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Bibliotheque.data
{
    public static class ServiceCollectionExtensions
    {
        ///<summary>
        /// Enregistrer RecipeContext avec les options SQLite et initialiser la base de données avec des données de test
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>


        public static IServiceCollection AddBiblioDataService(this IServiceCollection services)
        {
            services.AddDbContext<BibliothequeContext>(options =>
            {
                options.UseSqlite("Data Source=bibliotheque.db");
                //Utiliser Seeding pour initialiser la base de données avec des données de test
                options.UseSeeding((context, _) =>
                {
                    //(context as BibliothequeContext).Seed();

                });
            }
            , //Transient pour eviter les problemes de scope dans winforms
            ServiceLifetime.Transient);
            return services;
        }

        ///<summary>
        ///</summary>

        public static void ApplyMigrationsForBiblioDataService(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<BibliothequeContext>();
                var pendingMigrations = dbContext.Database.GetPendingMigrations();
                if (pendingMigrations.Any())
                {
                    dbContext.Database.Migrate();
                }
            }




        }






    }
}
