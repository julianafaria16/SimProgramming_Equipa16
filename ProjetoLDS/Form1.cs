using System;
using System.IO;
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

        private void UnirFicheirosGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            view.UnirFicheirosGrdViewCellContentClick(e, UnirFicheirosGridView);
        }

        private void ProcurarPastaBt_Click(object sender, EventArgs e)
        {
            view.ProcurarPastaClick(folderBrowserDialog1, EnderecoPastaDestinoTxt);
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

        private void ConcatenarFicheirosBt_Click(object sender, EventArgs e)
        {
            if (EnderecoPastaDestinoTxt.Text.Length < 1 || !Directory.Exists(EnderecoPastaDestinoTxt.Text))
            {
                MessageBox.Show("Deve introduzir a pasta de destino, antes de continuar.");
                return;
            }

            view.ConcatenarFicheirosClick(sender, e, GetFiles(), EnderecoPastaDestinoTxt);
        }
    }
}