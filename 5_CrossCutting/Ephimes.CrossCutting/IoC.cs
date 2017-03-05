using CommonServiceLocator.NinjectAdapter.Unofficial;
using Microsoft.Practices.ServiceLocation;
using Ninject.Modules;
namespace Ephimes.CrossCutting
{
    public class IoC : NinjectModule
    {
        public IoC()
        {
            Kernel = GetNinjectModules();
            ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(Kernel));
        }

        public new IKernel Kernel { get; private set; }

        public override void Load()
        {
            Bind<IEmailApplication>().To<EmailApplication>();

            Bind<INotaFiscalApplication>().To<NotaFiscalApplication>();
            Bind<INotaFiscalService>().To<NotaFiscalService>();
            Bind<INotaFiscalRepository>().To<NotaFiscalRepository>();
            //Bind<IDbContext>().To<DataContext>();
            Bind<ISolicitacaoApplication>().To<SolicitacaoApplication>();
            Bind<ISolicitacaoService>().To<SolicitacaoService>();
            Bind<ISolicitacaoRepository>().To<SolicitacaoRepository>();
            //Bind<IDbContext>().To<DataContext>();
        }

        private StandardKernel GetNinjectModules()
        {
            return new StandardKernel(
                new ServiceNinjectModule(),
                new InfrastructureNinjectModule(),
                new RepositoryNinjectModule(),
                new ApplicationServiceNinjectModule());
        }
    }
}
