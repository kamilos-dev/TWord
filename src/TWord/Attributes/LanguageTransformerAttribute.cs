using System;

namespace TWord
{
    /// <summary>
    /// Marker attribute for any types of transformers
    /// </summary>
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