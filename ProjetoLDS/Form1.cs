using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLDS
{
    public partial class Form1 : Form
    {
        View view;

        public Form1()
        {
            InitializeComponent();
        }

        public View View { get => view; set => view = value; }

        private void ProcurarBt_Click(object sender, EventArgs e)
        {
            view.ProcurarFicheiro(openFileDialog1, EnderecoFicheiroTxt);
        }

        private void InserirBt_Click(object sender, EventArgs e)
        {
            view.InserirFicheiroClick(sender, e, openFileDialog1, UnirFicheirosGridView, EnderecoFicheiroTxt);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UnirFicheirosGridView.SelectedCells.Count > 1)
                return;

            if (e.ColumnIndex == 1)
                Process.Start(UnirFicheirosGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (e.ColumnIndex == 2)
                UnirFicheirosGridView.Rows.RemoveAt(e.RowIndex);

        }

        private void ProcurarPastaBt_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            EnderecoPastaDestinoTxt.Text = folderBrowserDialog1.SelectedPath;
        }

        private string[] GetFiles()
        {
            string[] ficheiros = new string[UnirFicheirosGridView.Rows.Count];
            var i = 0;

            foreach (DataGridViewRow item in UnirFicheirosGridView.Rows)
            {
                ficheiros[i] = item.Cells["NomeFicheiro"].Value.ToString();
                i++;
            }
            return ficheiros;
        }

        private void ConcatenarFicheiros()
        {
            // Get some file names
            string[] files = GetFiles();

            // Open the output document
            PdfDocument outputDocument = new PdfDocument();

            // Iterate files
            foreach (string file in files)
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
            string filename = EnderecoPastaDestinoTxt.Text+"\\ConcatenatedDocument1.pdf";
            outputDocument.Save(filename);
            // ...and start a viewer.
            Process.Start(filename);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConcatenarFicheiros();
        }

    }
}
