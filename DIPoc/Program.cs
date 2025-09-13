namespace DIPoc;

public class Book 
{
    private List<IChapter> chapters = [];

    public void CreateNewChapter() 
    {
        var chapter = new Chapter { PageNumber = 1, Title = "The Vanishing Glass" };
        chapters.Add(chapter);
        
        chapters.Add(IChapter.Create(1, "The Vanishing Glass"));
    }
}

public interface IChapter
{
    int? NumberOfParagraphs { get; init; }
    int PageNumber { get; init; }
    string Title { get; init; }
    string Title2 { get; init; }

    static Chapter Create(int pageNumber, string title, int? numberOfParagraphs = null)
    {
        var chapter = new Chapter { PageNumber = pageNumber, Title = title, NumberOfParagraphs = numberOfParagraphs, Title2 = "" };
        return chapter;
    }
}
public class Chapter : IChapter
{
    public required string Title { get; init; }
    public required string Title2 { get; init; }
    public int PageNumber { get; init; }
    public int? NumberOfParagraphs { get; init; }
}