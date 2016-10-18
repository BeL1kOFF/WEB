using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using Store.Domain.Abstract;
using Moq;
using Ninject;
using Store.Domain.Concrete;
using Store.Domain.Entities;

namespace Store.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IGameRepository>().To<EFGameRepository>();
        }
    }
}
