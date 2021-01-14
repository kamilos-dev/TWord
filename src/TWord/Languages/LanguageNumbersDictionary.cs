using System.Collections.Generic;

namespace TWord
{
    ///<inheritdoc/>
    internal abstract class LanguageNumbersDictionary : ILanguageNumbersDictionary
    {
        ///<inheritdoc/>
        public abstract string Zero { get; }

        ///<inheritdoc/>
        public abstract string Minus { get; }

        ///<inheritdoc/>
        public abstract string Hyphen { get; }

        protected abstract Dictionary<int, string> _ones { get; }

        protected abstract Dictionary<int, string> _teens { get; }

        protected abstract Dictionary<int, string> _tens { get; }

        protected abstract Dictionary<int, string> _hundreds { get; }


        ///<inheritdoc/>
        public virtual string GetOnesWord(int value)
        {
            return _ones[value];
        }

        ///<inheritdoc/>
        public virtual string GetTeensWord(int value)
        {
            return _teens[value];
        }

        ///<inheritdoc/>
        public virtual string GetTensWord(int value)
        {
            return _tens[value];
        }

        ///<inheritdoc/>
        public virtual string GetHundredsWord(int value)
        {
            return _hundreds[value];
        }
    }
}
