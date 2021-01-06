namespace TWord
{
    /// <summary>
    /// Dictionary with large number names
    /// </summary>
    internal interface ILargeNumberNamesDictionary
    {
        Noun GetLargeNumberNoun(int largeNumberIndex);
    }
}