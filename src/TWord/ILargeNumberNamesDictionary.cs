namespace TWord
{
    /// <summary>
    /// Dictionary with large number names
    /// </summary>
    internal interface ILargeNumberNamesDictionary
    {
        /// <summary>
        /// Returns noun for large number name by given index
        /// </summary>
        /// <param name="largeNumberIndex">Index of large number name</param>
        /// <returns>Noun for large number name</returns>
        Noun GetLargeNumberNoun(int largeNumberIndex);
    }
}