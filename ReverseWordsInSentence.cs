using System;
using System.Collections.Generic;
using System.Linq;

public class ReverseWordsInSentence
{
    /// <summary>
    /// Main
    /// </summary>
    /// <param name="args">Ignored</param>
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Input your sentence:");
            string sInputString = Console.ReadLine();
            string[] words = sInputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // assume at least one space between two single letter words minimum.
            if (words.Length >= 2)
            {
                String sResult = ReverseString(sInputString);
                if (sResult == String.Empty)
                    Console.WriteLine("Error Entry");
                else
                    Console.WriteLine(sResult);
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

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