using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string filePath = "replace with path to text file";

        try
        {
            // Read the content of the text file
            string paragraph = File.ReadAllText(filePath);

            ////regex pattern to handle repeated words separated by spaces or punctuation
            //string pattern = @"\b(\w+)[\s\p{P}]+\1\b";

            // Modified regex pattern to handle repeated words with letters only
            string pattern = @"\b([A-Za-z]+)[\s\p{P}]+\1\b";

            // Use RegexOptions.IgnoreCase for case-insensitive matching
            MatchCollection matches = Regex.Matches(paragraph, pattern, RegexOptions.IgnoreCase);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}