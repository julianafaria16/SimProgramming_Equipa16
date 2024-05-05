using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetoLDS
{
    public class View
    {
        private Model model;
        private Form1 janela;

        public event System.EventHandler ProcessarIntrodFicheiro;

        //public event SolicitacaoListaFormas PrecisoDeFormas;

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

    }
}
