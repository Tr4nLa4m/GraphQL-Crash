namespace GraphQL_Crash
{
    public class Query
    {
        public Books GetBook() =>
        new Books
        {
            Title = "C# in depth.",
            Author = new Author
            {
                Name = "Jon Skeet"
            }
        };
    }
}
