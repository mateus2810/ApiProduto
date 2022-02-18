using Microsoft.Extensions.DependencyInjection;
using Repository.Interface;
using Repository.Repository;
using Services.Interfaces;
using Services.Services;

namespace WebApiProduto.Middlewares
{
    public static class InjecaoDependencia
    {

        public static void AdicionarInjecaoDependencia(this IServiceCollection services)
        {
            services.AddSingleton<IProdutoRepository, ProdutoRepository>();

            services.AddTransient<IProdutoService, ProdutoService>();
            //services.AddTransient<IOficinasServico, OficinasServico>();
        }
    }
}
