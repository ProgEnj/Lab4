namespace Lab4;
/// <summary>
/// Represents magazine
/// </summary>
public class Magazine : PrintedText
{
    private int IssueNumber { get; set; }
    private string FaceHeader { get; set; }

    public Magazine(string title, string author, int amountOfPages, DateTime publicationDate, string country,
        string originalTitle, int issueNumber, string faceHeader) : base(title, author, amountOfPages, publicationDate, country,
        originalTitle)
    {
        IssueNumber = issueNumber;
        FaceHeader = faceHeader;
    }

    public Magazine(string title, string author, int amountOfPages, int issueNumber, string faceHeader) : base(title, author,
        amountOfPages)
    {
        IssueNumber = issueNumber;
        FaceHeader = faceHeader;
    }
    
    public override void PrintFullInfo()
    {
        base.PrintFullInfo();
        Console.WriteLine("Issue number: " + IssueNumber);
        Console.WriteLine("FaceHeader: " + FaceHeader);
    }
}