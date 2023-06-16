using System.ComponentModel.DataAnnotations;
using XpsTest.Library.Extension;

namespace XpsTest.Library.Model;

// Converts an integer to a Roman numeral.
public class IntConverter
{
    // Input integer, must be in the range 1 - 2,000.
    [Required, Range(1, 2000)]
    public int InputValue { get; set; }

    // Output Roman numeral. Null until Convert() is called.
    public string? OutputValue { get; private set; }

    // Converts InputValue to a Roman numeral and stores it in OutputValue.
    public void Convert()
    {
        OutputValue = InputValue.ToRoman();
    }

    // Clears the OutputValue.
    public void Clear()
    {
        OutputValue = null;
    }
}