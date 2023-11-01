namespace Lab4;

/// <summary>
/// Describes catalog with pages and elements within
/// </summary>
public class Catalog
{
    /// <summary>
    /// Represents catalog pages with items with page, items
    /// </summary>
    private Dictionary<int, List<PrintedText>> CatalogPages { get; }

    /// <summary>
    /// To operate with items on current page in methods like
    /// TurnPage <see cref="TurnPage"/>
    /// ShowShortIno <see cref="ShowFullInfo"/>
    /// </summary>
    public int CurrentPage { get; set; }
    
    private int amountOfPages;
    /// <summary>
    /// To control pages amount within catalog
    /// Cannot be <1
    /// </summary>
    /// <exception cref="Exception">If value to set <1</exception>
    public int AmountOfPages
    {
        get { return amountOfPages; }
        set
        {
            if (value < 1)
            {
                throw new Exception("Amoung of pages must be >= 1");
            }

            amountOfPages = value;
        }
    }
    
    private int itemsOnPage;
    /// <summary>
    /// To contorl items on a single page
    ///
    /// Cannot be <1
    /// </summary>
    /// <exception cref="Exception">If set value <1 </exception>
    public int ItemsOnPage
    {
        get { return itemsOnPage; }
        set
        {
            if (value < 1)
            {
                throw new Exception("Amoung of items on page must be >= 1");
            }

            itemsOnPage = value;
        }
    }

    public Catalog(int itemsOnPage)
    {
        AmountOfPages = 1;
        CurrentPage = 1;
        ItemsOnPage = itemsOnPage;
        CatalogPages = new Dictionary<int, List<PrintedText>>(itemsOnPage)
        {
            {1, new List<PrintedText>()}
        };

    }
    public Catalog() : this(4){}

    /// <summary>
    /// Adds text to the last page
    /// if it's full, adds to a new page
    /// </summary>
    /// <param name="text">Item to add</param>
    public void AddPrintedText(PrintedText text)
    {
        if (CatalogPages[amountOfPages].Count < itemsOnPage)
        {
            CatalogPages[amountOfPages].Add(text);
        }
        else
        {
            CatalogPages.Add(amountOfPages + 1, new List<PrintedText>(itemsOnPage));
            CatalogPages[amountOfPages + 1].Add(text);
            amountOfPages++;
        }
    }
    
    /// <summary>
    /// Adds text to a certain page
    /// </summary>
    /// <param name="text"> Item to add</param>
    /// <param name="page">Page to add</param>
    /// <exception cref="Exception">Checks if there is key(page) in catalog</exception>
    public void AddPrintedText(PrintedText text, int page)
    {
        if (!(CatalogPages.ContainsKey(page)))
        {
            throw new Exception("There is no such page");
        }
        
        if (CatalogPages[page].Count < itemsOnPage)
        {
            CatalogPages[page].Add(text);
        }
        else
        {
            CatalogPages.Add(page + 1, new List<PrintedText>(itemsOnPage));
            CatalogPages[page + 1].Add(text);
            amountOfPages++;
        }
    }

    /// <summary>
    /// Finds item by title and removes it
    /// </summary>
    /// <param name="title"> title to remove </param>
    public void RemoveItem(string title)
    {
        foreach (KeyValuePair<int, List<PrintedText>> entry in CatalogPages)
        {
            int index = entry.Value.FindIndex(x => x.Title == title);
            if (index == -1)
            {
                continue;
            }
            else
            {
                entry.Value.RemoveAt(index);
            }
        }
    }
    /// <summary>
    /// Shows short info of all items on CurrentPage<see cref="CurrentPage"/>
    /// </summary>
    public void ShowPageInfo()
    {
        foreach (PrintedText item in CatalogPages[CurrentPage])
        {
           item.PrintShortInfo(); 
        }
    }

    /// <summary>
    /// Shows full info of title on CurrentPage <see cref="CurrentPage"/>
    /// </summary>
    /// <param name="title"></param>
    public void ShowFullInfo(string title)
    {
        CatalogPages[CurrentPage].Find(x => x.Title == title).PrintFullInfo();
    }

    /// <summary>
    /// Increments/Decrements CurrnetPage <see cref="CurrentPage"/>
    /// depending on direction value
    /// true to turn forth
    /// false to turn back
    /// </summary>
    /// <param name="direction">Defines turn forth of back</param>
    public void TurnPage(bool direction)
    {
        if (direction == true && CurrentPage < amountOfPages)
        {
            CurrentPage++;
        }
        else if (direction == false && CurrentPage > 1)
        {
            CurrentPage--;
        }
    }
}