using AutoMapper;
using Ingenico.Application.Interfaces;
using Ingenico.Application.Services;
using Ingenico.Domain.Interfaces;
using Ingenico.Domain.Services;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;

namespace Ingenico.Infra.IoC
{
    public class InjetorDependencias
    {
        public static void Registrar()
        {

            //Mapper.(config =>
            //{
            //    config.CreateMap<IAppCalcularIdadeService, AppCalcularIdadeService>();

            //    config.CreateMap<IAppCalcularIdadeService, AppCalcularIdadeService>();
            //});

            //var tesrt = Mapper.CreateMap<AppCalcularIdadeService, IAppCalcularIdadeService>();

            var container = new UnityContainer();
            //Aplicação
            container.RegisterSingleton<IAppCalcularIdadeService, AppCalcularIdadeService>();
            //Domínio
            container.RegisterSingleton<ICalcularIdadeService, CalcularIdadeService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
