using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace ProjetoLDS
{
    public class View
    {
        private Model model;
        private Form1 janela;

        public event EventHandler ProcessarIntrodFicheiro;
        //public event EventHandler ProcessarConcatFicheiros;

        internal View(Model m)
        {
            model = m;
        }

        public void AtivarInterface()
        {
            janela = new Form1
            {
                View = this
            };

            // A API WinForms desenha as janelas e botões automaticamente
            janela.ShowDialog();
        }

        public void ProcurarFicheiro(OpenFileDialog opnFlDl, TextBox outputTxtBx)
        {
            opnFlDl.Filter = "Ficheiros PDF (*.pdf)|*.pdf|Todos os ficheiros (*.*)|*.*";
            opnFlDl.ShowDialog();
            outputTxtBx.Text = opnFlDl.FileName;
        }

        public void InserirFicheiroClick(object origem, EventArgs e, OpenFileDialog opnFlDl, DataGridView gridView, TextBox outputTxtBx)
        {
           //Validar se o ficheiro existe
            if (!File.Exists(outputTxtBx.Text))
            {
                MessageBox.Show("Esse ficheiro não existe.");
                ProcurarFicheiro(opnFlDl, outputTxtBx);
                return;
            }

            //Ligar ao controller
            ProcessarIntrodFicheiro(origem, e);

            //Output
            gridView.Rows.Add(outputTxtBx.Text, "Pré-Visualizar", "Eliminar");
            outputTxtBx.Clear();
            gridView.ClearSelection();
        }

        public void UnirFicheirosGrdViewCellContentClick(DataGridViewCellEventArgs e, DataGridView gridView)
        {
            if (gridView.SelectedCells.Count > 1)
                return;

            if (e.ColumnIndex == 1)
                Process.Start(gridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (e.ColumnIndex == 2)
                gridView.Rows.RemoveAt(e.RowIndex);
        }

        public void ProcurarPastaClick(FolderBrowserDialog flBrwDl, TextBox outputTxtBx)
        {
            flBrwDl.ShowDialog();
            outputTxtBx.Text = flBrwDl.SelectedPath;
        }

        public void ConcatenarFicheirosClick(object origem, EventArgs e, string[] ficheiros, TextBox destinationFolderTxtBx)
        {
            //Ligar ao controller
            Controller controller = new Controller(ficheiros, destinationFolderTxtBx.Text);
            var ficheiroContactenado = controller.ProcessarConcatFicheiros(origem, e);

            //Abrir ficheiro
            Process.Start(ficheiroContactenado);
        }
    }
}
