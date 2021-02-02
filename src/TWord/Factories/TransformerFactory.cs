using System;
using System.Linq;
using System.Reflection;

namespace TWord
{
    internal abstract class TransformerFactory
    {
        internal TResult Create<TFactory, TResult>(Language language)
        {
            var factoryInstance = GetFactoryInstance<TFactory>(language);
            return InvokeMethod<TResult>(factoryInstance, "Create");
        }

        internal TResult GetDefaultBuilder<TFactory, TResult>(Language language)
        {
            var factoryInstance = GetFactoryInstance<TFactory>(language);
            return InvokeMethod<TResult>(factoryInstance, "GetDefaultBuilder");
        }

        private TFactory GetFactoryInstance<TFactory>(Language language)
        {
            var types = typeof(TransformerFactory).Assembly.GetTypes().ToList();

            foreach (var type in types)
            {
                if (!typeof(TFactory).IsAssignableFrom(type))
                    continue;

                var attribute = type.GetCustomAttribute<LanguageTransformerAttribute>();

                if (attribute == null)
                    continue;

                if (attribute.Language != language)
                    continue;

                return (TFactory)Activator.CreateInstance(type);
            }

            return default;
        }

        private TResult InvokeMethod<TResult>(object objInstance, string methodName)
        {
            var method = objInstance.GetType().GetMethod(methodName);
            return (TResult)method.Invoke(objInstance, null);
        }
    }
}