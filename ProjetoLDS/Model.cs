using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;

namespace ProjetoLDS
{
    class Model
    {
        private View view;
        
        public Model(View v)
        {
            view = v;
        }

        public void IntroduzirFicheiro(object origem, EventArgs e)
        {
            
        }

        public string ConcatenarFicheiros(string[] ficheiros, string pastaDestino)
        {
            // Open the output document
            PdfDocument outputDocument = new PdfDocument();

            // Iterate files
            foreach (string file in ficheiros)
            {
                // Open the document to import pages from it.
                PdfDocument inputDocument = PdfReader.Open(file, PdfDocumentOpenMode.Import);

                // Iterate pages
                int count = inputDocument.PageCount;
                for (int idx = 0; idx < count; idx++)
                {
                    // Get the page from the external document...
                    PdfPage page = inputDocument.Pages[idx];
                    // ...and add it to the output document.
                    outputDocument.AddPage(page);
                }
            }

            // Save the document...
            string filename = pastaDestino + "\\ConcatenatedDocument1.pdf";
            outputDocument.Save(filename);

            return filename;
        }

    }
}
