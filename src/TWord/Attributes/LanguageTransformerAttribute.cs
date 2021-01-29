using System;

namespace TWord
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    internal class LanguageTransformerAttribute
        : Attribute
    {
        public readonly Language Language;

        public LanguageTransformerAttribute(Language language)
        {
            Language = language;
        }
    }
}