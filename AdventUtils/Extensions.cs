using System;
namespace AdventUtils;

public static class AdventExtensions
{
    public static IEnumerable<string> ReadLines(this string s)
    {
        string line;
        using var sr = new StringReader(s);
        while ((line = sr.ReadLine()) != null)
            yield return line;
    }

    public static string Reverse(this string s)
    {
        char[] array = s.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}
