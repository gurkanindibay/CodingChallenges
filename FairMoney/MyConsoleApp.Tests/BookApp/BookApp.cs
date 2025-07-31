[TestFixture]
public class BookAppTests
{


    [Test]
    public void TestAddBook()
    {
        LibraryManager libraryManager = new LibraryManager();

        libraryManager.AddBook(new Book("1", "Test", "Auth1", 2020, true));
        libraryManager.AddBook(new Book("2", "Title1", "Auth2", 2021, true));
        libraryManager.AddBook(new Book("3", "SciFi1", "Auth3", 2022, true));

        var books = libraryManager.SearchBooks("");

        Assert.That(books.Count(), Is.EqualTo(3));
    }

    [Test]
    public void TestSearchWithTitle()
    {
        LibraryManager libraryManager = new LibraryManager();

        libraryManager.AddBook(new Book("1", "Test", "Auth1", 2020, true));
        libraryManager.AddBook(new Book("2", "Title1", "Auth2", 2021, true));
        libraryManager.AddBook(new Book("3", "SciFi1", "Auth3", 2022, true));

        var books = libraryManager.SearchBooks("Title1");

        Assert.That(books.Count(), Is.EqualTo(1));
    }

    [Test]
    public void TestSearchWithAuthor()
    {
        LibraryManager libraryManager = new LibraryManager();

        libraryManager.AddBook(new Book("1", "Test", "Auth1", 2020, true));
        libraryManager.AddBook(new Book("2", "Title1", "Auth2", 2021, true));
        libraryManager.AddBook(new Book("3", "SciFi1", "Auth3", 2022, true));

        var books = libraryManager.SearchBooks("Auth1");

        Assert.That(books.Count(), Is.EqualTo(1));
    }


    [Test]
    public void TestSearchWithGenre()
    {
        LibraryManager libraryManager = new LibraryManager();

        libraryManager.AddBook(new Book("1", "Test", "Auth1", 2020, true));
        libraryManager.AddBook(new Book("2", "Title1", "Auth2", 2021, true));
        libraryManager.AddBook(new Book("3", "SciFi1", "Auth3", 2022, true));

        var books = libraryManager.SearchBooks(null, Genre.ScienceFiction);

        Assert.That(books.Count(), Is.EqualTo(1));
    }
}