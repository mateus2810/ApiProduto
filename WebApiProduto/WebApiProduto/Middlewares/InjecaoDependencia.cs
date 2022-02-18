using Microsoft.Extensions.DependencyInjection;
using Repository.Interface;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProduto.Middlewares
{
    public static class InjecaoDependencia
    {

        public static void AdicionarInjecaoDependencia(this IServiceCollection services)
        {
            services.AddSingleton<IProdutoRepository, ProdutoRepository>();
        }
    }
}
