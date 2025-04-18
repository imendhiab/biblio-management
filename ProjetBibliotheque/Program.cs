using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Bibliotheque.data;
using ProjetBibliotheque.LivreForms;
using Bibliotheque.data.Repositories;

namespace ProjetBibliotheque
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }


        [STAThread]
        static void Main()
        {
            // Initialisation de la configuration de l'application
            ApplicationConfiguration.Initialize();

            // Création d'une collection de services pour l'injection de dépendances
            var services = new ServiceCollection();

            //Enregistrer RecipeContext avec les options SQlite
            services.AddBiblioDataService();
            // Enregistre le repository 
            services.AddScoped<LivreRepository>();
            //Appliquer les migrations au demarrage
            services.ApplyMigrationsForBiblioDataService();

            // Enregistrer les Forms
            services.RegisterForms();

            // Construction du fournisseur de services qui gère les instances des dépendances
            ServiceProvider = services.BuildServiceProvider();

            // Récupération de l'instance de la fenêtre principale via l'injection de dépendances
            var mainForm = ServiceProvider.GetRequiredService<LivreListForm>();

            // Démarrage de l'application avec la fenêtre principale
            Application.Run(mainForm);
        }
    }
}