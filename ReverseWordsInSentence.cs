using System;
using System.Collections.Generic;

public class ReverseWordsInSentence
{

    /// <summary>
    /// Reverse words in a string and return it, or return and empty string on failure.
    /// </summary>
    /// <param name="sInString"></param>
    /// <returns> reversed sInString</returns>
    public static String ReverseString(String sInString)
    {
        try
        {
            return String.Join(" ", sInString.Split(' ').Reverse());
        }
        catch (Exception ex)
        {
            // possibly show error from builtin function...
            // Console.Write(ex.ToString());
            return String.Empty;
        }
    }
}