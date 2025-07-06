//Abstract Document class
public abstract class Document
{
    public abstract void PrintType();
}

//Concrete Document classes
public class WordDocument : Document
{
    public override void PrintType() => Console.WriteLine("This is a Word document.");
}
public class PdfDocument : Document
{
    public override void PrintType() => Console.WriteLine("This is a PDF document.");
}
public class ExcelDocument : Document
{
    public override void PrintType() => Console.WriteLine("This is an Excel document.");
}

//Abstract Factory
public abstract class DocumentFactory
{
    public abstract Document CreateDocument();
}

//Concrete Factories
public class WordDocumentFactory : DocumentFactory
{
    public override Document CreateDocument() => new WordDocument();
}
public class PdfDocumentFactory : DocumentFactory
{
    public override Document CreateDocument() => new PdfDocument();
}
public class ExcelDocumentFactory : DocumentFactory
{
    public override Document CreateDocument() => new ExcelDocument();
}

//Test Factory Method Pattern
class Program
{
    static void Main(string[] args)
    {
        DocumentFactory wordFactory = new WordDocumentFactory();
        Document wordDoc = wordFactory.CreateDocument();
        wordDoc.PrintType();

        DocumentFactory pdfFactory = new PdfDocumentFactory();
        Document pdfDoc = pdfFactory.CreateDocument();
        pdfDoc.PrintType();

        DocumentFactory excelFactory = new ExcelDocumentFactory();
        Document excelDoc = excelFactory.CreateDocument();
        excelDoc.PrintType();
    }
}
