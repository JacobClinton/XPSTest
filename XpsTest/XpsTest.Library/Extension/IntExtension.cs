using System.Text;

namespace XpsTest.Library.Extension;

// Static class that contains extension methods for integer.
public static class IntExtension
{
    // A readonly List that maps integer values to their Roman numeral counterparts.
    private static readonly List<KeyValuePair<int, string>> Numerals = new()
    {
        new KeyValuePair<int, string>(1000, "M"),
        new KeyValuePair<int, string>(900, "CM"),
        new KeyValuePair<int, string>(500, "D"),
        new KeyValuePair<int, string>(400, "CD"),
        new KeyValuePair<int, string>(100, "C"),
        new KeyValuePair<int, string>(90, "XC"),
        new KeyValuePair<int, string>(50, "L"),
        new KeyValuePair<int, string>(40, "XL"),
        new KeyValuePair<int, string>(10, "X"),
        new KeyValuePair<int, string>(9, "IX"),
        new KeyValuePair<int, string>(5, "V"),
        new KeyValuePair<int, string>(4, "IV"),
        new KeyValuePair<int, string>(1, "I"),
    };

    /// <summary>
    /// Extension method to convert an integer into a roman numeral.
    /// <param name="value"></param>
    /// <returns></returns>
    /// </summary>
    public static string ToRoman(this int value)
    {
        // Input validation: if the integer is less than 0 or greater than 2000, throw an exception.
        if (value is < 0 or > 2000) throw new ArgumentOutOfRangeException(nameof(value), "Value must be in the range 0 - 2,000.");

        // StringBuilder is used for performance reasons because it can handle many modifications efficiently.
        var result = new StringBuilder();

        // Iterate through the Numerals list, starting with the largest value.
        foreach (var numeral in Numerals)
        {
            // While the value is greater than or equal to the current numeral, append the numeral to the result and subtract the value.
            while (value >= numeral.Key)
            {
                result.Append(numeral.Value);
                value -= numeral.Key;
            }
        }

        // Convert the StringBuilder to a string and return the result.
        return result.ToString();
    }
}