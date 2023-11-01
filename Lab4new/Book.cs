namespace Lab4;
/// <summary>
/// Represents book
/// </summary>
public class Book : PrintedText
{
    private bool IsIllustrated;
    private int ISBN;

    public Book(string title, string author, int amountOfPages, DateTime publicationDate, string country,
        string originalTitle, bool isIllustrated, int isbn) : base(title, author, amountOfPages, publicationDate,
        country,
        originalTitle)
    {
        IsIllustrated = isIllustrated;
        ISBN = isbn;
    }

    public Book(string title, string author, int amountOfPages, bool isIllustrated, int isbn) : base(title, author,
        amountOfPages)
    {
        IsIllustrated = isIllustrated;
        ISBN = isbn;
    }

    public override void PrintFullInfo()
    {
        base.PrintFullInfo();
        Console.WriteLine("ISBN: " + ISBN);
    }
}