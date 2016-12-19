using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace PdfParsingiTextSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ExtractTextFromPdf("Spiewnik KFC.pdf"));
        }

        public static string ExtractTextFromPdf(string path)
        {
            using (PdfReader reader = new PdfReader(path))
            {
                StringBuilder text = new StringBuilder();

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }


                return text.ToString();
            }
        }
    }
}
