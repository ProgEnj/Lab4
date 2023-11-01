namespace Lab4;

/// <summary>
/// Represents base for items of catalog
/// </summary>
public abstract class PrintedText
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int AmountOfPages { get; set; }
    public DateTime PublicationDate { get; set; }
    public string Country { get; set; }
    public string OriginalTitle { get; set; }

    public PrintedText(string title, string author, int amountOfPages, DateTime publicationDate, string country,
        string originalTitle)
    {
        Title = title;
        Author = author;
        AmountOfPages = amountOfPages;
        PublicationDate = publicationDate;
        Country = country;
        OriginalTitle = originalTitle;
    }

    public PrintedText(string title, string author, int amountOfPages)
    {
        Title = title;
        Author = author;
        AmountOfPages = amountOfPages;
    }
    /// <summary>
    /// Prints all fields of an object
    /// </summary>
    public virtual void PrintFullInfo()
    {
        Console.Write(Title + " | " + Author + "\n");
        Console.WriteLine("Publication date: " + PublicationDate);
        Console.WriteLine("Amount of pages: " + AmountOfPages);
        Console.WriteLine("Country: " + Country);
        Console.WriteLine("Original Title" + OriginalTitle);
    }

    /// <summary>
    /// Prints only title and author
    /// </summary>
    public virtual void PrintShortInfo()
    {
        Console.Write(Title + " | " + Author + "\n");
    }
}