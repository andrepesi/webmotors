using AutoMapper;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotors.Application.Abstractions;
using WebMotors.Application.AutoMap;
using WebMotors.Application.Implementations;
using WebMotors.Domain.Abstractions;
using WebMotors.Domain.Abstractions.Service;
using WebMotors.Domain.Implementations;
using WebMotors.Infra.Data;
using WebMotors.Infra.Data.Repositories;

namespace WebMotors.CrossCutting.IoC
{
    public class IoCModule : NinjectModule
    {
        public override void Load()
        {
            var mapperConfiguration = AutoMapperConfig.RegisterMappings();
            Bind<MapperConfiguration>().ToConstant(mapperConfiguration).InSingletonScope();

            
            Bind<IMapper>().ToMethod(ctx =>
                 new Mapper(mapperConfiguration, type => ctx.Kernel.Get(type)));
            Bind<WebMotorsContext>().ToSelf();
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind(typeof(IRepository<>)).To(typeof(ARepository<>));
            Bind(typeof(IService<>)).To(typeof(AService<,>));
            Bind(typeof(IAppService<,,>)).To(typeof(AAppService<,,>));
            Bind<IAnuncioRepository>().To<AnuncioRepository>();
            Bind<IAnuncioService>().To<AnuncioService>();
            Bind<IAnuncioAppService>().To<AnuncioAppService>();
        }
    }
}
