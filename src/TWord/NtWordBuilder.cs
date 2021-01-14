namespace TWord
{
    public class NtWordBuilder
    {
        /// <summary>
        /// Language of the NtWord
        /// </summary>
        private Language _language;

        /// <summary>
        /// Set language
        /// </summary>
        /// <param name="language">Language symbol</param>
        /// <returns>Builder instance</returns>
        public NtWordBuilder SetLanguage(Language language)
        {
            _language = language;

            return this;
        }

        /// <summary>
        /// Build the builder instance.
        /// </summary>
        /// <returns>NtWord instance</returns>
        public INtWord Build()
        {
            return new NtWord(_language);
        }
    }
}