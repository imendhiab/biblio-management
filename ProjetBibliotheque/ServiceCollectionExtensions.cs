using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

namespace ProjetBibliotheque
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterForms(this IServiceCollection services)
        {
            //services.AddTransient<MainForm>();
           services.AddTransient<LivreForms.GestionLivre>();
            //services.AddTransient<MembreForms.CategoryDetailsForm>();
            //services.AddTransient<EmpruntForms.RecipesListForm>();

        }
    }
}
