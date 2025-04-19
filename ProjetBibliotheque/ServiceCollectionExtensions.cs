using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotheque.data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ProjetBibliotheque
{
    public static class ServiceCollectionExtensions
    {
  //Enregistrer des formulaires dans le système d’injection de dépendances de .NET
        public static void RegisterForms(this IServiceCollection services)
        {
            //services.AddTransient<MainForm>();
            //services.AddTransient<LivreForms.LivreListForm>();
            services.AddTransient<MembreRepository>();

            services.AddTransient<MembreForms.MembreListForm>();
            //services.AddTransient<EmpruntForms.EmpruntListForm>();

        }
    }
}
