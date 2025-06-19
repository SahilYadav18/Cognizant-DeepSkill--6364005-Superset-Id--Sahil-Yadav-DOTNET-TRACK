using System;

public interface IDocument
{
    void Open();
}

public class WordDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Word Doc opened....");
    }
}

public class PdfDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("PDF Doc opened....");
    }
}

public class ExcelDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Excel Doc opened....");
    }
}

public abstract class DocumentFactory
{
    public abstract IDocument CreateDocument();
}

public class WordDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new WordDocument();
    }
}

public class PdfDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new PdfDocument();
    }
}

public class ExcelDocumentFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new ExcelDocument();
    }
}

public class DocumentTesting
{
    public static void Main(string[] args)
    {
        DocumentFactory d1 = new WordDocumentFactory();
        IDocument d2 = d1.CreateDocument