using System;
using SimpleInjector;

namespace Infrastructure
{
    public class ContaineResolver
    {
        private static Container _container;
        private static Container Container => _container ?? (_container = new Container());

        public static void Register<TService, TImplementation>() where TService : class where TImplementation : class, TService
        {
            Container.Register<TService, TImplementation>();
        }

        public static T GetInstance<T>() where T : class
        {
            return Container.GetInstance<T>();
        }

        public static void Register<T>(Func<T> func) where T : class
        {
            Container.Register(func);
        }
    }
}