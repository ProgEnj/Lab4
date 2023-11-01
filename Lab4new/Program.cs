using Lab4;

bool quit = true;

Catalog catalog = new Catalog(4);
catalog.AddPrintedText(new Magazine("Title", "author", 10, new DateTime(2023, 12, 12), "country", "originalTitle", 20, "faceHeader"));
catalog.AddPrintedText(new Magazine("Title1", "author1", 10, new DateTime(2023, 12, 12), "country1", "originalTitle1", 20, "faceHeader1"));
catalog.AddPrintedText(new Magazine("Title3", "author3", 10, new DateTime(2023, 12, 12), "country3", "originalTitle3", 20, "faceHeader3"));
catalog.AddPrintedText(new Magazine("Title4", "author4", 10, new DateTime(2023, 12, 12), "country4", "originalTitle4", 20, "faceHeader4"));
catalog.AddPrintedText(new Magazine("Title5", "author5", 10, new DateTime(2023, 12, 12), "country5", "originalTitle5", 20, "faceHeader5"));
catalog.AddPrintedText(new Magazine("Title6", "author6", 10, new DateTime(2023, 12, 12), "country6", "originalTitle6", 20, "faceHeader6"));
catalog.AddPrintedText(new Magazine("Title7", "author7", 10, new DateTime(2023, 12, 12), "country7", "originalTitle7", 20, "faceHeader7"));
catalog.AddPrintedText(new Book("Book", "author8", 10, new DateTime(2023, 12, 12), "country8", "originalTitle8", true, 5563));

while (quit)
{
    Console.WriteLine("1 to next page, 0 to previous, 2 add to catalog, 3 delete from current page, 4 show full info, 5 to quit");
    Console.WriteLine($"Page: {catalog.CurrentPage}");
    catalog.ShowPageInfo();
    int input = Convert.ToInt32(Console.ReadLine());
    if (input == 1 || input == 0)
    {
        catalog.TurnPage(Convert.ToBoolean(input));
    }
    else if (input == 2)
    {
        Console.WriteLine("Enter, title, author, pages, publ. date, country, original title, IsIllustrated, ISBN");
        catalog.AddPrintedText(new Book(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), 
            new DateTime(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())),
                Console.ReadLine(), Console.ReadLine(), Convert.ToBoolean(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));
    }
    else if (input == 3)
    {
        catalog.RemoveItem(Console.ReadLine());
    }
    else if (input == 4)
    {
        catalog.ShowFullInfo(Console.ReadLine());
    }
    else if (input == 5)
    {
        quit = false;
    }
}