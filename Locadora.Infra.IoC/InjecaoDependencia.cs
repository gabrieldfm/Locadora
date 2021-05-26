using Locadora.Aplicacao.Interfaces;
using Locadora.Aplicacao.Servicos;
using Locadora.Dominio.Interfaces.Repositorios;
using Locadora.Dominio.Interfaces.Servicos;
using Locadora.Dominio.Servicos;
using Locadora.Infra.Data.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace Locadora.Infra.IoC
{
    public class InjecaoDependencia
    {
        public static void Registrar(IServiceCollection servicos)
        {
            //Registrando serviços necessarios
            RegistrarAplicacao(servicos);
            RegistrarServicos(servicos);
            RegistrarRepositorios(servicos);
        }

        private static void RegistrarRepositorios(IServiceCollection servicos)
        {
            //Repositorio
            servicos.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            servicos.AddScoped<IFilmeRepositorio, FilmeRepositorio>();
            servicos.AddScoped<IGeneroRepositorio, GeneroRepositorio>();
            servicos.AddScoped<ILocacaoRepositorio, LocacaoRepositorio>();
        }

        private static void RegistrarServicos(IServiceCollection servicos)
        {
            //Domínio
            servicos.AddScoped(typeof(IServicoBase<>), typeof(ServicoBase<>));
            servicos.AddScoped<IServicoFilme, ServicoFilme>();
            servicos.AddScoped<IServicoGenero, ServicoGenero>();
            servicos.AddScoped<IServicoLocacao, ServicoLocacao>();
        }

        private static void RegistrarAplicacao(IServiceCollection servicos)
        {
            //Aplicação
            servicos.AddScoped(typeof(IBaseApp<,>), typeof(ServicoBaseApp<,>));
            servicos.AddScoped<IFilmeApp, FilmeApp>();
            servicos.AddScoped<IGeneroApp, GeneroApp>();
            servicos.AddScoped<ILocacaoApp, LocacaoApp>();
        }
        
    }
}
