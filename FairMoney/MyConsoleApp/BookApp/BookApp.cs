public record Book(

    string Id,
    string Title,
    string Author,
    int PublicationYear,
    bool IsAvailable = true
);

public record Loan(
    string BookId,
    string Borrower,
    DateTime DueDate
);

public enum Genre
{
    Fiction, NonFiction, ScienceFiction, Mystery, Biography
}

public class LibraryManager
{
    private List<Book> _books = [];
    private List<Loan> _loans = [];

    public async void AddBook(Book book)
    {
        ArgumentNullException.ThrowIfNull(book);

        Thread.Sleep(10);//Database operation
        _books.Add(book);
    }

    public IEnumerable<Book> SearchBooks(string? searchTerm, Genre? genre = null)
    {
        return _books.Where(b => (string.IsNullOrEmpty(searchTerm) ||
        b.Author.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
        b.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)) &&
        (!genre.HasValue || genre.Value switch
        {
            Genre.ScienceFiction => b.Title.StartsWith("SciFi"),
            Genre.Mystery => b.Title.StartsWith("Mystery"),
            _ => false
        }));
    }

    public record LoanResult
    {
        public bool Success;
        public string Message;
    }

    public async Task<LoanResult> BorrowBook(string bookId, string borrower)
    {

        ArgumentNullException.ThrowIfNullOrEmpty(bookId);
        ArgumentNullException.ThrowIfNullOrEmpty(borrower);

        var book = _books.Find(b => b.Id == bookId && b.IsAvailable);

        LoanResult result = null;

        if (book is null)
        {
            result = new LoanResult { Success = false, Message = "Book could not be found" };
        }
        else
        {
            _books.Remove(book);
            _books.Add(book with { IsAvailable = false });
        }

        _loans.Add(new Loan(bookId, borrower, DateTime.Today.AddDays(14)));
        await Task.Delay(10);

        result = new LoanResult { Success = true, Message = "Book successfully reserved" };

        return result;
    }

    public async Task<LoanResult> ReturnBook(string bookId, string borrower)
    {

        ArgumentNullException.ThrowIfNullOrEmpty(bookId);
        ArgumentNullException.ThrowIfNullOrEmpty(borrower);

        var loan = _loans.Find(b => b.BookId == bookId && b.Borrower == borrower);
        var book = _books.Find(b => b.Id == bookId);

        LoanResult result = null;

        if (loan is null)
        {
            result = new LoanResult { Success = false, Message = "Loan could not be found" };
        }
        else if (book is null)
        {
            result = new LoanResult { Success = false, Message = "Book could not be found" };
        }
        else
        {
            _loans.Remove(loan);

            _books.Remove(book);
            _books.Add(book with { IsAvailable = true });
        }

        await Task.Delay(10);

        result = new LoanResult { Success = true, Message = "Book successfully returned" };

        return result;
    }

}