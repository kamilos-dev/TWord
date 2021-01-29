using System;
using System.Linq;
using System.Reflection;

namespace TWord
{
    internal static class TransformerFactory
    {
        internal static TResult Create<TFactory, TResult>(Language language)
        {
            return CreateConcrete<TFactory, TResult>(language) ??
                throw new InvalidOperationException($"{typeof(INumberTransformer)} for language {language} not found!");
        }

        private static TResult CreateConcrete<TFactory, TResult>(Language language)
        {
            var types = typeof(TransformerFactory).Assembly.GetTypes().ToList();

            foreach(var type in types)
            {
                if (!typeof(TFactory).IsAssignableFrom(type))
                    continue;

                var attribute = type.GetCustomAttribute<LanguageTransformerAttribute>();

                if (attribute == null)
                    continue;

                if(attribute.Language != language)
                    continue;

                var instance = Activator.CreateInstance(type);

                var createMethod = type.GetMethod("Create");

                return (TResult)createMethod.Invoke(instance, null);
            }

            return default;
        }
    }
}
