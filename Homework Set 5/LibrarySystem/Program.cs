namespace LibrarySystem;

public class Program
{
    static void Main(string[] args)
    {
        EBook eBook = new("Where the Red Fern Grows", "Wilson Rawls", 1961, 134);
        PrintedBook printBook = new("To Kill a Mockingbird", "Harper Lee", 1960, 336);

        Console.WriteLine(eBook);
        Console.WriteLine(printBook);
    }
}

public class Book
{
    // Backing Fields
    private string title = "n/a";
    private string author = "n/a";
    private int yearPublished = -1;

    // Gets and Sets
    public string Title
    {
        get => title;
        set => title = value;
    }
    public string Author
    {
        get => author;
        set => author = value;
    }
    public int YearPublished
    {
        get => yearPublished;
        set => yearPublished = value;
    }

    // Constructors
    public Book(string title, string author, int yearPublished)
    {
        Title = title;
        Author = author;
        YearPublished = yearPublished;
    }

    // Methods
    public override string ToString() => $"{Title} by {Author} ({YearPublished})";
}

public class EBook : Book
{
    // Backing Fields
    private int fileSizeMB = -1;

    // Properties
    public int FileSizeMB
    {
        get => fileSizeMB;
        set => fileSizeMB = value;
    }

    // Constructors
    public EBook(string title, string author, int yearPublished, int sizeInMB) : base(title, author, yearPublished) => FileSizeMB = sizeInMB;

    // Methods
    public override string ToString() => base.ToString() + $" Size: {FileSizeMB} MB";
}

public class PrintedBook : Book
{
    // Backing Fields
    private int pageCount = -1;

    // Properties
    public int PageCount
    {
        get => pageCount;
        set => pageCount = value;
    }

    // Constructors
    public PrintedBook(string title, string author, int yearPublished, int numPages) : base(title, author, yearPublished) => PageCount = numPages;

    // Methods
    public override string ToString() => base.ToString() + $" # of Pages: {PageCount}";
}
