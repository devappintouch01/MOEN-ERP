using System;
using System.Collections.Generic;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace MOEN_ERP.Utilities
{
    public class PdfMerger
    {

        public static byte[] MergePdfFiles(List<byte[]> pdfBytes)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Document document = new Document();
                PdfCopy copy = new PdfCopy(document, ms);
                document.Open();

                foreach (var pdfBytesArray in pdfBytes)
                {
                    PdfReader reader = new PdfReader(pdfBytesArray);
                    int pageCount = reader.NumberOfPages;
                    for (int i = 0; i < pageCount;)
                    {
                        copy.AddPage(copy.GetImportedPage(reader, ++i));
                    }

                    copy.FreeReader(reader);
                    reader.Close();
                }

                document.Close();
                return ms.ToArray();
            }
        }


    }
}
