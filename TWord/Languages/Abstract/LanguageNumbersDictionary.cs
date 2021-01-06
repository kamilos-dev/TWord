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

        protected abstract Dictionary<int, string> _ones { get; }

        protected abstract Dictionary<int, string> _teens { get; }

        protected abstract Dictionary<int, string> _tens { get; }

        protected abstract Dictionary<int, string> _hundreds { get; }        

        ///<inheritdoc/>
        public string GetOnesWord(int value)
        {
            return _ones[value];
        }

        ///<inheritdoc/>
        public string GetTeensWord(int value)
        {
            return _teens[value];
        }

        ///<inheritdoc/>
        public string GetTensWord(int value)
        {
            return _tens[value];
        }

        ///<inheritdoc/>
        public string GetHundredsWord(int value)
        {
            return _hundreds[value];
        }
    }
}
