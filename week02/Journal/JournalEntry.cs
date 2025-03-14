using System;

public class JournalEntry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    //Showing Creativity and Exceeding Requirements
    public string Mood { get; set; }
    public string Tags { get; set; }

    // Constructor with optional parameters for Mood and Tags
    public JournalEntry(string prompt, string response, string mood = "", string tags = "")
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Prompt = prompt;
        Response = response;
        Mood = mood;
        Tags = tags;
    }

    // Convert entry to CSV format
    public string ToCsv()
    {
        return $"{EscapeCsv(Date)},{EscapeCsv(Prompt)},{EscapeCsv(Response)},{EscapeCsv(Mood)},{EscapeCsv(Tags)}";
    }

    // Convert CSV line back to JournalEntry object
    public static JournalEntry FromCsv(string csvLine)
    {
        string[] parts = csvLine.Split(','); 

        if (parts.Length == 5)
        {
            return new JournalEntry(
                UnescapeCsv(parts[1]),
                UnescapeCsv(parts[2]),
                UnescapeCsv(parts[3]),
                UnescapeCsv(parts[4])
            )
            {
                Date = UnescapeCsv(parts[0]) 
            };
        }
        return null;
    }

    private static string EscapeCsv(string input)
    {
        if (input.Contains(",") || input.Contains("\""))
        {
            return $"\"{input.Replace("\"", "\"\"")}\"";
        }
        return input;
    }

    private static string UnescapeCsv(string input)
    {
        return input.Trim('"').Replace("\"\"", "\"");
    }

    // Proper ToString() method
    public override string ToString()
    {
        return $"{Date} | {Prompt} | {Response} | Mood: {Mood} | Tags: {Tags}";
    }
}
