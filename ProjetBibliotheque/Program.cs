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

            // Cr�ation d'une collection de services pour l'injection de d�pendances
            var services = new ServiceCollection();

            //Enregistrer RecipeContext avec les options SQlite
            services.AddBiblioDataService();
            // Enregistre le repository 
            services.AddScoped<LivreRepository>();
            //Appliquer les migrations au demarrage
            services.ApplyMigrationsForBiblioDataService();

            // Enregistrer les Forms
            services.RegisterForms();

            // Construction du fournisseur de services qui g�re les instances des d�pendances
            ServiceProvider = services.BuildServiceProvider();

            // R�cup�ration de l'instance de la fen�tre principale via l'injection de d�pendances
            var mainForm = ServiceProvider.GetRequiredService<LivreListForm>();

            // D�marrage de l'application avec la fen�tre principale
            Application.Run(mainForm);
        }
    }
}