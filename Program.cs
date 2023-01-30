using System.Diagnostics.Tracing;

namespace ConsoleApp55
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Keywords: Console.WriteLine(" Enter keyword");
            var keyword = Console.ReadLine();
            switch (keyword.ToLower())
            {
                case "basic":
                    var documentProgram = new DocumentProgram();
                    documentProgram.OpenDocument();
                    documentProgram.EditDocument();
                    documentProgram.SaveDocuent();
                    break;
                case "pro":
                    var proDocumentProgram = new ProDocumentProgram();
                    proDocumentProgram.OpenDocument();
                    proDocumentProgram.EditDocument();
                    proDocumentProgram.DocFormat();
                    break;
                case " expert":
                    var expertDocumentProgram = new ExpertDocumentProgram();
                    expertDocumentProgram.OpenDocument();
                    expertDocumentProgram.EditDocument();
                    expertDocumentProgram.PDFformat();
                    break;
                default:
                    goto Keywords;
            }
           
        }
                
    }
}