using System;
using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;

namespace ProjetoLDS
{
    public interface IModel
    {
        void IntroduzirFicheiro(object origem, EventArgs e);
        string ConcatenarFicheiros(string[] ficheiros, string pastaDestino);
        bool EliminarPaginas(string ficheiroPdf, int[] paginas);
    }

    class Model : IModel
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

        public bool EliminarPaginas(string ficheiroPdf, int[] paginas)
        {
            // Open the file
            PdfDocument inputDocument = PdfReader.Open(ficheiroPdf, PdfDocumentOpenMode.Modify);

            //É necessário ordenar as páginas que são para eliminar por ordem decrescente, porque temos de começar pelas últimas, porque após eliminar
            //uma página, a numeração das páginas seguintes diminui 1 posição

            Array.Reverse(paginas);

            int _cnt = inputDocument.PageCount;

            for (int i = 0; i < paginas.Length; i++)
            {
                if (paginas[i]-1 < 0 || paginas[i]-1 > _cnt - 1)
                    return false;

                inputDocument.Pages.RemoveAt(paginas[i]-1);
                inputDocument.Save(ficheiroPdf);
            }

            return true;

        }

    }
}