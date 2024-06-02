using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace ProjetoLDS
{
    public class View
    {
        private IModel model;
        private Form1 janela;

        public event EventHandler ProcessarIntrodFicheiro;
        //public event EventHandler ProcessarConcatFicheiros;

        internal View(IModel m)
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
            Controller controller = new Controller(ficheiros, destinationFolderTxtBx.Text, null, null);
            var ficheiroContactenado = controller.ProcessarConcatFicheiros(origem, e);

            //Abrir ficheiro
            Process.Start(ficheiroContactenado);
        }

        public void EliminarPaginasClick(object origem, EventArgs e, string ficheiroPdf, int[] paginasParaEliminar)
        {
            //Ligar ao controller
            Controller controller = new Controller(null, null, ficheiroPdf, paginasParaEliminar);
            var resposta = controller.ProcessarEliminarPaginas(origem, e);

            //Abrir ficheiro
            if (!resposta)
                MessageBox.Show("Ocorreu um erro. Tente novamente");
            else
                MessageBox.Show("A(s) página(s) indicada(s) fora(m) eliminada(s) com sucesso.");

        }

    }
}